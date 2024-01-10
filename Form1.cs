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
using System.Threading;
using System.Globalization;


namespace otomasyon
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtkullanıcıadı.Text;
            string password = txtşifre.Text;
            string ktipi;


            con = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select kullanici_tipi from kullanici_bilgi where kullanici_adi='"+txtkullanıcıadı.Text+"' and sifre='"+txtşifre.Text+"'",con);
            com.Connection = con;
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                ktipi = dr[0].ToString();
                if (ktipi == "admin")
                {
                    MessageBox.Show("Hoşgeldiniz");
                    adminform gecis = new adminform();
                    gecis.Show();
                    this.Hide();
                }
                else if (ktipi == "personel")
                {
                    MessageBox.Show("Hoşgeldiniz");
                    personelform gecis = new personelform();
                    gecis.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
            con.Close();
        }

        

        private void txtşifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtşifre_Enter(object sender, EventArgs e)
        {

        }

        private void txtşifre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select 1", baglanti);
                int i = (Int32)cmd.ExecuteScalar();
            }
            catch 
            {
                MessageBox.Show("Veritabanı bağlantısında bir sorun var!");
            }
            finally { baglanti.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dil("en");
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            btngiriş.Text = resource1.s4;
            label1.Text = resource1.s1;
            label2.Text = resource1.s2;
            label3.Text = resource1.s3;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dil("");
        }
    }
}
