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
    public partial class Personel : UserControl
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string adsoyad, cinsiyet, tarih, telefon, adres,referans, görevi;
                adsoyad = textBox1.Text;
                cinsiyet = radioButton1.Text;
                tarih = maskedTextBox1.Text;
                telefon = maskedTextBox2.Text;
                adres = textBox2.Text;
                referans = textBox3.Text;
                görevi = comboBox1.Text;
                string[] personel = { adsoyad,cinsiyet, tarih, telefon,adres, referans, görevi};

                ListViewItem sonuç = new ListViewItem(personel);

                listView1.Items.Add(sonuç);

                MessageBox.Show("KAYIT İŞLEMİ GERÇEKLEŞTİRİLDİ!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                string adsoyad, cinsiyet, tarih, telefon, adres, referans, görevi;
                adsoyad = textBox1.Text;
                cinsiyet = radioButton2.Text;
                tarih = maskedTextBox1.Text;
                telefon = maskedTextBox2.Text;
                adres = textBox2.Text;
                referans = textBox3.Text;
                görevi = comboBox1.Text;
                string[] personel = { adsoyad, cinsiyet, tarih, telefon, adres, referans, görevi };

                ListViewItem sonuç = new ListViewItem(personel);

                listView1.Items.Add(sonuç);

                MessageBox.Show("KAYIT İŞLEMİ GERÇEKLEŞTİRİLDİ!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boşluk Bırakmamalısınız!","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("AD SOYAD", 120);
            listView1.Columns.Add("CİNSİYET", 120);
            listView1.Columns.Add("GELİŞ TARİHİ", 120);
            listView1.Columns.Add("TELEFON", 145);
            listView1.Columns.Add("ADRES",120);
            listView1.Columns.Add("REFERANS",120);
            listView1.Columns.Add("GÖREVİ",120);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Şef");
            comboBox1.Items.Add("Sous Şef");
            comboBox1.Items.Add("Aşçı Yardımcısı");
            comboBox1.Items.Add("Garson");
            comboBox1.Items.Add("Bulaşık Görevlisi");
            comboBox1.Items.Add("Temizlik Görevlisi");
            comboBox1.Items.Add("Genel Müdür");
        }

        private void btnGörüntüle_Click(object sender, EventArgs e)
        {
            groupBoxkayıt.Visible = false;
            listView1.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            groupBoxkayıt.Visible = true;
            listView1.Visible = false;
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
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            comboBox1.SelectedIndex = -1;
        }
    }
}
