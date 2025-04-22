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
    public partial class MüşteriKayıt : Form
    {
        int MüşteriBilgileriID;
        private DataTable MüşteriBilgileriDataTable;
        static string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog = RentACar; Integrated Security = True";
        SqlConnection connect = new SqlConnection(constring);
        public MüşteriKayıt()
        {
            InitializeComponent();
        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            



            string ekle = "INSERT INTO dbo.MüşteriBilgileri ( TC, [Ad Soyad], [Telefon No], Şehir, [E-Mail], [Ehliyet Tarihi], [Ehliyet Numarası]) " +
                          "VALUES ( @TC, @AdSoyad, @TelefonNo, @Sehir, @Email, @EhliyetTarihi, @EhliyetNumarasi)";

            using (SqlConnection connection = new SqlConnection(constring))
            {
                using (SqlCommand command = new SqlCommand(ekle, connection))
                {
                    
                    //command.Parameters.AddWithValue("@ID",MüşteriBilgileriID);
                    command.Parameters.AddWithValue("@TC", txtTC.Text);
                    command.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                    command.Parameters.AddWithValue("@TelefonNo", txtTelefonNo.Text);
                    command.Parameters.AddWithValue("@Sehir", txtŞehir.Text);
                    command.Parameters.AddWithValue("@Email", textBox2.Text);
                    command.Parameters.AddWithValue("@EhliyetTarihi", textBox1.Text);
                    command.Parameters.AddWithValue("@EhliyetNumarasi", txtehliyetnumarası.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Müşteri Eklendi");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Veritabanı Hatası: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HATA: " + ex.Message);
                    }
                }
            }
        }


        private void MüşteriKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}

