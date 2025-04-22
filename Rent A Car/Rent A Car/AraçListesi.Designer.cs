
namespace Rent_A_Car
{
    partial class AraçListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kayıt = new System.Windows.Forms.Button();
            this.Plaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.KiraÜcreti = new System.Windows.Forms.ComboBox();
            this.Yakıt = new System.Windows.Forms.ComboBox();
            this.KM = new System.Windows.Forms.ComboBox();
            this.Renk = new System.Windows.Forms.ComboBox();
            this.Model = new System.Windows.Forms.ComboBox();
            this.Seri = new System.Windows.Forms.ComboBox();
            this.Marka = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 642);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kayıt
            // 
            this.Kayıt.Location = new System.Drawing.Point(102, 360);
            this.Kayıt.Name = "Kayıt";
            this.Kayıt.Size = new System.Drawing.Size(159, 48);
            this.Kayıt.TabIndex = 34;
            this.Kayıt.Text = "Güncelle";
            this.Kayıt.UseVisualStyleBackColor = true;
            this.Kayıt.Click += new System.EventHandler(this.Kayıt_Click);
            // 
            // Plaka
            // 
            this.Plaka.Location = new System.Drawing.Point(102, 24);
            this.Plaka.Name = "Plaka";
            this.Plaka.Size = new System.Drawing.Size(159, 22);
            this.Plaka.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Plaka";
            // 
            // KiraÜcreti
            // 
            this.KiraÜcreti.FormattingEnabled = true;
            this.KiraÜcreti.Location = new System.Drawing.Point(102, 282);
            this.KiraÜcreti.Name = "KiraÜcreti";
            this.KiraÜcreti.Size = new System.Drawing.Size(159, 24);
            this.KiraÜcreti.TabIndex = 31;
            // 
            // Yakıt
            // 
            this.Yakıt.FormattingEnabled = true;
            this.Yakıt.Items.AddRange(new object[] {
            "Benzin",
            "Dizel"});
            this.Yakıt.Location = new System.Drawing.Point(102, 238);
            this.Yakıt.Name = "Yakıt";
            this.Yakıt.Size = new System.Drawing.Size(159, 24);
            this.Yakıt.TabIndex = 30;
            // 
            // KM
            // 
            this.KM.FormattingEnabled = true;
            this.KM.Location = new System.Drawing.Point(102, 196);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(159, 24);
            this.KM.TabIndex = 29;
            // 
            // Renk
            // 
            this.Renk.FormattingEnabled = true;
            this.Renk.Location = new System.Drawing.Point(102, 154);
            this.Renk.Name = "Renk";
            this.Renk.Size = new System.Drawing.Size(159, 24);
            this.Renk.TabIndex = 28;
            // 
            // Model
            // 
            this.Model.FormattingEnabled = true;
            this.Model.Location = new System.Drawing.Point(102, 115);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(159, 24);
            this.Model.TabIndex = 27;
            // 
            // Seri
            // 
            this.Seri.FormattingEnabled = true;
            this.Seri.Location = new System.Drawing.Point(102, 85);
            this.Seri.Name = "Seri";
            this.Seri.Size = new System.Drawing.Size(159, 24);
            this.Seri.TabIndex = 26;
            // 
            // Marka
            // 
            this.Marka.FormattingEnabled = true;
            this.Marka.Items.AddRange(new object[] {
            "Toyota",
            "Volkswagen",
            "Opel",
            "Renault"});
            this.Marka.Location = new System.Drawing.Point(102, 52);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(159, 24);
            this.Marka.TabIndex = 25;
            this.Marka.SelectedIndexChanged += new System.EventHandler(this.Marka_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-6, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Kira Ücreti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yakıt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Model(Yıl)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Marka";
            // 
            // AraçListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 720);
            this.Controls.Add(this.Kayıt);
            this.Controls.Add(this.Plaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.KiraÜcreti);
            this.Controls.Add(this.Yakıt);
            this.Controls.Add(this.KM);
            this.Controls.Add(this.Renk);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Seri);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AraçListesi";
            this.Text = "AraçListesi";
            this.Load += new System.EventHandler(this.AraçListesi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Kayıt;
        private System.Windows.Forms.TextBox Plaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox KiraÜcreti;
        private System.Windows.Forms.ComboBox Yakıt;
        private System.Windows.Forms.ComboBox KM;
        private System.Windows.Forms.ComboBox Renk;
        private System.Windows.Forms.ComboBox Model;
        private System.Windows.Forms.ComboBox Seri;
        private System.Windows.Forms.ComboBox Marka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}