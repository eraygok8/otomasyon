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

namespace otomasyon
{
    public partial class temizlikpersonelleri : Form
    {
        public temizlikpersonelleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void temizlikpersonelleri_Load(object sender, EventArgs e)
        {
            kayıt_göster();
        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici_bilgi where meslek='Temizlikçi'",baglanti);
            adtr.Fill(daset, "kullanici_bilgi");
            dataGridView1.DataSource = daset.Tables["kullanici_bilgi"];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["kullanici_adi"].Visible = false;
            dataGridView1.Columns["sifre"].Visible = false;
            dataGridView1.Columns["kullanici_tipi"].Visible = false;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select TOP 1 adsoyad from kullanici_bilgi order by alınaniş DESC", baglanti);
            baglanti.Open();
            SqlDataReader adtr = komut.ExecuteReader();
            if (adtr.Read())
            {
                string enfazlaişyapankişi = adtr["adsoyad"].ToString();
                label1.Text = "En Fazla İş Yapan Kişi : " + enfazlaişyapankişi;
            }
            else
            {
                label1.Text = "Kullanıcı bilgisi bulunamadı.";
            }
        }
    }
}
