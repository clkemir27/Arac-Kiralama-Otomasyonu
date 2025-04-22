using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Rent_A_Car
{
    public partial class AraçKayıt : Form
    {
        private DataTable AraçDataTable;
        static string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private int tutar;
        private int gün;
        private string kiraşekli;
        public int MüşteriBilgileriID;
        public int AraçID;

        public AraçKayıt()
        {
            InitializeComponent();

        }



        private void Marka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Seri.Items.Clear();
                if (Marka.SelectedItem.ToString() == "Toyota")
                {
                    Seri.Items.Add("Avensis");
                    Seri.Items.Add("Corolla");
                    Seri.Items.Add("Hilux");
                }
                else if (Marka.SelectedIndex == 1)
                {
                    Seri.Items.Add("Jetta");
                    Seri.Items.Add("Passat");
                    Seri.Items.Add("Tiguan");
                }
                else if (Marka.SelectedIndex == 2)
                {
                    Seri.Items.Add("Corsa");
                    Seri.Items.Add("Astra");
                    Seri.Items.Add("Grandland");
                }
                else if (Marka.SelectedIndex == 3)
                {
                    Seri.Items.Add("Megane");
                    Seri.Items.Add("Clio");
                    Seri.Items.Add("Taliant");
                }
                else if (Marka.SelectedIndex ==4)
                {
                    Seri.Items.Add("Maybach");
                    Seri.Items.Add("C200");
                    Seri.Items.Add("G63");
                }
                else if (Marka.SelectedIndex == 5)
                {
                    Seri.Items.Add("S90");
                    Seri.Items.Add("C40");
                    Seri.Items.Add("V90");
                }
                else if (Marka.SelectedIndex == 6 )
                {
                    Seri.Items.Add("iX");
                    Seri.Items.Add("330");
                    Seri.Items.Add("F30");
                }
            }
            catch
            {
            }
        }
        private void Kayıt_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(Plaka.Text) || string.IsNullOrWhiteSpace(Marka.Text) || string.IsNullOrWhiteSpace(Seri.Text) || string.IsNullOrWhiteSpace(Model.Text) || string.IsNullOrWhiteSpace(Renk.Text) || string.IsNullOrWhiteSpace(KM.Text) || string.IsNullOrWhiteSpace(Yakıt.Text) || string.IsNullOrWhiteSpace(KiraÜcreti.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
                return;
            }

            byte[] imageBytes = null;       
            if (pictureBox1.Image != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())          
                {
                    ImageFormat format; 
                 
                    if (pictureBox1.Image.RawFormat.Equals(ImageFormat.Jpeg))
                    {
                        format = ImageFormat.Jpeg;
                    }
                    else if (pictureBox1.Image.RawFormat.Equals(ImageFormat.Png))
                    {
                        format = ImageFormat.Png;
                    }
                    else
                    {
                        
                        format = ImageFormat.Jpeg;
                    }                    
                    pictureBox1.Image.Save(memoryStream, format);                                                                                                      //// Resmi  bellek akışına kaydetme
                    imageBytes = memoryStream.ToArray();                                                                                                                       //byte yapma
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ekle = "INSERT INTO dbo.Araç ( Plaka, Marka, Seri, Model, Renk, Km, Yakıt, KiraÜcreti,  Tarih, Resim) " +
                              "VALUES (@Plaka, @Marka, @Seri, @Model, @Renk, @Km, @Yakıt, @KiraÜcreti, @Tarih, @Resim)";

                using (SqlConnection connection = new SqlConnection(constring))
                {
                    using (SqlCommand command = new SqlCommand(ekle, connection))
                    {
                        command.Parameters.AddWithValue("@Plaka", Plaka.Text);
                        command.Parameters.AddWithValue("@Marka", Marka.Text);
                        command.Parameters.AddWithValue("@Seri", Seri.Text);
                        command.Parameters.AddWithValue("@Model", Model.Text);
                        command.Parameters.AddWithValue("@Renk", Renk.Text);
                        command.Parameters.AddWithValue("@Km", KM.Text);
                        command.Parameters.AddWithValue("@Yakıt", Yakıt.Text);
                        command.Parameters.AddWithValue("@KiraÜcreti", KiraÜcreti.Text);
                        command.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@Resim",(object)imageBytes ?? DBNull.Value);                                                                                                 // Resim için DBNull.Value kullanımı
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Araç Eklendi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }


        public void TcAra(TextBox tc, TextBox adsoyad, TextBox telefon, TextBox şehir, TextBox email, TextBox ehliyettarihi, TextBox ehliyetnumarası)
        {
            string sorgu = "SELECT ID,[Ad Soyad],[Telefon No],[Şehir],[E-Mail],[Ehliyet Tarihi],[Ehliyet Numarası] FROM MüşteriBilgileri WHERE TC = @tc";

            connect.Open();
            SqlCommand komut = new SqlCommand(sorgu, connect);
            komut.Parameters.AddWithValue("@tc", tc.Text);

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {  
              MüşteriBilgileriID =Convert.ToInt32( oku["ID"]);
                adsoyad.Text = oku["Ad Soyad"].ToString();
                telefon.Text = oku["Telefon No"].ToString();
                şehir.Text = oku["Şehir"].ToString();
                email.Text = oku["E-Mail"].ToString();
                ehliyettarihi.Text = oku["Ehliyet Tarihi"].ToString();
                ehliyetnumarası.Text = oku["Ehliyet Numarası"].ToString();
               
            }
            
            connect.Close();
        }

        public void doldur(TextBox Plaka, TextBox Marka, TextBox seri, TextBox model, TextBox renk)
        {

            string sorgu = "SELECT ID,[Marka],[Seri],[Model],[Renk] FROM Araç WHERE Plaka = @plaka";
            connect.Open();
            SqlCommand komut = new SqlCommand(sorgu, connect);
            komut.Parameters.AddWithValue("@plaka", Plaka.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                                                                                                                                                                                                                                            // MüşteriBilgileriID = Convert.ToInt32(oku["ID"]);
               AraçID = Convert.ToInt32(oku["ID"]);
                Marka.Text = oku["Marka"].ToString();
                seri.Text = oku["Seri"].ToString();
                model.Text = oku["model"].ToString();
                renk.Text = oku["Renk"].ToString();
            }
            connect.Close();
        }
        public void hesapla(ComboBox comboBox1, TextBox textbox14, string sorgu)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (comboBox1.SelectedIndex == 0) textbox14.Text = (int.Parse(oku["KiraÜcreti"].ToString()) * 1).ToString();
                if (comboBox1.SelectedIndex == 1) textbox14.Text = (int.Parse(oku["KiraÜcreti"].ToString()) * 0.80).ToString();
                if (comboBox1.SelectedIndex == 2) textbox14.Text = (int.Parse(oku["KiraÜcreti"].ToString()) * 0.60).ToString();

            }
            connect.Close();
        }

        private void Seri_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Marka.SelectedIndex == 0)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[0];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[1];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[2];
                }

            }
            if (Marka.SelectedIndex == 1)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[11];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[10];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[9];
                }

            }
            if (Marka.SelectedIndex == 2)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[8];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[7];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[6];
                }

            }
            if (Marka.SelectedIndex == 3)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[5];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[4];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[3];
                }

            }
            if (Marka.SelectedIndex == 4)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[20];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[19];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[18];
                }

            }
            if (Marka.SelectedIndex == 5)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[17];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[16];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[15];
                }

            }
            if (Marka.SelectedIndex == 6)
            {
                if (Seri.SelectedIndex == 0)
                {
                    pictureBox1.Image = ımageList2.Images[14];
                }
                else if (Seri.SelectedIndex == 1)
                {
                    pictureBox1.Image = ımageList2.Images[13];
                }
                else if (Seri.SelectedIndex == 2)
                {
                    pictureBox1.Image = ımageList2.Images[12];
                }

            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void AraçKayıt_Load(object sender, EventArgs e)
        {

        }
       
    }
}



     