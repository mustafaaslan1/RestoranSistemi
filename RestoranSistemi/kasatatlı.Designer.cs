namespace RestoranSistemi
{
    partial class kasatatlı
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
            this.listView3 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView3
            // 
            this.listView3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(680, 629);
            this.listView3.TabIndex = 9;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // kasatatlı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView3);
            this.Name = "kasatatlı";
            this.Size = new System.Drawing.Size(680, 629);
            this.Load += new System.EventHandler(this.kasatatlı_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView3;
    }
}
