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
    public partial class Form4_BOLUM_ : Form
    {
        public Form4_BOLUM_()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302;Password=webmobile.302");

        public void Kayitgetir()
        {
            string kayit = "SELECT * from BOLUM";

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

        private void Form4_BOLUM__Load(object sender, EventArgs e)
        {
            
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM ODA";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["O_ID"]);
                
            }
            
            baglanti.Close();

            


        }

        private void btn_göster_Click(object sender, EventArgs e)
        {
            Kayitgetir();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Insert into BOLUM (B_AD,O_ID) values (@1,@2)", baglanti);


            komut.Parameters.AddWithValue("@1", textBox1.Text);
            komut.Parameters.AddWithValue("@2", comboBox1.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayitgetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //label3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * from BOLUM";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "B_AD LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
