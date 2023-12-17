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
    public partial class Kasa : UserControl
    {
        public Kasa()
        {
            InitializeComponent();
        }

    
        private void btnAna_Click(object sender, EventArgs e)
        {
            gecispanel.Height = btnAna.Height;
            gecispanel.Top = btnAna.Top;
            kasaanayemek1.BringToFront();
        }

        private void btnİçecek_Click(object sender, EventArgs e)
        {
            gecispanel.Height = btnİçecek.Height;
            gecispanel.Top = btnİçecek.Top;
            kasaiçecekler1.BringToFront();
        }

        private void btnTatlılar_Click(object sender, EventArgs e)
        {
            gecispanel.Height = btnTatlılar.Height;
            gecispanel.Top = btnTatlılar.Top;
            kasatatlı1.BringToFront();
        }

        private void btnÖdeme_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
            {
                DialogResult islem1;
                islem1 = MessageBox.Show("Ödeme Yöntemi " + radioButton1.Text + " olarak seçildi.\n\n" + "Ödenecek Tutar: " + textBox1.Text + " TL" +
                    "\n\nÖdemeyi onaylıyor musunuz?", "BİLGİ MESAJI", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(islem1 == DialogResult.Yes)
                {
                    MessageBox.Show("Ödeme Gerçekleştirildi!!\n\n " +
                        "ÖDENEN TUTAR: " +textBox1.Text + " TL","BİLGİLENDİRME MESAJI", MessageBoxButtons.OK,MessageBoxIcon.Warning );
                }
                else if(islem1 == DialogResult.No)
                {
                    MessageBox.Show("ÖDEME GERÇEKLEŞTİRİLEMEDİ !!!","HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (radioButton2.Checked)
            {
                DialogResult islem2;
                islem2 = MessageBox.Show("Ödeme Yöntemi " + radioButton2.Text + " olarak seçildi.\n\n" + "Ödenecek Tutar: " + textBox1.Text + " TL" +
                    "\n\nÖdemeyi onaylıyor musunuz?", "BİLGİ MESAJI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (islem2 == DialogResult.Yes)
                {
                    MessageBox.Show("Ödeme Gerçekleştirildi!!\n\n " +
                        "ÖDENEN TUTAR: " + textBox1.Text + " TL", "BİLGİLENDİRME MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (islem2 == DialogResult.No)
                {
                    MessageBox.Show("ÖDEME GERÇEKLEŞTİRİLEMEDİ !!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ödeme Yöntemi Seçmelisiniz !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";

            MessageBox.Show("ÖDEME İPTAL EDİLDİ","UYARI", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            gecispanel.Height = btnAna.Height;
            gecispanel.Top = btnAna.Top;
            kasaanayemek1.BringToFront();

        }
    }
}
