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
using System.Text.RegularExpressions;
using System.Threading;
using System.Resources;
using System.Security.Cryptography.X509Certificates;

namespace otomasyon
{
    public partial class çalışanekle : Form
    {
        public çalışanekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void eklebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kullanici_bilgi(adsoyad,kullanici_adi,sifre,kullanici_tipi,maaş,meslek,alınaniş) values(@adsoyad,@kullanici_adi,@sifre,@kullanici_tipi,@maaş,@meslek,@alınaniş)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@meslek", cmbmeslek.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", txtkullanıcıadı.Text);
            komut.Parameters.AddWithValue("@sifre", txtşifre.Text);
            komut.Parameters.AddWithValue("@kullanici_tipi", cmbktipi.Text);
            komut.Parameters.AddWithValue("@maaş", txtmaaş.Text);
            komut.Parameters.AddWithValue("@alınaniş", txtalınaniş.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni çalışan eklendi.");
            txtadsoyad.Clear();
            txtkullanıcıadı.Clear();
            txtşifre.Clear();
            cmbktipi.Items.Clear();
            txtmaaş.Clear();
            cmbmeslek.Items.Clear();
            txtalınaniş.Clear();
            combo();
            combo2();
        }
        private void combo()
        {
            SqlCommand komut = new SqlCommand("select * from meslektürü", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbmeslek.Items.Add(dr["meslek"]);
            }
            baglanti.Close();
        }
        private void combo2()
        {
            SqlCommand komut = new SqlCommand("select * from kullanici_tipi", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbktipi.Items.Add(dr["kullanici_tipi"]);
            }
            baglanti.Close();
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = resource1.s2;
            label2.Text = resource1.s3;
            label3.Text = resource1.s33;
            label5.Text = resource1.s34;
            label4.Text = resource1.s35;
            groupBox1.Text = resource1.s11;
            eklebuton.Text = resource1.s19;
            label7.Text = resource1.s36;
            label6.Text = resource1.s21;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void çalışanekle_Load(object sender, EventArgs e)
        {            
            combo();
            combo2();
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }

        private void cmbmeslek_TextChanged(object sender, EventArgs e)
        {
            if (cmbmeslek.Text == "Müdür")
            {
                txtmaaş.Text = "85.010 TL";
            }
            if (cmbmeslek.Text == "Servis Şöförü")
            {
                txtmaaş.Text = "19.006 TL";
            }
            if (cmbmeslek.Text == "Temizlikçi")
            {
                txtmaaş.Text = "17.002 TL";
                txtalınaniş.Text = "0";
            }
        }
    }
}
