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
    public partial class demirbaşlistele : Form
    {
        public demirbaşlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void demirbaşlistele_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from demirbaş", baglanti);
            SqlDataReader dr;
            Kayıt_Göster();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from demirbaş", baglanti);
            adtr.Fill(daset, "demirbaş");
            dataGridView1.DataSource = daset.Tables["demirbaş"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txtdemirbaşadı.Text = dataGridView1.CurrentRow.Cells["demirbaşadı"].Value.ToString();
            txtdemirbaşadeti.Text = dataGridView1.CurrentRow.Cells["demirbaşadeti"].Value.ToString();
        }

        private void güncellebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update demirbaş set demirbaşadı=@demirbaşadı,demirbaşadeti=@demirbaşadeti where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@demirbaşadı", txtdemirbaşadı.Text);
            komut.Parameters.AddWithValue("@demirbaşadeti", txtdemirbaşadeti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["demirbaş"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Demirbaş kaydı güncellendi.");
            txtid.Clear();
            txtdemirbaşadı.Clear();
            txtdemirbaşadeti.Clear();
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from demirbaş where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["demirbaş"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt silindi.");
        }

        private void txtdemirbaşadıara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from demirbaş where demirbaşadı like '%" + txtdemirbaşadıara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            groupBox1.Text = resource1.s40;
            label1.Text = resource1.s41;
            label2.Text = resource1.s42;
            label7.Text = resource1.s41;
            güncellebuton.Text = resource1.s31;
            silbuton.Text = resource1.s30;
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
