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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace otomasyon
{
    public partial class alınanişler : Form
    {
        public alınanişler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void geributon_Click(object sender, EventArgs e)
        {
            personelform gecis = new personelform();
            gecis.Show();
            this.Hide();
        }

        private void alınanişler_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
            combo();
            combo2();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müşteri2", baglanti);
            adtr.Fill(daset, "müşteri2");
            dataGridView1.DataSource = daset.Tables["müşteri2"];
            dataGridView1.Columns[0].Visible = true;
            baglanti.Close();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müşteri2 where tc like '%" + txttcara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into arşiv(tc,adsoyad,telefon,m2,temizliktürü,adres,temizlikçi,fiyat) values(@tc,@adsoyad,@telefon,@m2,@temizliktürü,@adres,@temizlikçi,@fiyat)", baglanti);
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@temizliktürü", cmbtemizliktürü.Text);
            komut2.Parameters.AddWithValue("@m2", txtm2.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@fiyat", txttoplamfiyat.Text);
            komut2.Parameters.AddWithValue("@temizlikçi", cmbtemizlikçi.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri2 where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri2"].Clear();
            Kayıt_Göster();
            MessageBox.Show("İş tamamlandı.");
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtm2.Text = dataGridView1.CurrentRow.Cells["m2"].Value.ToString();
            cmbtemizliktürü.Text = dataGridView1.CurrentRow.Cells["temizliktürü"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txttoplamfiyat.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
            cmbtemizlikçi.Text = dataGridView1.CurrentRow.Cells["temizlikçi"].Value.ToString();
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
            label8.Text = resource1.s28;
            label9.Text = resource1.s27;
            label6.Text = resource1.s29;
            label10.Text = resource1.s26;
            label11.Text = resource1.s37;
            button1.Text = resource1.s43;
            geributon.Text = resource1.s15;
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
