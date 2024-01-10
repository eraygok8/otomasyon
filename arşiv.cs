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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace otomasyon
{
    public partial class arşiv : Form
    {
        public arşiv()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERAY\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void arşiv_Load(object sender, EventArgs e)
        {
            kayıt_göster();
        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arşiv", baglanti);
            adtr.Fill(daset, "arşiv");
            dataGridView1.DataSource = daset.Tables["arşiv"];
            baglanti.Close();
        }
    }
}
