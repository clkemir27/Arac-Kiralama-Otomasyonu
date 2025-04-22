using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class Sözleşme : Form
    {
        private DataTable SözleşmeDataTable;
        static string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private int tutar;
        private int gün;
        private string kiraşekli;
        int sözlesmeId;
     
        public Sözleşme()
        {
            InitializeComponent();
        }
        AraçKayıt sözleşme = new AraçKayıt();
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorguu = "select *from MüşteriBilgileri where TC like '" + textBox1.Text + "'";
            sözleşme.TcAra(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox12);
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select*from Araç where Plaka like '" + textBox13.Text + "' ";
            sözleşme.doldur(textBox13, textBox7, textBox8, textBox9, textBox10);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select*from Araç where Plaka like '" + textBox13.Text + "' ";
            sözleşme.hesapla(comboBox1, textBox14, sorgu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime cikisTarihi;
            DateTime donusTarihi;


            if (!DateTime.TryParse(dateTimePicker1.Text, out cikisTarihi) ||
                !DateTime.TryParse(dateTimePicker2.Text, out donusTarihi))
            {
                MessageBox.Show("Geçerli bir tarih girin.");
                return;
            }


            TimeSpan gunFarki = donusTarihi - cikisTarihi;
            double gunSayisi = gunFarki.TotalDays;


            textBox11.Text = gunSayisi.ToString();
            double costPerDay;
            if (double.TryParse(textBox14.Text, out costPerDay))
            {
                textBox15.Text = (gunSayisi * costPerDay).ToString();
            }
            else
            {
                MessageBox.Show("Geçerli bir maliyet girin.");
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()                                                                                                                                                        ////// CTRL+R+M  kısayoldan metod oluşturur
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            dateTimePicker2.Text = DateTime.Now.ToShortDateString();
            comboBox1.Text = "";
            textBox14.Text = "";
            textBox11.Text = "";
            textBox15.Text = "";
        }


      
        private void button1_Click_1(object sender, EventArgs e)
        {
        
            string sorgu = "INSERT INTO Sözleşme (kiraşekli, AraçID, MüşteriBilgileriID, gün, tutar, çıkıştarihi, dönüştarihi) VALUES (@kiraşekli, @AraçID, @MüşteriBilgileriID, @gün, @tutar, @çıkıştarihi, @dönüştarihi)";

            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                   
                    connection.Open();

                    using (SqlCommand komut = new SqlCommand(sorgu, connection))
                    {
                        komut.Parameters.AddWithValue("@AraçID", sözleşme.AraçID);
                        komut.Parameters.AddWithValue("@MüşteriBilgileriID", sözleşme.MüşteriBilgileriID);
                        komut.Parameters.AddWithValue("@kiraşekli", comboBox1.Text);

                        int gün;
                        if (!int.TryParse(textBox11.Text, out gün))
                        {
                            MessageBox.Show("Lütfen geçerli bir sayı girin.");
                            return;
                        }
                        komut.Parameters.AddWithValue("@gün", gün);
                        komut.Parameters.AddWithValue("@tutar", int.Parse(textBox15.Text));
                        komut.Parameters.AddWithValue("@çıkıştarihi", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@dönüştarihi", dateTimePicker2.Value);

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("İşlem başarıyla tamamlandı.");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Sözleşme_Load_1(object sender, EventArgs e)
        {

            try
            {
                string sorgu = "SELECT * FROM dbo.Sözleşme";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, connect);
                SözleşmeDataTable = new DataTable();
                connect.Open();
                sqlDataAdapter.Fill(SözleşmeDataTable);
                dataGridView1.DataSource = SözleşmeDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sözlesmeId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True";
            SqlConnection connect = new SqlConnection(constring);
            try
            {
               
                DateTime çıkışTarihi = dateTimePicker1.Value;
                DateTime dönüşTarihi = dateTimePicker1.Value;
                string kiraŞekli = comboBox1.Text;
                int gün = int.Parse(textBox11.Text);
                int tutar = int.Parse(textBox15.Text);
                string plaka = textBox13.Text;

                string güncelle = "UPDATE Sözleşme SET MüşteriBilgileriID = @MüşteriBilgileriID, AraçID = @AraçID, kiraşekli = @kiraşekli, gün = @gün, tutar = @tutar, çıkıştarihi = @çıkıştarihi, dönüştarihi = @dönüştarihi WHERE ID='"+ sözlesmeId +"'";

                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();
                    using (SqlCommand komut = new SqlCommand(güncelle, connection))
                    {
                        komut.Parameters.AddWithValue("@MüşteriBilgileriID", sözleşme.MüşteriBilgileriID);
                        komut.Parameters.AddWithValue("@AraçID", sözleşme.AraçID);
                        komut.Parameters.AddWithValue("@kiraşekli", kiraŞekli);
                        komut.Parameters.AddWithValue("@gün", gün);
                        komut.Parameters.AddWithValue("@tutar", tutar);
                        komut.Parameters.AddWithValue("@çıkıştarihi", çıkışTarihi);
                        komut.Parameters.AddWithValue("@dönüştarihi", dönüşTarihi);

                        komut.ExecuteNonQuery();

                        MessageBox.Show("Güncellenmiştir");
                    }
                    string sorgu2 = "SELECT * FROM dbo.Sözleşme";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu2, connection);
                    DataTable sözleşmeDataTable = new DataTable();
                    sqlDataAdapter.Fill(sözleşmeDataTable);
                    dataGridView1.DataSource = sözleşmeDataTable;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
        }

            }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
                MessageBox.Show("Lütfen Silinecek Satırı Seçin!");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //        if(dataGridView1.SelectedRows.Count > 0)
        //        {
        //            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        //        }
        //        else
        //            MessageBox.Show("Lütfen Silinecek Satırı Seçin!");
        //    }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

