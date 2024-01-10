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
using System.Globalization;
using System.Threading;


namespace otomasyon
{
    public partial class müşterilisteleme : Form
    {
        public müşterilisteleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void müşterilisteleme_Load(object sender, EventArgs e)
        {
            combo();
            combo2();
            Kayıt_Göster();
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
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            dataGridView1.Columns["adres"].Width = 200;
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

        private void güncellebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,m2=@m2,temizliktürü=@temizliktürü,adres=@adres,fiyat=@fiyat,temizlikçi=@temizlikçi where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@m2", txtm2.Text);
            komut.Parameters.AddWithValue("@temizliktürü", cmbtemizliktürü.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@fiyat", txttoplamfiyat.Text);
            komut.Parameters.AddWithValue("@temizlikçi", cmbtemizlikçi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("İş kaydı güncellendi.");
            cmbtemizlikçi.Items.Clear();
            cmbtemizliktürü.Items.Clear();
            txttc.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtm2.Clear();
            txtAdres.Clear();
            txtbaşlangıçfiyat.Clear();
            txtm2fiyat.Clear();
            txttoplamfiyat.Clear();
            combo();
            combo2();
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt silindi.");
            cmbtemizliktürü.Items.Clear();
            txttc.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtm2.Clear();
            txtAdres.Clear();
            txtbaşlangıçfiyat.Clear();
            txtm2fiyat.Clear();
            txttoplamfiyat.Clear();
            cmbtemizlikçi.Items.Clear();
            combo();
            combo2();

        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo=new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müşteri where tc like '%"+txttcara.Text+"%'",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void cmbtemizliktürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aktarbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müşteri2 (tc,adsoyad,temizliktürü,telefon,m2,adres,fiyat,temizlikçi) values(@tc,@adsoyad,@temizliktürü,@telefon,@m2,@adres,@fiyat,@temizlikçi)", baglanti);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@temizliktürü", cmbtemizliktürü.Text);
            komut.Parameters.AddWithValue("@m2", txtm2.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@fiyat", txttoplamfiyat.Text);
            komut.Parameters.AddWithValue("@temizlikçi", cmbtemizlikçi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("İş kaydı aktarıldı.");
            cmbtemizlikçi.Items.Clear();
            txttc.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtm2.Clear();
            cmbtemizliktürü.Items.Clear();
            txtAdres.Clear();
            txtbaşlangıçfiyat.Clear();
            txtm2fiyat.Clear();
            txttoplamfiyat.Clear();
            combo();
            combo2();
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

        private void txtbaşlangıçfiyat_TextChanged(object sender, EventArgs e)
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
                combo();
                combo2();
            }
            if (cmbtemizlikçi.Text == "Ahmet Cemcir")
            {
                MessageBox.Show("Servis Şöförünü seçtiniz! Lütfen temizlik görevlisi seçiniz.");
                cmbtemizlikçi.Items.Clear();
                combo();
                combo2();
            }
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
            silbuton.Text = resource1.s30;
            güncellebuton.Text = resource1.s31;
            aktarbuton.Text = resource1.s32;
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
