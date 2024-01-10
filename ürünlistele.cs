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
using System.Resources;

namespace otomasyon
{
    public partial class ürünlistele : Form
    {
        public ürünlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void ürünlistele_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from ürün", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
            }
            baglanti.Close();
            Kayıt_Göster();
            combo();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün", baglanti);
            adtr.Fill(daset, "ürün");
            dataGridView1.DataSource = daset.Tables["ürün"];
            baglanti.Close();
        }

        private void txtürünadıara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün where ürünadı like '%" + txtürünadıara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtürünadı.Text = dataGridView1.CurrentRow.Cells["ürünadı"].Value.ToString();
            txtürünadeti.Text = dataGridView1.CurrentRow.Cells["ürünadeti"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            cmbürüntürü.Text = dataGridView1.CurrentRow.Cells["ürüntürü"].Value.ToString();
        }

        private void güncellebuton_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ürün set ürünadı=@ürünadı,ürünadeti=@ürünadeti,ürüntürü=@ürüntürü where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@ürünadı", txtürünadı.Text);
            komut.Parameters.AddWithValue("@ürünadeti", txtürünadeti.Text);
            komut.Parameters.AddWithValue("@ürüntürü", cmbürüntürü.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["ürün"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Ürün kaydı güncellendi.");
            txtid.Clear();
            txtürünadı.Clear();
            txtürünadeti.Clear();
            cmbürüntürü.Text = "";
        }

        private void silbuton_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from ürün where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["ürün"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt silindi.");
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
            label3.Text = resource1.s17;
            label5.Text = resource1.s54;
            güncellebuton.Text = resource1.s31;
            silbuton.Text = resource1.s30;
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }
    }
}
