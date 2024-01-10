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
    public partial class ürünekle : Form
    {
        public ürünekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void eklebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ürün(ürünadı,ürünadeti,ürüntürü) values(@ürünadı,@ürünadeti,@ürüntürü)", baglanti);
            komut.Parameters.AddWithValue("@ürünadı", txtürünadı.Text);
            komut.Parameters.AddWithValue("@ürünadeti", txtürünadeti.Text);
            komut.Parameters.AddWithValue("@ürüntürü", cmbürüntürü.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni ürün eklendi.");
            txtürünadı.Clear();
            txtürünadeti.Clear();
            cmbürüntürü.Items.Clear();
            combo();
        }

        private void ürünekle_Load(object sender, EventArgs e)
        {
            combo();
        }
        private void combo()
        {
            SqlCommand komut = new SqlCommand("select * from ürüntürü", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbürüntürü.Items.Add(dr["ürüntürü"]);
            }
            baglanti.Close();
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            groupBox1.Text = resource1.s16;
            label1.Text = resource1.s17;
            label2.Text = resource1.s18;
            label3.Text = resource1.s54;
            eklebuton.Text = resource1.s19;
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }
    }
}
