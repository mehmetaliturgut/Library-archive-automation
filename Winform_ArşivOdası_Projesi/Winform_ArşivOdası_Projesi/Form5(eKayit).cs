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
    public partial class Form5_eKayit_ : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302; Password=webmobile.302");

        public Form5_eKayit_()
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

        public void kayıtsil(int kayitt)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from EVRAK where E_ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", kayitt);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void Form5_eKayit__Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from ODA", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "O_ID";
            comboBox1.DisplayMember = "O_AD";
            comboBox1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int kayitt = Convert.ToInt32(drow.Cells[0].Value);
                kayıtsil(kayitt);
            }
            kayıtgetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox1.SelectedValue.ToString();
            SqlCommand komut2 = new SqlCommand("Select * from BOLUM where O_ID = " + label7.Text, baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "B_ID";
            comboBox2.DisplayMember = "B_AD";
            comboBox2.DataSource = dt2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox2.SelectedValue.ToString();
            SqlCommand komut3 = new SqlCommand("Select * from RAF where B_ID = " + label8.Text, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox3.ValueMember = "R_ID";
            comboBox3.DisplayMember = "R_AD";
            comboBox3.DataSource = dt3;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = comboBox3.SelectedValue.ToString();
            SqlCommand komut3 = new SqlCommand("Select * from KLASOR where R_ID = " + label9.Text, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox4.ValueMember = "K_ID";
            comboBox4.DisplayMember = "K_AD";
            comboBox4.DataSource = dt3;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox3.SelectedValue.ToString();
            SqlCommand komut3 = new SqlCommand("Select * from DOSYA where K_ID = " + label10.Text, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox5.ValueMember = "D_ID";
            comboBox5.DisplayMember = "D_AD";
            comboBox5.DataSource = dt3;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = comboBox5.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıtgetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutttt = new SqlCommand("Insert into EVRAK (O_ID,B_ID,R_ID,K_ID,D_ID,E_AD) values (@1,@2,@3,@4,@5,@6)", baglanti);

            komutttt.Parameters.AddWithValue("@1", label7.Text);
            komutttt.Parameters.AddWithValue("@2", label8.Text);
            komutttt.Parameters.AddWithValue("@3", label9.Text);
            komutttt.Parameters.AddWithValue("@4", label10.Text);
            komutttt.Parameters.AddWithValue("@5", label11.Text);
            komutttt.Parameters.AddWithValue("@6", textBox1.Text);


            komutttt.ExecuteNonQuery();
            baglanti.Close();
            kayıtgetir();
        }
    }
}
