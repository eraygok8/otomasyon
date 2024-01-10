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
    public partial class çalışanlistele : Form
    {
        public çalışanlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void çalışanlistele_Load(object sender, EventArgs e)
        {
            combo2();
            combo();
            Kayıt_Göster();
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
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici_bilgi", baglanti);
            adtr.Fill(daset, "kullanici_bilgi");
            dataGridView1.DataSource = daset.Tables["kullanici_bilgi"];
            dataGridView1.Columns["kullanici_adi"].Visible = false;
            dataGridView1.Columns["alınaniş"].Visible = false;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtkullanıcıadı.Text = dataGridView1.CurrentRow.Cells["kullanici_adi"].Value.ToString();
            txtşifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            cmbktipi.Text = dataGridView1.CurrentRow.Cells["kullanici_tipi"].Value.ToString();
            txtmaaş.Text = dataGridView1.CurrentRow.Cells["maaş"].Value.ToString();
            cmbmeslek.Text = dataGridView1.CurrentRow.Cells["meslek"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }

        private void güncellebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set adsoyad=@adsoyad,kullanici_adi=@kullanici_adi,sifre=@sifre,kullanici_tipi=@kullanici_tipi,maaş=@maaş, meslek=@meslek where id=@id ", baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", txtkullanıcıadı.Text);
            komut.Parameters.AddWithValue("@sifre", txtşifre.Text);
            komut.Parameters.AddWithValue("@kullanici_tipi", cmbktipi.Text);
            komut.Parameters.AddWithValue("@maaş", txtmaaş.Text);
            komut.Parameters.AddWithValue("@meslek", cmbmeslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanici_bilgi"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Çalışan bilgileri güncellendi.");
            txtid.Clear();
            txtadsoyad.Clear();
            cmbmeslek.Items.Clear();
            txtkullanıcıadı.Clear();
            txtşifre.Clear();
            cmbktipi.Items.Clear();
            txtmaaş.Clear();
            combo();
            combo2();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici_bilgi where adsoyad like '%" + txtadsoyad.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kullanici_bilgi where adsoyad='" + dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanici_bilgi"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Çalışan kaydı silindi.");
            combo();
            combo2();
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
            }
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
            label7.Text = resource1.s21;
            label6.Text = resource1.s21;
            silbuton.Text = resource1.s30;
            güncellebuton.Text = resource1.s31;
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
