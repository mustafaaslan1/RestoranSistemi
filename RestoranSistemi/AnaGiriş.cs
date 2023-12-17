using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSistemi
{
    public partial class AnaGiriş : Form
    {
        public AnaGiriş()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            geçişpanel.Height = btnAnaMenü.Height;
            geçişpanel.Top = btnAnaMenü.Top;
            anaMenü2.BringToFront();
        }
        
        private void btnMenü_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnMenü.Height;
            geçişpanel.Top = btnMenü.Top;
            menü1.BringToFront();
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnRezerve.Height;
            geçişpanel.Top = btnRezerve.Top;
            rezervasyon2.BringToFront();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnMutfak.Height;
            geçişpanel.Top = btnMutfak.Top;
            yenimutfak1.BringToFront();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnKasa.Height;
            geçişpanel.Top = btnKasa.Top;
            kasa2.BringToFront();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnPersonel.Height;
            geçişpanel.Top = btnPersonel.Top;
            personel1.BringToFront();
        }

        private void btnSipariş_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnSipariş.Height;
            geçişpanel.Top = btnSipariş.Top;
            sipariş1.BringToFront();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            DialogResult çıkış;

            çıkış = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize eminmisiniz?","UYARI",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if(çıkış == DialogResult.OK) 
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Uygulamadan çıkış yapılamadı!", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnAnaMenü_Click(object sender, EventArgs e)
        {
            geçişpanel.Height = btnAnaMenü.Height;
            geçişpanel.Top = btnAnaMenü.Top;
            anaMenü2.BringToFront();
        }

        private void AnaGiriş_Load(object sender, EventArgs e)
        {
          
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;

            saatlbl.Text = tarih.ToString();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UYGULAMAYI NASIL KULLANABİLECEĞİNİZ AŞAĞIDA YAZMAKTADIR. \n\n" +
                " 1- Menüler arasında rahatlıkla geçiş yapabilirsiniz.\n\n" +
                " 2- Menü kısmında 'ÜRÜN' fiyatlarını görmek istiyorsanız sağ tarafta bulunan seçeneklere tıklayabilirsiniz.\n\n" +
                " 3- Kasa ve Ödeme kısmı sorunsuz bir şekilde çalışmaktadır.\n\n" +
                " 4- Ödeme yöntemini seçmeyi unutmayın!\n\n" +
                " 5- Fiyatları bakıp ödenecek tutarın toplamını girmeniz gerekmektedir!"
                ,"YARDIM", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSosyal1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void btnSosyal2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");

        }

        private void btnSosyal3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instaagram.com");
        }

        private void btnZil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" GELEN 2 SİPARİŞ MEVCUT.","BİLDİRİM",MessageBoxButtons.OK,MessageBoxIcon.Information);             
        }
    }
}
