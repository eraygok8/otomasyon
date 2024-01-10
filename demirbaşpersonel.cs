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

namespace otomasyon
{
    public partial class demirbaşpersonel : Form
    {
        public demirbaşpersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void demirbaşpersonel_Load(object sender, EventArgs e)
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

        private void txtdemirbaşadıara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from demirbaş where demirbaşadı like '%" + txtdemirbaşadıara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void geributon_Click(object sender, EventArgs e)
        {
            personelform gecis = new personelform();
            gecis.Show();
            this.Hide();
        }
    }
}
