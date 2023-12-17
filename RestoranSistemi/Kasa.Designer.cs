namespace RestoranSistemi
{
    partial class Kasa
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasa));
            this.btnAna = new System.Windows.Forms.Button();
            this.btnİçecek = new System.Windows.Forms.Button();
            this.btnTatlılar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gecispanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnÖdeme = new System.Windows.Forms.Button();
            this.kasatatlı1 = new RestoranSistemi.kasatatlı();
            this.kasaiçecekler1 = new RestoranSistemi.kasaiçecekler();
            this.kasaanayemek1 = new RestoranSistemi.kasaanayemek();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAna
            // 
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.Location = new System.Drawing.Point(0, 22);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(246, 57);
            this.btnAna.TabIndex = 0;
            this.btnAna.Text = "ANA YEMEKLER";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnİçecek
            // 
            this.btnİçecek.FlatAppearance.BorderSize = 0;
            this.btnİçecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİçecek.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİçecek.Location = new System.Drawing.Point(0, 85);
            this.btnİçecek.Name = "btnİçecek";
            this.btnİçecek.Size = new System.Drawing.Size(246, 57);
            this.btnİçecek.TabIndex = 1;
            this.btnİçecek.Text = "İÇECEKLER";
            this.btnİçecek.UseVisualStyleBackColor = true;
            this.btnİçecek.Click += new System.EventHandler(this.btnİçecek_Click);
            // 
            // btnTatlılar
            // 
            this.btnTatlılar.FlatAppearance.BorderSize = 0;
            this.btnTatlılar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatlılar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTatlılar.Location = new System.Drawing.Point(0, 148);
            this.btnTatlılar.Name = "btnTatlılar";
            this.btnTatlılar.Size = new System.Drawing.Size(246, 57);
            this.btnTatlılar.TabIndex = 2;
            this.btnTatlılar.Text = "TATLILAR";
            this.btnTatlılar.UseVisualStyleBackColor = true;
            this.btnTatlılar.Click += new System.EventHandler(this.btnTatlılar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.gecispanel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnİptal);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnÖdeme);
            this.panel1.Controls.Add(this.btnİçecek);
            this.panel1.Controls.Add(this.btnAna);
            this.panel1.Controls.Add(this.btnTatlılar);
            this.panel1.Location = new System.Drawing.Point(670, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 652);
            this.panel1.TabIndex = 11;
            // 
            // gecispanel
            // 
            this.gecispanel.BackColor = System.Drawing.Color.DarkOrange;
            this.gecispanel.Location = new System.Drawing.Point(245, 22);
            this.gecispanel.Name = "gecispanel";
            this.gecispanel.Size = new System.Drawing.Size(17, 57);
            this.gecispanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ödenecek Tutar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(48, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 30);
            this.textBox1.TabIndex = 13;
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Firebrick;
            this.btnİptal.FlatAppearance.BorderSize = 0;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.Image")));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.Location = new System.Drawing.Point(48, 557);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(177, 57);
            this.btnİptal.TabIndex = 12;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(61, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 29);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kredi Kartı";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(61, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 29);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nakit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-4, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Yöntemi";
            // 
            // btnÖdeme
            // 
            this.btnÖdeme.BackColor = System.Drawing.Color.LightGreen;
            this.btnÖdeme.FlatAppearance.BorderSize = 0;
            this.btnÖdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÖdeme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖdeme.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdeme.Image")));
            this.btnÖdeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnÖdeme.Location = new System.Drawing.Point(48, 483);
            this.btnÖdeme.Name = "btnÖdeme";
            this.btnÖdeme.Size = new System.Drawing.Size(177, 57);
            this.btnÖdeme.TabIndex = 8;
            this.btnÖdeme.Text = "ÖDEME";
            this.btnÖdeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnÖdeme.UseVisualStyleBackColor = false;
            this.btnÖdeme.Click += new System.EventHandler(this.btnÖdeme_Click);
            // 
            // kasatatlı1
            // 
            this.kasatatlı1.Location = new System.Drawing.Point(0, 0);
            this.kasatatlı1.Name = "kasatatlı1";
            this.kasatatlı1.Size = new System.Drawing.Size(680, 629);
            this.kasatatlı1.TabIndex = 21;
            // 
            // kasaiçecekler1
            // 
            this.kasaiçecekler1.Location = new System.Drawing.Point(0, 0);
            this.kasaiçecekler1.Name = "kasaiçecekler1";
            this.kasaiçecekler1.Size = new System.Drawing.Size(680, 629);
            this.kasaiçecekler1.TabIndex = 20;
            // 
            // kasaanayemek1
            // 
            this.kasaanayemek1.Location = new System.Drawing.Point(0, 0);
            this.kasaanayemek1.Name = "kasaanayemek1";
            this.kasaanayemek1.Size = new System.Drawing.Size(680, 629);
            this.kasaanayemek1.TabIndex = 19;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kasatatlı1);
            this.Controls.Add(this.kasaiçecekler1);
            this.Controls.Add(this.kasaanayemek1);
            this.Controls.Add(this.panel1);
            this.Name = "Kasa";
            this.Size = new System.Drawing.Size(931, 629);
            this.Load += new System.EventHandler(this.Kasa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Button btnİçecek;
        private System.Windows.Forms.Button btnTatlılar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnÖdeme;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel gecispanel;
        private kasaanayemek kasaanayemek1;
        private kasaiçecekler kasaiçecekler1;
        private kasatatlı kasatatlı1;
    }
}
