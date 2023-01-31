using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Winform_ArşivOdası_Projesi
{
    public partial class Form5_e_Getir_ : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302; Password=webmobile.302");
        public Form5_e_Getir_()
        {
            InitializeComponent();
        }

        public void kayıtgetir()
        {
            string kayit = "SELECT * from EVRAK";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * from EVRAK";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "E_AD LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void Form5_e_Getir__Load(object sender, EventArgs e)
        {
            kayıtgetir(); 
        }
    }
}
