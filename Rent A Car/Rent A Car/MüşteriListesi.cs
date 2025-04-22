using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class MüşteriListesi : Form
    {
        private DataTable MüşteriBilgileriDataTable;
        static string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private int tutar;
        private int gün;
        private string kiraşekli;
        private int MüşteriBilgileriID;
        private int AraçID;
        public MüşteriListesi()
        {
            
            InitializeComponent();
        }

        private void MüşteriListesi_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM dbo.MüşteriBilgileri";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, connect);
                MüşteriBilgileriDataTable = new DataTable();
                connect.Open();
                sqlDataAdapter.Fill(MüşteriBilgileriDataTable);
                dataGridView1.DataSource = MüşteriBilgileriDataTable;
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
        private void Güncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtTelefonNo.Text) || string.IsNullOrWhiteSpace(txtŞehir.Text) || string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
                return;
            }

            try
            {
               
                int TC = int.Parse(txtTC.Text);
                string AdSoyad = txtAdSoyad.Text;
                int TelefonNo = int.Parse(txtTelefonNo.Text);
                string Şehir = txtŞehir.Text;
                string Mail = txtMail.Text;
                int EhliyetTarihi= int.Parse(textBox1.Text);
                int EhliyetNumarası= int.Parse(textBox2.Text);
                using (SqlConnection connection = new SqlConnection(constring))
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    string sorgu = "UPDATE MüşteriBilgileri SET  [Ad Soyad] = '" + AdSoyad + "', [Telefon No] = '" + TelefonNo + "', Şehir = '" + Şehir + "', [E-Mail] = '" + Mail + "', [Ehliyet Tarihi]='"+EhliyetTarihi+"',[Ehliyet Numarası]='"+EhliyetNumarası+"' WHERE TC = '" + TC + "'";
                    command.CommandText = sorgu;
                    connection.Open();
                    command.ExecuteNonQuery();                  
                    MessageBox.Show("Güncellenmiştir");



                    string kayit1 = "SELECT * FROM MüşteriBilgileri";
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(kayit1, connect);
                    sqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];



                }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            AraçID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AraçID"].Value);
            MüşteriBilgileriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MüşteriBilgileriID"].Value);
        }
    }
}
