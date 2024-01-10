using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace otomasyon
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            talepedilenişler gecis = new talepedilenişler();
            gecis.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stok gecis = new stok();
            gecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            çalışanlar gecis = new çalışanlar();
            gecis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            demirbaş gecis = new demirbaş();
            gecis.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gelirgider gecis = new gelirgider();    
            gecis.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Geri_Bildirim gecis = new Geri_Bildirim();
            gecis.Show();
            this.Hide();
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = resource1.s5;
            button1.Text = resource1.s6;
            button2.Text = resource1.s7;
            button3.Text = resource1.s8;
            button4.Text = resource1.s11;
            button5.Text = resource1.s9;
            button6.Text = resource1.s10;
            button7.Text = resource1.s12;
            button8.Text = resource1.s39;
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            arşiv gecis = new arşiv();
            gecis.ShowDialog();
        }
    }
}
