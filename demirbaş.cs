using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class demirbaş : Form
    {
        public demirbaş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void geributon_Click(object sender, EventArgs e)
        {
            adminform gecis = new adminform();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            demirbaşekle ekle = new demirbaşekle();
            ekle.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            demirbaşlistele ekle = new demirbaşlistele();
            ekle.ShowDialog();
        }

        private void demirbaş_Load(object sender, EventArgs e)
        {

        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            geributon.Text = resource1.s15;
            button1.Text = resource1.s13;
            button2.Text = resource1.s14;
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }
    }
}
