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
    public partial class Rezervasyon : UserControl
    {
        public Rezervasyon()
        {
            InitializeComponent();

            textBox1.KeyPress += TextBox_KeyPress;
        }
       
        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            rezervasyonGroupBox.Visible = true;
            görüntüGroupBox.Visible = false;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Visible = false;
            listView1.Columns.Add("AD SOYAD", 130);
            listView1.Columns.Add("SAAT", 120);
            listView1.Columns.Add("TARİH", 120);
            listView1.Columns.Add("TELEFON", 140);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string adsoyad, tarih, saat, telefon;
            adsoyad = textBox1.Text;
            tarih = maskedTextBox1.Text;
            saat = maskedTextBox2.Text;
            telefon = maskedTextBox3.Text;
            string[] rezervasyon = { adsoyad, tarih, saat,telefon };

            ListViewItem sonuç = new ListViewItem(rezervasyon);

            listView1.Items.Add(sonuç);

            MessageBox.Show("KAYIT İŞLEMİ GERÇEKLEŞTİRİLDİ!","BİLGİLENDİRME",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGörüntüle_Click(object sender, EventArgs e)
        {
            rezervasyonGroupBox.Visible = false;
            görüntüGroupBox.Visible= true;
            listView1.Visible = true;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            görüntüGroupBox.Visible = false;
            listView1.Visible = false;
            rezervasyonGroupBox.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult seçim;

                seçim = MessageBox.Show("Listeden bir seçim yapmalısınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }
    }
}
