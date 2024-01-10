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
    public partial class personelform : Form
    {
        public personelform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alınanişler gecis = new alınanişler();
            gecis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            demirbaşpersonel gecis = new demirbaşpersonel();
            gecis.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stokpersonel gecis = new stokpersonel();
            gecis.Show();
            this.Hide();
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label2.Text = resource1.s48;
            button1.Text = resource1.s49;
            button3.Text = resource1.s7;
            button6.Text = resource1.s10;
            button2.Text = resource1.s12;
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
