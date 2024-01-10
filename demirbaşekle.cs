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
using System.Reflection.Emit;
using System.Threading;
using System.Resources;

namespace otomasyon
{
    public partial class demirbaşekle : Form
    {
        public demirbaşekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void eklebuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into demirbaş(demirbaşadı,demirbaşadeti) values(@demirbaşadı,@demirbaşadeti)", baglanti);
            komut.Parameters.AddWithValue("@demirbaşadı", txtdemirbaşadı.Text);
            komut.Parameters.AddWithValue("@demirbaşadeti", txtdemirbaşadeti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni demirbaş eklendi.");
            txtdemirbaşadı.Clear();
            txtdemirbaşadeti.Clear();
        }

        private void demirbaşekle_Load(object sender, EventArgs e)
        {

        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            groupBox1.Text = resource1.s40;
            label1.Text = resource1.s41;
            label2.Text = resource1.s42;
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
