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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection.Emit;
using System.Threading;
using System.Resources;

namespace otomasyon
{
    public partial class Geri_Bildirim : Form
    {
        public Geri_Bildirim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void lblgeribildirim_Click(object sender, EventArgs e)
        {

        }

        private void eklebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into geribildirim(adsoyad,feedback) values(@adsoyad,@feedback)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", cmbkimiçin.Text);
            komut.Parameters.AddWithValue("@feedback", txtgeribildirim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["geribildirim"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Geri bildirim eklendi.");
            txtgeribildirim.Clear();
            cmbkimiçin.Text = "";
            cmbkimiçin.Items.Clear();
            combo2();
        }

        private void Geri_Bildirim_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
            combo2();
        }
        private void combo2()
        {
            SqlCommand komut = new SqlCommand("select adsoyad from kullanici_bilgi", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbkimiçin.Items.Add(dr["adsoyad"]);
            }
            baglanti.Close();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from geribildirim", baglanti);
            adtr.Fill(daset, "geribildirim");
            dataGridView1.DataSource = daset.Tables["geribildirim"];
            dataGridView1.Columns["feedback"].Width = 300;
            baglanti.Close();
        }

        private void güncellebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update geribildirim set feedback=@feedback where adsoyad=@adsoyad", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", cmbkimiçin.Text);
            komut.Parameters.AddWithValue("@feedback", txtgeribildirim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["geribildirim"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Geri bildirim güncellendi.");
            txtgeribildirim.Clear();
            cmbkimiçin.Text = "";
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from geribildirim where feedback='" + dataGridView1.CurrentRow.Cells["feedback"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["geribildirim"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Geri bildirim silindi.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtgeribildirim.Text = dataGridView1.CurrentRow.Cells["feedback"].Value.ToString();
            cmbkimiçin.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminform gecis = new adminform();
            gecis.Show();
            this.Hide();
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = resource1.s50;
            lblgeribildirim.Text = resource1.s51;
            eklebuton.Text = resource1.s19;
            silbuton.Text = resource1.s30;
            güncellebuton.Text = resource1.s31;
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
