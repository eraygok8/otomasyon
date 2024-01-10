using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace otomasyon
{
    public partial class çalışanlar : Form
    {
        public çalışanlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            çalışanekle ekle = new çalışanekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            çalışanlistele ekle = new çalışanlistele();
            ekle.ShowDialog();
        }

        private void geributon_Click(object sender, EventArgs e)
        {
            adminform gecis = new adminform();
            gecis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizlikpersonelleri ekle = new temizlikpersonelleri();
            ekle.ShowDialog();
        }

        private void çalışanlar_Load(object sender, EventArgs e)
        {

        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            geributon.Text = resource1.s15;
            button1.Text = resource1.s13;
            button2.Text = resource1.s14;
            button3.Text = resource1.s44;
        }
    }
}
/* baglanti.Open();
            SqlCommand komut = new SqlCommand("Select count(adsoyad) from kullanici_bilgi",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblençokçalışan.Text = dr[0].ToString();
            }
            baglanti.Close(); */
