using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class AraçListesi : Form
    {
        int AraçID;
        private DataTable AraçDataTable;
        static string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        public AraçListesi()
        {
            InitializeComponent();
        }

        private void AraçListesi_Load_1(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM dbo.Araç";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, connect);
                AraçDataTable = new DataTable();
                connect.Open();
                sqlDataAdapter.Fill(AraçDataTable);
                dataGridView1.DataSource = AraçDataTable;
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

        private void Kayıt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Plaka.Text) || string.IsNullOrWhiteSpace(Marka.Text) || string.IsNullOrWhiteSpace(Seri.Text) || string.IsNullOrWhiteSpace(Model.Text) || string.IsNullOrWhiteSpace(Renk.Text) || string.IsNullOrWhiteSpace(KM.Text) || string.IsNullOrWhiteSpace(Yakıt.Text) ||  string.IsNullOrWhiteSpace(KiraÜcreti.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
                return;
            }
            else
            {
                connect.Open();
                SqlCommand sorgu = new SqlCommand("SELECT * FROM Araç WHERE Plaka = '" + Plaka.Text + "'", connect);
                SqlDataReader oku = sorgu.ExecuteReader();
                using (oku)
                {
                    oku.Read();



                    string sorgu2 = "UPDATE Araç SET  Marka='" + Marka.Text + "', Model='" + Model.Text + "', Renk='" + Renk.Text + "', Km='" + KM.Text + "', Yakıt='" + Yakıt.Text + "', KiraÜcreti='" + KiraÜcreti.Text + "'WHERE Plaka='" + Plaka.Text + "'";
                    SqlCommand guncelle = new SqlCommand(sorgu2, connect);
                    oku.Close();
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Güncellenmiştir");

                    string sorgu3 = "select * from Araç ";
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu3, connect);
                    sqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                }
            }          
        }
                private void Marka_SelectedIndexChanged(object sender, EventArgs e)
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
                        else if (Marka.SelectedItem == "Volkswagen")
                        {
                            Seri.Items.Add("Jetta");
                            Seri.Items.Add("Passat");
                            Seri.Items.Add("Tiguan");
                        }
                        else if (Marka.SelectedItem == "Opel")
                        {
                            Seri.Items.Add("Corsa");
                            Seri.Items.Add("Astra");
                            Seri.Items.Add("Vectra");
                        }
                        else if (Marka.SelectedItem == "Renault")
                        {
                            Seri.Items.Add("Megane");
                            Seri.Items.Add("Clio");
                            Seri.Items.Add("Taliant");
                        }
               
            }
                    catch
                    {

                    }
                }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        } 

