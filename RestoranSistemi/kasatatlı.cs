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
    public partial class kasatatlı : UserControl
    {
        public kasatatlı()
        {
            InitializeComponent();
        }

        private void kasatatlı_Load(object sender, EventArgs e)
        {
            listView3.View = View.Details;
            listView3.FullRowSelect = true;
            listView3.GridLines = true;
            listView3.Columns.Add("TATLI ADI", 202);
            listView3.Columns.Add("TATLI FİYATI", 202);

            listView3.Items.Add("İrmik Helvası");
            listView3.Items[0].SubItems.Add("15 TL");

            listView3.Items.Add("Künefe");
            listView3.Items[1].SubItems.Add("35 TL");

            listView3.Items.Add("Şekerpare");
            listView3.Items[2].SubItems.Add("10 TL");

            listView3.Items.Add("Sütlaç");
            listView3.Items[3].SubItems.Add("15 TL");

            listView3.Items.Add("Cheesecake");
            listView3.Items[4].SubItems.Add("45 TL");

            listView3.Items.Add("Tulumba Tatlısı");
            listView3.Items[5].SubItems.Add("10 TL");

            listView3.Items.Add("Soğuk Baklava");
            listView3.Items[6].SubItems.Add("35 TL");

            listView3.Items.Add("Fıstıklı Baklava");
            listView3.Items[7].SubItems.Add("30 TL");

            listView3.Items.Add("Profiterol");
            listView3.Items[8].SubItems.Add("25 TL");
        }
    
    }
}
