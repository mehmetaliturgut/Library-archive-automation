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
    public partial class Form4_KLASOR_ : Form
    {
        public Form4_KLASOR_()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302; Password=webmobile.302");

        public void kayıtgetir()
        {
            string kayit = "SELECT * from KLASOR";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public void kayıtsil(int kayitt)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from KLASOR where K_ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", kayitt);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
        }

        private void Form4_KLASOR__Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from ODA", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember="O_ID";
            comboBox1.DisplayMember = "O_AD";
            comboBox1.DataSource = dt;
            


            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedValue.ToString();
            SqlCommand komut2 = new SqlCommand("Select * from BOLUM where O_ID = "+label3.Text, baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "B_ID";
            comboBox2.DisplayMember = "B_AD";
            comboBox2.DataSource = dt2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox2.SelectedValue.ToString();
            SqlCommand komut3 = new SqlCommand("Select * from RAF where B_ID = " +label6.Text, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox3.ValueMember = "R_ID";
            comboBox3.DisplayMember = "R_AD";
            comboBox3.DataSource = dt3;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox3.SelectedValue.ToString();
        }

        private void btn_vericek_Click(object sender, EventArgs e)
        {
            kayıtgetir();
        }

        private void btn_KAYİT_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutt = new SqlCommand("Insert into KLASOR (O_ID,B_ID,R_ID,K_AD) values (@1,@2,@3,@4)", baglanti);

            komutt.Parameters.AddWithValue("@1", label3.Text);
            komutt.Parameters.AddWithValue("@2", label6.Text);
            komutt.Parameters.AddWithValue("@3", label7.Text);
            komutt.Parameters.AddWithValue("@4", textBox1.Text);
            komutt.ExecuteNonQuery();
            baglanti.Close();
            kayıtgetir();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * from KLASOR";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "K_AD LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
