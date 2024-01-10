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

namespace otomasyon
{
    public partial class gelirgider : Form
    {
        public gelirgider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        int gelir, topla;
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void gelirgider_Load(object sender, EventArgs e)
        {
            gider();
            hesapla();
            toplam();
            int fark = gelir - topla;
            lblkar.Text = fark.ToString();
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select fiyat from arşiv", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["Gelir"].Points.AddY(dr[0].ToString());
                }
                baglanti.Close();
            }
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select malzemeler,servis from gider", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    chart2.Series["Malzemeler"].Points.AddXY(dr[0].ToString(), dr[0]);
                    chart2.Series["Servis"].Points.AddY(dr[1]);
                }
                baglanti.Close();
            }
            
        }
        private void gider()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select malzemeler,servis from gider",baglanti);
            adtr.Fill(daset, "gider");
            dataGridView1.DataSource = daset.Tables["gider"];
            baglanti.Close();
        }
        private void hesapla()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(fiyat) from arşiv", baglanti);
            lblgelir.Text = komut.ExecuteScalar()+ "TL";
            gelir = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
        }

        private void btngider_Click(object sender, EventArgs e)
        {
            giderekle gecis = new giderekle();
            gecis.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminform gecis = new adminform();
            gecis.Show();
            this.Hide();
        }

        private void toplam()
        {
            ;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i) 
            {
                topla += Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                topla += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            lblgider.Text = Convert.ToString(topla + "TL");
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            lblgelir.Text = resource1.s45;
            lblgider.Text = resource1.s46;
            label1.Text = resource1.s47;
            button7.Text = resource1.s15;
        }
    }
}
