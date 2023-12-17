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
    public partial class kasaanayemek : UserControl
    {
        public kasaanayemek()
        {
            InitializeComponent();
        }

        private void kasaanayemek_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("YEMEK ADI", 202);
            listView1.Columns.Add("YEMEK FİYATI", 202);

            listView1.Items.Add("Köri Soslu Tavuk");
            listView1.Items[0].SubItems.Add("80 TL");

            listView1.Items.Add("İskender Kebap");
            listView1.Items[1].SubItems.Add("130 TL");

            listView1.Items.Add("Köfte");
            listView1.Items[2].SubItems.Add("75 TL");

            listView1.Items.Add("Tavuk Kanat");
            listView1.Items[3].SubItems.Add("110 TL");

            listView1.Items.Add("Karışık Izgara");
            listView1.Items[4].SubItems.Add("320 TL");

            listView1.Items.Add("Pilav Üstü Döner");
            listView1.Items[5].SubItems.Add("115 TL");

            listView1.Items.Add("Karnıyarık");
            listView1.Items[6].SubItems.Add("60 TL");

            listView1.Items.Add("Lahmacun");
            listView1.Items[7].SubItems.Add("40 TL");

            listView1.Items.Add("Yeşil Fasulye");
            listView1.Items[8].SubItems.Add("50 TL");
        }
    }
}
