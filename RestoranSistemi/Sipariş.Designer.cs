namespace RestoranSistemi
{
    partial class Sipariş
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gecispanel = new System.Windows.Forms.Panel();
            this.btnTatlı = new System.Windows.Forms.Button();
            this.btnİçecek = new System.Windows.Forms.Button();
            this.btnAnaYemek = new System.Windows.Forms.Button();
            this.anayemek1 = new RestoranSistemi.anayemek();
            this.içecekler1 = new RestoranSistemi.içecekler();
            this.tatlılar1 = new RestoranSistemi.tatlılar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.gecispanel);
            this.panel1.Controls.Add(this.btnTatlı);
            this.panel1.Controls.Add(this.btnİçecek);
            this.panel1.Controls.Add(this.btnAnaYemek);
            this.panel1.Location = new System.Drawing.Point(723, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 646);
            this.panel1.TabIndex = 0;
            // 
            // gecispanel
            // 
            this.gecispanel.BackColor = System.Drawing.Color.IndianRed;
            this.gecispanel.Location = new System.Drawing.Point(188, 170);
            this.gecispanel.Name = "gecispanel";
            this.gecispanel.Size = new System.Drawing.Size(19, 72);
            this.gecispanel.TabIndex = 13;
            // 
            // btnTatlı
            // 
            this.btnTatlı.FlatAppearance.BorderSize = 0;
            this.btnTatlı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatlı.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTatlı.Location = new System.Drawing.Point(-2, 384);
            this.btnTatlı.Name = "btnTatlı";
            this.btnTatlı.Size = new System.Drawing.Size(206, 72);
            this.btnTatlı.TabIndex = 12;
            this.btnTatlı.Text = "TATLILAR";
            this.btnTatlı.UseVisualStyleBackColor = true;
            this.btnTatlı.Click += new System.EventHandler(this.btnTatlı_Click);
            // 
            // btnİçecek
            // 
            this.btnİçecek.FlatAppearance.BorderSize = 0;
            this.btnİçecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİçecek.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİçecek.Location = new System.Drawing.Point(0, 274);
            this.btnİçecek.Name = "btnİçecek";
            this.btnİçecek.Size = new System.Drawing.Size(197, 73);
            this.btnİçecek.TabIndex = 11;
            this.btnİçecek.Text = "İÇECEKLER";
            this.btnİçecek.UseVisualStyleBackColor = true;
            this.btnİçecek.Click += new System.EventHandler(this.btnİçecek_Click);
            // 
            // btnAnaYemek
            // 
            this.btnAnaYemek.FlatAppearance.BorderSize = 0;
            this.btnAnaYemek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaYemek.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaYemek.Location = new System.Drawing.Point(0, 170);
            this.btnAnaYemek.Name = "btnAnaYemek";
            this.btnAnaYemek.Size = new System.Drawing.Size(204, 72);
            this.btnAnaYemek.TabIndex = 10;
            this.btnAnaYemek.Text = "ANA YEMEKLER";
            this.btnAnaYemek.UseVisualStyleBackColor = true;
            this.btnAnaYemek.Click += new System.EventHandler(this.btnAnaYemek_Click);
            // 
            // anayemek1
            // 
            this.anayemek1.Location = new System.Drawing.Point(0, -3);
            this.anayemek1.Name = "anayemek1";
            this.anayemek1.Size = new System.Drawing.Size(730, 629);
            this.anayemek1.TabIndex = 38;
            // 
            // içecekler1
            // 
            this.içecekler1.Location = new System.Drawing.Point(0, -3);
            this.içecekler1.Name = "içecekler1";
            this.içecekler1.Size = new System.Drawing.Size(730, 629);
            this.içecekler1.TabIndex = 36;
            // 
            // tatlılar1
            // 
            this.tatlılar1.Location = new System.Drawing.Point(0, 1);
            this.tatlılar1.Name = "tatlılar1";
            this.tatlılar1.Size = new System.Drawing.Size(731, 629);
            this.tatlılar1.TabIndex = 37;
            // 
            // Sipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anayemek1);
            this.Controls.Add(this.içecekler1);
            this.Controls.Add(this.tatlılar1);
            this.Controls.Add(this.panel1);
            this.Name = "Sipariş";
            this.Size = new System.Drawing.Size(931, 629);
            this.Load += new System.EventHandler(this.Sipariş_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private tatlılar tatlılar1;
        private System.Windows.Forms.Panel gecispanel;
        private System.Windows.Forms.Button btnTatlı;
        private System.Windows.Forms.Button btnİçecek;
        private System.Windows.Forms.Button btnAnaYemek;
        private içecekler içecekler1;
        private anayemek anayemek1;
    }
}
