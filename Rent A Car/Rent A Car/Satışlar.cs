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
    public partial class Satışlar : Form
    {
        private DataTable SözleşmeDataTable;
        static string constring = "Data Source=DESKTOP-MV54P42\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        public Satışlar()
        {
            InitializeComponent();
        }

        private void Satışlar_Load(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT * FROM dbo.Sözleşme";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu2, connect);
            SözleşmeDataTable = new DataTable();
            connect.Open();
            sqlDataAdapter.Fill(SözleşmeDataTable);
            dataGridView1.DataSource = SözleşmeDataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if
              (dataGridView1.SelectedRows.Count > 0)

            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }

            else

            {

                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");

            }
        }
    }
}
