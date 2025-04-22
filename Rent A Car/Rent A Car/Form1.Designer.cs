
namespace Rent_A_Car
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.AraçListesi = new System.Windows.Forms.Button();
            this.MüşteriListesi = new System.Windows.Forms.Button();
            this.AraçKayıt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SSS = new System.Windows.Forms.Button();
            this.Hakkımızda = new System.Windows.Forms.Button();
            this.Şubelerimiz = new System.Windows.Forms.Button();
            this.İletişim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.AraçListesi);
            this.panel1.Controls.Add(this.MüşteriListesi);
            this.panel1.Controls.Add(this.AraçKayıt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 113);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageIndex = 10;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(557, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 89);
            this.button7.TabIndex = 6;
            this.button7.Text = "Sözleşme";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "İletişim.png");
            this.ımageList1.Images.SetKeyName(1, "Satışlar.png");
            this.ımageList1.Images.SetKeyName(2, "AraçKayıt.png");
            this.ımageList1.Images.SetKeyName(3, "MüşteriListesi.png");
            this.ımageList1.Images.SetKeyName(4, "MüşteriEkle.jpg");
            this.ımageList1.Images.SetKeyName(5, "AraçListesi2.jpg");
            this.ımageList1.Images.SetKeyName(6, "Şubelerimiz2.png");
            this.ımageList1.Images.SetKeyName(7, "İletişim2.jpg");
            this.ımageList1.Images.SetKeyName(8, "Hakkımızda2.png");
            this.ımageList1.Images.SetKeyName(9, "SSS2.png");
            this.ımageList1.Images.SetKeyName(10, "Sözleşmee.jpg");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageIndex = 1;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(440, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 89);
            this.button5.TabIndex = 4;
            this.button5.Text = "Satışlar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AraçListesi
            // 
            this.AraçListesi.BackColor = System.Drawing.Color.White;
            this.AraçListesi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AraçListesi.ImageIndex = 5;
            this.AraçListesi.ImageList = this.ımageList1;
            this.AraçListesi.Location = new System.Drawing.Point(326, 13);
            this.AraçListesi.Name = "AraçListesi";
            this.AraçListesi.Size = new System.Drawing.Size(94, 89);
            this.AraçListesi.TabIndex = 3;
            this.AraçListesi.Text = "Araç Listesi";
            this.AraçListesi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AraçListesi.UseVisualStyleBackColor = false;
            this.AraçListesi.Click += new System.EventHandler(this.AraçListesi_Click);
            // 
            // MüşteriListesi
            // 
            this.MüşteriListesi.BackColor = System.Drawing.Color.White;
            this.MüşteriListesi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MüşteriListesi.ImageIndex = 3;
            this.MüşteriListesi.ImageList = this.ımageList1;
            this.MüşteriListesi.Location = new System.Drawing.Point(100, 13);
            this.MüşteriListesi.Name = "MüşteriListesi";
            this.MüşteriListesi.Size = new System.Drawing.Size(94, 89);
            this.MüşteriListesi.TabIndex = 2;
            this.MüşteriListesi.Text = "Müşteri Listesi";
            this.MüşteriListesi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MüşteriListesi.UseVisualStyleBackColor = false;
            this.MüşteriListesi.Click += new System.EventHandler(this.MüşteriListesi_Click);
            // 
            // AraçKayıt
            // 
            this.AraçKayıt.BackColor = System.Drawing.Color.White;
            this.AraçKayıt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AraçKayıt.ImageIndex = 2;
            this.AraçKayıt.ImageList = this.ımageList1;
            this.AraçKayıt.Location = new System.Drawing.Point(210, 13);
            this.AraçKayıt.Name = "AraçKayıt";
            this.AraçKayıt.Size = new System.Drawing.Size(94, 89);
            this.AraçKayıt.TabIndex = 2;
            this.AraçKayıt.Text = "Araç Kayıt";
            this.AraçKayıt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AraçKayıt.UseVisualStyleBackColor = false;
            this.AraçKayıt.Click += new System.EventHandler(this.AraçKayıt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(0, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Müşteri Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SSS
            // 
            this.SSS.BackColor = System.Drawing.Color.White;
            this.SSS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SSS.ImageIndex = 9;
            this.SSS.ImageList = this.ımageList1;
            this.SSS.Location = new System.Drawing.Point(532, 554);
            this.SSS.Name = "SSS";
            this.SSS.Size = new System.Drawing.Size(107, 74);
            this.SSS.TabIndex = 8;
            this.SSS.Text = "SSS";
            this.SSS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SSS.UseVisualStyleBackColor = false;
            this.SSS.Click += new System.EventHandler(this.SSS_Click);
            // 
            // Hakkımızda
            // 
            this.Hakkımızda.BackColor = System.Drawing.Color.White;
            this.Hakkımızda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hakkımızda.ImageIndex = 8;
            this.Hakkımızda.ImageList = this.ımageList1;
            this.Hakkımızda.Location = new System.Drawing.Point(355, 554);
            this.Hakkımızda.Name = "Hakkımızda";
            this.Hakkımızda.Size = new System.Drawing.Size(107, 74);
            this.Hakkımızda.TabIndex = 7;
            this.Hakkımızda.Text = "Hakkımızda";
            this.Hakkımızda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Hakkımızda.UseVisualStyleBackColor = false;
            this.Hakkımızda.Click += new System.EventHandler(this.Hakkımızda_Click);
            // 
            // Şubelerimiz
            // 
            this.Şubelerimiz.BackColor = System.Drawing.Color.White;
            this.Şubelerimiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Şubelerimiz.ImageIndex = 6;
            this.Şubelerimiz.ImageList = this.ımageList1;
            this.Şubelerimiz.Location = new System.Drawing.Point(191, 554);
            this.Şubelerimiz.Name = "Şubelerimiz";
            this.Şubelerimiz.Size = new System.Drawing.Size(111, 74);
            this.Şubelerimiz.TabIndex = 6;
            this.Şubelerimiz.Text = "Şubelerimiz";
            this.Şubelerimiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Şubelerimiz.UseVisualStyleBackColor = false;
            this.Şubelerimiz.Click += new System.EventHandler(this.Şubelerimiz_Click);
            // 
            // İletişim
            // 
            this.İletişim.BackColor = System.Drawing.Color.White;
            this.İletişim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.İletişim.ImageIndex = 7;
            this.İletişim.ImageList = this.ımageList1;
            this.İletişim.Location = new System.Drawing.Point(29, 554);
            this.İletişim.Name = "İletişim";
            this.İletişim.Size = new System.Drawing.Size(106, 74);
            this.İletişim.TabIndex = 5;
            this.İletişim.Text = "İletişim";
            this.İletişim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.İletişim.UseVisualStyleBackColor = false;
            this.İletişim.Click += new System.EventHandler(this.İletişim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rent_A_Car.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(663, 646);
            this.Controls.Add(this.SSS);
            this.Controls.Add(this.Hakkımızda);
            this.Controls.Add(this.Şubelerimiz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.İletişim);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent A Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button İletişim;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AraçListesi;
        private System.Windows.Forms.Button MüşteriListesi;
        private System.Windows.Forms.Button AraçKayıt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Şubelerimiz;
        private System.Windows.Forms.Button Hakkımızda;
        private System.Windows.Forms.Button SSS;
    }
}

