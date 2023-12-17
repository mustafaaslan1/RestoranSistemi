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
    public partial class Sipariş : UserControl
    {
        public Sipariş()
        {
            InitializeComponent();
        }

        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            gecispanel.Height = btnAnaYemek.Height;
            gecispanel.Top = btnAnaYemek.Top;
            anayemek1.BringToFront();
        }

        private void btnİçecek_Click(object sender, EventArgs e)
        {
            gecispanel.Height = btnİçecek.Height;
            gecispanel.Top = btnİçecek.Top;
            içecekler1.BringToFront();
        }

        private void btnTatlı_Click(object sender, EventArgs e)
        {
            gecispanel.Height = btnTatlı.Height;
            gecispanel.Top = btnTatlı.Top;
            tatlılar1.BringToFront();
        }

        private void Sipariş_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSipariş_Click(object sender, EventArgs e)
        {


        }
    }
}
