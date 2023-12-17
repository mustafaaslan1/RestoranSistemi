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
    public partial class yenimutfak : UserControl
    {
        public yenimutfak()
        {
            InitializeComponent();
        }

        private void yenimutfak_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Kilogram");
            comboBox1.Items.Add("Litre");
            comboBox1.Items.Add("Adet");

            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ÜRÜN ADI", 120);
            listView1.Columns.Add("TOPLAM", 100);
            listView1.Columns.Add("CİNSİ", 70);
            listView1.Columns.Add("KULLANILAN",110);
            listView1.Columns.Add("KALAN", 110);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ürünadedi = textBox2.Text;
            string ürünadı = textBox1.Text;
            string ürüncinsi = comboBox1.Text;
            string harcananürün = textBox3.Text;

            if (string.IsNullOrEmpty(ürünadı) || string.IsNullOrEmpty(ürünadedi) 
                || string.IsNullOrEmpty(ürüncinsi) || string.IsNullOrEmpty(harcananürün))
            {
                MessageBox.Show("KUTULAR BOŞ OLMAMALIDIR!");
            }
            else
            {
                try
                {
                    ListViewItem item = new ListViewItem(ürünadı);
                    item.SubItems.Add(ürünadedi);
                    item.SubItems.Add(ürüncinsi);
                    int toplamStok = int.Parse(ürünadedi);
                    int kullanilanStok = int.Parse(textBox3.Text);
                    int kalanStok = toplamStok - kullanilanStok;

                    item.SubItems.Add(kullanilanStok.ToString());
                    item.SubItems.Add(kalanStok.ToString());
                    listView1.Items.Add(item);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                catch (FormatException)
                {

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("LİSTEDEN SEÇİM YAPMALISINIZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem selecteditem = listView1.SelectedItems[0];

                    // Seçili ürün bilgilerini textBox ve comboBox'lara yerleştir
                    textBox1.Text = selecteditem.SubItems[0].Text; // Ürün Adı
                    textBox2.Text = selecteditem.SubItems[1].Text; // Toplam Stok
                    comboBox1.Text = selecteditem.SubItems[2].Text; // Ürün Cinsi

                    // Güncelle butonu tıklanınca listView'daki eski veriyi sil
                    listView1.Items.Remove(selecteditem);
                }
                catch (FormatException)
                {
                    MessageBox.Show("STOKLARI SAYI CİNSİNDEN GİRİN!");
                }
            }
            else
            {
                MessageBox.Show("LİSTEDEN SEÇİM YAPMALISINIZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
