using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ürünlistele ekle = new ürünlistele();
            ekle.ShowDialog();
        }

        private void geributon_Click(object sender, EventArgs e)
        {
            adminform gecis = new adminform();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ürünekle ekle = new ürünekle();
            ekle.ShowDialog();
        }

        private void stok_Load(object sender, EventArgs e)
        {

        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button1.Text = resource1.s13;
            button2.Text = resource1.s14;
            geributon.Text = resource1.s15;
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }
    }
}
