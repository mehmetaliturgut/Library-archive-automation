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
    public partial class Form4_ODA_ : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302;Password=webmobile.302");
        public Form4_ODA_()
        {
            InitializeComponent();
        }

        public void kayıtsil(int kayitt)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from ODA where O_ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", kayitt);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
        }

        public void kayıtgetir()
        {
            string kayit = "SELECT * from ODA";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Insert into ODA (O_AD) values (@1)",baglanti);

            komut.Parameters.AddWithValue("@1", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayıtgetir();
        }

        private void btn_göster_Click(object sender, EventArgs e)
        {
            kayıtgetir();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int kayitt = Convert.ToInt32(drow.Cells[0].Value);
                kayıtsil(kayitt);
            }
            kayıtgetir();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * from ODA";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "O_AD LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
