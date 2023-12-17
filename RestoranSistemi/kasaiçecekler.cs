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
    public partial class kasaiçecekler : UserControl
    {
        public kasaiçecekler()
        {
            InitializeComponent();
        }

        private void kasaiçecekler_Load(object sender, EventArgs e)
        {

            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Columns.Add("İÇECEK ADI", 202);
            listView2.Columns.Add("İÇECEK FİYATI", 202);

            listView2.Items.Add("Çay");
            listView2.Items[0].SubItems.Add("5 TL");

            listView2.Items.Add("Türk Kahvesi");
            listView2.Items[1].SubItems.Add("10 TL");

            listView2.Items.Add("Ayran");
            listView2.Items[2].SubItems.Add("5 TL");

            listView2.Items.Add("Su");
            listView2.Items[3].SubItems.Add("3 TL");

            listView2.Items.Add("Fanta");
            listView2.Items[4].SubItems.Add("20 TL");

            listView2.Items.Add("Pepsi");
            listView2.Items[5].SubItems.Add("20 TL");

            listView2.Items.Add("Şalgam");
            listView2.Items[6].SubItems.Add("15 TL");

            listView2.Items.Add("Sade Soda");
            listView2.Items[7].SubItems.Add("10 TL");

            listView2.Items.Add("Ice Tea");
            listView2.Items[8].SubItems.Add("20 TL");
        }
    }
}
