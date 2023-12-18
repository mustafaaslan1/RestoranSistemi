namespace RestoranSistemi
{
    partial class AnaGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiriş));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSosyal2 = new System.Windows.Forms.Button();
            this.btnSosyal3 = new System.Windows.Forms.Button();
            this.btnSosyal1 = new System.Windows.Forms.Button();
            this.btnAnaMenü = new System.Windows.Forms.Button();
            this.btnYardim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSipariş = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.btnRezerve = new System.Windows.Forms.Button();
            this.btnMenü = new System.Windows.Forms.Button();
            this.geçişpanel = new System.Windows.Forms.Panel();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZil = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saatlbl = new System.Windows.Forms.Label();
            this.anaMenü2 = new RestoranSistemi.AnaMenü();
            this.kasa2 = new RestoranSistemi.Kasa();
            this.rezervasyon2 = new RestoranSistemi.Rezervasyon();
            this.menü1 = new RestoranSistemi.Menü();
            this.personel1 = new RestoranSistemi.Personel();
            this.sipariş1 = new RestoranSistemi.Sipariş();
            this.yenimutfak1 = new RestoranSistemi.yenimutfak();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnSosyal2);
            this.panel1.Controls.Add(this.btnSosyal3);
            this.panel1.Controls.Add(this.btnSosyal1);
            this.panel1.Controls.Add(this.btnAnaMenü);
            this.panel1.Controls.Add(this.btnYardim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSipariş);
            this.panel1.Controls.Add(this.btnPersonel);
            this.panel1.Controls.Add(this.btnKasa);
            this.panel1.Controls.Add(this.btnMutfak);
            this.panel1.Controls.Add(this.btnRezerve);
            this.panel1.Controls.Add(this.btnMenü);
            this.panel1.Controls.Add(this.geçişpanel);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 672);
            this.panel1.TabIndex = 0;
            // 
            // btnSosyal2
            // 
            this.btnSosyal2.FlatAppearance.BorderSize = 0;
            this.btnSosyal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSosyal2.Image = ((System.Drawing.Image)(resources.GetObject("btnSosyal2.Image")));
            this.btnSosyal2.Location = new System.Drawing.Point(139, 620);
            this.btnSosyal2.Name = "btnSosyal2";
            this.btnSosyal2.Size = new System.Drawing.Size(50, 40);
            this.btnSosyal2.TabIndex = 11;
            this.btnSosyal2.UseVisualStyleBackColor = true;
            this.btnSosyal2.Click += new System.EventHandler(this.btnSosyal2_Click);
            // 
            // btnSosyal3
            // 
            this.btnSosyal3.FlatAppearance.BorderSize = 0;
            this.btnSosyal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSosyal3.Image = ((System.Drawing.Image)(resources.GetObject("btnSosyal3.Image")));
            this.btnSosyal3.Location = new System.Drawing.Point(194, 619);
            this.btnSosyal3.Name = "btnSosyal3";
            this.btnSosyal3.Size = new System.Drawing.Size(50, 40);
            this.btnSosyal3.TabIndex = 10;
            this.btnSosyal3.UseVisualStyleBackColor = true;
            this.btnSosyal3.Click += new System.EventHandler(this.btnSosyal3_Click);
            // 
            // btnSosyal1
            // 
            this.btnSosyal1.FlatAppearance.BorderSize = 0;
            this.btnSosyal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSosyal1.Image = ((System.Drawing.Image)(resources.GetObject("btnSosyal1.Image")));
            this.btnSosyal1.Location = new System.Drawing.Point(83, 619);
            this.btnSosyal1.Name = "btnSosyal1";
            this.btnSosyal1.Size = new System.Drawing.Size(50, 40);
            this.btnSosyal1.TabIndex = 0;
            this.btnSosyal1.UseVisualStyleBackColor = true;
            this.btnSosyal1.Click += new System.EventHandler(this.btnSosyal1_Click);
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.FlatAppearance.BorderSize = 0;
            this.btnAnaMenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaMenü.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenü.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenü.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaMenü.Image")));
            this.btnAnaMenü.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaMenü.Location = new System.Drawing.Point(14, 112);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(237, 51);
            this.btnAnaMenü.TabIndex = 9;
            this.btnAnaMenü.Text = "ANA MENÜ";
            this.btnAnaMenü.UseVisualStyleBackColor = true;
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.FlatAppearance.BorderSize = 0;
            this.btnYardim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYardim.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.Image")));
            this.btnYardim.Location = new System.Drawing.Point(3, 619);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(50, 41);
            this.btnYardim.TabIndex = 8;
            this.btnYardim.UseVisualStyleBackColor = true;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sistemi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Restoran";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSipariş
            // 
            this.btnSipariş.FlatAppearance.BorderSize = 0;
            this.btnSipariş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSipariş.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSipariş.ForeColor = System.Drawing.Color.White;
            this.btnSipariş.Image = ((System.Drawing.Image)(resources.GetObject("btnSipariş.Image")));
            this.btnSipariş.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSipariş.Location = new System.Drawing.Point(14, 542);
            this.btnSipariş.Name = "btnSipariş";
            this.btnSipariş.Size = new System.Drawing.Size(237, 51);
            this.btnSipariş.TabIndex = 5;
            this.btnSipariş.Text = "SİPARİŞ";
            this.btnSipariş.UseVisualStyleBackColor = true;
            this.btnSipariş.Click += new System.EventHandler(this.btnSipariş_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.FlatAppearance.BorderSize = 0;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.Color.White;
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.Location = new System.Drawing.Point(14, 474);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(237, 51);
            this.btnPersonel.TabIndex = 4;
            this.btnPersonel.Text = "PERSONEL";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.FlatAppearance.BorderSize = 0;
            this.btnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ForeColor = System.Drawing.Color.White;
            this.btnKasa.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.Image")));
            this.btnKasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKasa.Location = new System.Drawing.Point(14, 399);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(237, 51);
            this.btnKasa.TabIndex = 3;
            this.btnKasa.Text = "KASA";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnMutfak
            // 
            this.btnMutfak.FlatAppearance.BorderSize = 0;
            this.btnMutfak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMutfak.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMutfak.ForeColor = System.Drawing.Color.White;
            this.btnMutfak.Image = ((System.Drawing.Image)(resources.GetObject("btnMutfak.Image")));
            this.btnMutfak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMutfak.Location = new System.Drawing.Point(14, 327);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(237, 51);
            this.btnMutfak.TabIndex = 2;
            this.btnMutfak.Text = "MUTFAK";
            this.btnMutfak.UseVisualStyleBackColor = true;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // btnRezerve
            // 
            this.btnRezerve.FlatAppearance.BorderSize = 0;
            this.btnRezerve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerve.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezerve.ForeColor = System.Drawing.Color.White;
            this.btnRezerve.Image = ((System.Drawing.Image)(resources.GetObject("btnRezerve.Image")));
            this.btnRezerve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezerve.Location = new System.Drawing.Point(14, 257);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(237, 51);
            this.btnRezerve.TabIndex = 1;
            this.btnRezerve.Text = "REZERVASYON";
            this.btnRezerve.UseVisualStyleBackColor = true;
            this.btnRezerve.Click += new System.EventHandler(this.btnRezerve_Click);
            // 
            // btnMenü
            // 
            this.btnMenü.FlatAppearance.BorderSize = 0;
            this.btnMenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenü.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenü.ForeColor = System.Drawing.Color.White;
            this.btnMenü.Image = ((System.Drawing.Image)(resources.GetObject("btnMenü.Image")));
            this.btnMenü.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenü.Location = new System.Drawing.Point(14, 187);
            this.btnMenü.Name = "btnMenü";
            this.btnMenü.Size = new System.Drawing.Size(237, 51);
            this.btnMenü.TabIndex = 0;
            this.btnMenü.Text = "MENÜ";
            this.btnMenü.UseVisualStyleBackColor = true;
            this.btnMenü.Click += new System.EventHandler(this.btnMenü_Click);
            // 
            // geçişpanel
            // 
            this.geçişpanel.BackColor = System.Drawing.Color.LightGreen;
            this.geçişpanel.Location = new System.Drawing.Point(0, 112);
            this.geçişpanel.Name = "geçişpanel";
            this.geçişpanel.Size = new System.Drawing.Size(26, 51);
            this.geçişpanel.TabIndex = 2;
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.FlatAppearance.BorderSize = 0;
            this.btnÇıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇıkış.Image = ((System.Drawing.Image)(resources.GetObject("btnÇıkış.Image")));
            this.btnÇıkış.Location = new System.Drawing.Point(1132, -4);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(47, 44);
            this.btnÇıkış.TabIndex = 4;
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.btnZil);
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 40);
            this.panel2.TabIndex = 5;
            // 
            // btnZil
            // 
            this.btnZil.FlatAppearance.BorderSize = 0;
            this.btnZil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZil.Image = ((System.Drawing.Image)(resources.GetObject("btnZil.Image")));
            this.btnZil.Location = new System.Drawing.Point(756, 3);
            this.btnZil.Name = "btnZil";
            this.btnZil.Size = new System.Drawing.Size(42, 34);
            this.btnZil.TabIndex = 0;
            this.btnZil.UseVisualStyleBackColor = true;
            this.btnZil.Click += new System.EventHandler(this.btnZil_Click);
            // 
            // saatlbl
            // 
            this.saatlbl.AutoSize = true;
            this.saatlbl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.saatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatlbl.ForeColor = System.Drawing.Color.White;
            this.saatlbl.Location = new System.Drawing.Point(266, 9);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(0, 25);
            this.saatlbl.TabIndex = 0;
            // 
            // anaMenü2
            // 
            this.anaMenü2.BackColor = System.Drawing.Color.White;
            this.anaMenü2.Location = new System.Drawing.Point(248, 37);
            this.anaMenü2.Name = "anaMenü2";
            this.anaMenü2.Size = new System.Drawing.Size(931, 632);
            this.anaMenü2.TabIndex = 9;
            // 
            // kasa2
            // 
            this.kasa2.Location = new System.Drawing.Point(248, 37);
            this.kasa2.Name = "kasa2";
            this.kasa2.Size = new System.Drawing.Size(931, 682);
            this.kasa2.TabIndex = 8;
            // 
            // rezervasyon2
            // 
            this.rezervasyon2.Location = new System.Drawing.Point(248, 37);
            this.rezervasyon2.Name = "rezervasyon2";
            this.rezervasyon2.Size = new System.Drawing.Size(941, 719);
            this.rezervasyon2.TabIndex = 7;
            // 
            // menü1
            // 
            this.menü1.Location = new System.Drawing.Point(248, 37);
            this.menü1.Name = "menü1";
            this.menü1.Size = new System.Drawing.Size(931, 665);
            this.menü1.TabIndex = 6;
            // 
            // personel1
            // 
            this.personel1.Location = new System.Drawing.Point(248, 37);
            this.personel1.Name = "personel1";
            this.personel1.Size = new System.Drawing.Size(931, 643);
            this.personel1.TabIndex = 10;
            // 
            // sipariş1
            // 
            this.sipariş1.Location = new System.Drawing.Point(248, 40);
            this.sipariş1.Name = "sipariş1";
            this.sipariş1.Size = new System.Drawing.Size(931, 640);
            this.sipariş1.TabIndex = 11;
            // 
            // yenimutfak1
            // 
            this.yenimutfak1.Location = new System.Drawing.Point(248, 37);
            this.yenimutfak1.Name = "yenimutfak1";
            this.yenimutfak1.Size = new System.Drawing.Size(928, 635);
            this.yenimutfak1.TabIndex = 12;
            // 
            // AnaGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 669);
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.anaMenü2);
            this.Controls.Add(this.kasa2);
            this.Controls.Add(this.rezervasyon2);
            this.Controls.Add(this.menü1);
            this.Controls.Add(this.personel1);
            this.Controls.Add(this.sipariş1);
            this.Controls.Add(this.yenimutfak1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoran Sistemi";
            this.Load += new System.EventHandler(this.AnaGiriş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnRezerve;
        private System.Windows.Forms.Button btnMenü;
        private System.Windows.Forms.Button btnSipariş;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel geçişpanel;
        private Menü firstCustomControl1;
        private Rezervasyon rezervasyon1;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYardim;
        private Menü menü1;
        private Rezervasyon rezervasyon2;
        private Kasa kasa2;
        private AnaMenü anaMenü2;
        private System.Windows.Forms.Button btnAnaMenü;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Button btnSosyal2;
        private System.Windows.Forms.Button btnSosyal3;
        private System.Windows.Forms.Button btnSosyal1;
        private Personel personel1;
        private Sipariş sipariş1;
        private yenimutfak yenimutfak1;
        private System.Windows.Forms.Button btnZil;
    }
}

