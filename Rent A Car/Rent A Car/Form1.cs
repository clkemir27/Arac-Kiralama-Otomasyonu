using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriKayıt ekle = new MüşteriKayıt();
            ekle.ShowDialog();
        }

        private void İletişim_Click(object sender, EventArgs e)
        {
            İletişim ekle = new İletişim();
            ekle.ShowDialog();
        }

        private void Şubelerimiz_Click(object sender, EventArgs e)
        {
            Şubelerimiz ekle = new Şubelerimiz();
            ekle.ShowDialog();
        }

        private void Hakkımızda_Click(object sender, EventArgs e)
        {
           Hakkımızda ekle = new Hakkımızda();
            ekle.ShowDialog();
        }

      

        private void SSS_Click(object sender, EventArgs e)
        {
            SSS ekle = new SSS();
            ekle.ShowDialog();
        }

        private void MüşteriListesi_Click(object sender, EventArgs e)
        {
            MüşteriListesi ekle2 = new MüşteriListesi();
            ekle2.ShowDialog();
        }

        private void AraçKayıt_Click(object sender, EventArgs e)
        {
            AraçKayıt ekle2 = new AraçKayıt();
            ekle2.ShowDialog();
        }

        private void AraçListesi_Click(object sender, EventArgs e)
        {
            AraçListesi ekle2 = new AraçListesi();
            ekle2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sözleşme ekle2 = new Sözleşme();
            ekle2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Satışlar ekle2 = new Satışlar();
            ekle2.ShowDialog();
        }
    }
}
