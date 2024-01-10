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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using otomasyon.projeDataSetTableAdapters;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace otomasyon
{
    public partial class müşteriekleme : Form
    {
        class Temizlikci
        {
            public string Adi { get; set; }
            public int IsSayisi { get; set; }            
        }
        public müşteriekleme()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void eklebuton_Click(object sender, EventArgs e)
        {
            for(int i=3;i<dataGridView2.Rows.Count-1;i++)               
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,temizliktürü,telefon,m2,adres,fiyat,temizlikçi) values(@tc,@adsoyad,@temizliktürü,@telefon,@m2,@adres,@fiyat,@temizlikçi)", baglanti);
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@temizliktürü", cmbtemizliktürü.Text);
                komut.Parameters.AddWithValue("@m2", txtm2.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@fiyat", txttoplamfiyat.Text);
                komut.Parameters.AddWithValue("@temizlikçi", cmbtemizlikçi.Text);
                komut.ExecuteNonQuery();
                arttıralınaniş(cmbtemizlikçi.Text);
                azaltstok(txtmalzeme.Text);
                SqlCommand komut2 = new SqlCommand("select ürünadeti from ürün where id='" + dataGridView2.Rows[i].Cells["id"].Value.ToString() +"'", baglanti);
                int ürünadeti = (Int32) komut2.ExecuteScalar();
                if(ürünadeti<10)
                {
                    MessageBox.Show("İş kaydı eklendi. Ürünleriniz azalıyor!");
                }
                else
                {
                    MessageBox.Show("İş kaydı eklendi.");
                }
                baglanti.Close();
            }           
            txtmalzeme.Clear();
            txttc.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtm2.Clear();
            cmbtemizliktürü.Items.Clear();
            txtAdres.Clear();
            txtbaşlangıçfiyat.Clear();
            txtm2fiyat.Clear();
            txttoplamfiyat.Clear();
            cmbtemizlikçi.Items.Clear();
            combo();
            combo2();
        }
        static void azaltstok(string ürün)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=Eray\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut = new SqlCommand("update ürün set ürünadeti = ürünadeti-1", baglanti);
            komut.Parameters.AddWithValue("@ürünadeti", ürün);
            baglanti.Open();
            komut.ExecuteNonQuery();
        } 
        
        static void arttıralınaniş(string temizlikçi)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set alınaniş = alınaniş+1 where adsoyad=@temizlikçi", baglanti);
            komut.Parameters.AddWithValue("@temizlikçi", temizlikçi);
            baglanti.Open();
            komut.ExecuteNonQuery();

        }

        private void müşteriekleme_Load(object sender, EventArgs e)
        {
            combo();
            combo2();
            kayıt_göster();
            kayıt_göster2();
        }
        private void combo2()
        {
            SqlCommand komut = new SqlCommand("select adsoyad from kullanici_bilgi", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbtemizlikçi.Items.Add(dr["adsoyad"]);
            }
            baglanti.Close();
        }
        private void combo()
        {
            SqlCommand komut = new SqlCommand("select * from temizlik", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbtemizliktürü.Items.Add(dr["temizliktürü"]);
            }
            baglanti.Close();
        }

        private void cmbtemizliktürü_TextChanged(object sender, EventArgs e)
        {
            if (cmbtemizliktürü.Text == "Genel")
            {
                txtbaşlangıçfiyat.Text = "100";
            }
            if (cmbtemizliktürü.Text == "Detaylı")
            {
                txtbaşlangıçfiyat.Text = "150";
            }
            if (cmbtemizliktürü.Text == "Toz Alma")
            {
                txtbaşlangıçfiyat.Text = "50";
            }
        }

        private void txtfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtbaşlangıçfiyat.Text) + double.Parse(txtm2fiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void txttoplamfiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtm2fiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtbaşlangıçfiyat.Text) + double.Parse(txtm2fiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void txtm2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtm2fiyat.Text = (double.Parse(txtm2.Text) * double.Parse("10")).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void cmbtemizlikçi_TextChanged(object sender, EventArgs e)
        {
            if (cmbtemizlikçi.Text == "Duran Eray Gök")
            {
                MessageBox.Show("Müdürü seçtiniz! Lütfen temizlik görevlisi seçiniz.");
                cmbtemizlikçi.Items.Clear();
                combo2();
            }
            if (cmbtemizlikçi.Text == "Ahmet Cemcir")
            {
                MessageBox.Show("Servis Şöförünü seçtiniz! Lütfen temizlik görevlisi seçiniz.");
                cmbtemizlikçi.Items.Clear();
                combo2();
            }
            if (cmbtemizlikçi.Text == "Necla Sönmez")
            {
                txtmalzeme.Text = "Seçili";
                
            }
            if (cmbtemizlikçi.Text == "Ömer Toprak")
            {
                txtmalzeme.Text = "Seçili";
                
            }
            if(cmbtemizlikçi.Text =="")
            {
                txtmalzeme.Text = "";
                
            }
        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici_bilgi where meslek='Temizlikçi'", baglanti);
            adtr.Fill(daset, "kullanici_bilgi");
            dataGridView1.DataSource = daset.Tables["kullanici_bilgi"];
            baglanti.Close();
        }
        private void kayıt_göster2()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün", baglanti);
            adtr.Fill(daset, "ürün");
            dataGridView2.DataSource = daset.Tables["ürün"];
            baglanti.Close();
        }

        private void txtmalzeme_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            groupBox1.Text = resource1.s20;
            label2.Text = resource1.s21;
            label3.Text = resource1.s22;
            groupBox2.Text = resource1.s23;
            label4.Text = resource1.s24;
            label5.Text = resource1.s25;
            label7.Text = resource1.s26;
            label8.Text = resource1.s27;
            label9.Text = resource1.s28;
            label6.Text = resource1.s29;
            label10.Text = resource1.s37;
            label11.Text = resource1.s38;
            eklebuton.Text = resource1.s19;
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
