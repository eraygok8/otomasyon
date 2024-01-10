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
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

namespace otomasyon
{
    public partial class talepedilenişler : Form
    {
        public talepedilenişler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void eklebuton_Click(object sender, EventArgs e)
        {
            müşteriekleme ekle = new müşteriekleme();
                ekle.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void talepedilenişler_Load(object sender, EventArgs e)
        {
            
        }

        private void Kayıt_Göster()
        {
            
        }

        private void talepedilenişler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listelebuton_Click(object sender, EventArgs e)
        {
            müşterilisteleme ekle = new müşterilisteleme();
            ekle.ShowDialog();
        }

        private void cmbtemizliktürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void geributon_Click(object sender, EventArgs e)
        {
            adminform gecis = new adminform();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            dil("");
        }
        public void dil(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            eklebuton.Text = resource1.s13;
            listelebuton.Text = resource1.s14;
            geributon.Text = resource1.s15;
        }
            

        private void btnen_Click(object sender, EventArgs e)
        {
            dil("en");
        }
    }
}
