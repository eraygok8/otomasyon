using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace otomasyon
{
    public partial class giderekle : Form
    {
        public giderekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void giderekle_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gider", baglanti);
            adtr.Fill(daset, "gider");
            dataGridView1.DataSource = daset.Tables["gider"];
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into gider(malzemeler,servis) values(@malzemeler,@servis)", baglanti);
            komut.Parameters.AddWithValue("@malzemeler", txtmalzemeler.Text);
            komut.Parameters.AddWithValue("@servis", txtservis.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Gider eklendi.");
            txtmalzemeler.Clear();
            txtservis.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gelirgider gecis = new gelirgider();
            gecis.Show();
            this.Hide();
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = resource1.s52;
            label2.Text = resource1.s53;
            btnekle.Text = resource1.s19;
            button7.Text = resource1.s15;
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
