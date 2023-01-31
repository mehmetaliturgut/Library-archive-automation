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
    public partial class Form4_DOSYA_ : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302; Password=webmobile.302");
        public Form4_DOSYA_()
        {
            InitializeComponent();
        }
        public void kayıtgetir()
        {
            string kayit = "SELECT * from DOSYA";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public void kayıtsil(int kayitt)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from DOSYA where D_ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", kayitt);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void Form4_DOSYA__Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from ODA", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "O_ID";
            comboBox1.DisplayMember = "O_AD";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox1.SelectedValue.ToString();
            SqlCommand komut2 = new SqlCommand("Select * from BOLUM where O_ID = " + label6.Text, baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "B_ID";
            comboBox2.DisplayMember = "B_AD";
            comboBox2.DataSource = dt2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox2.SelectedValue.ToString();
            SqlCommand komut3 = new SqlCommand("Select * from RAF where B_ID = " + label7.Text, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox3.ValueMember = "R_ID";
            comboBox3.DisplayMember = "R_AD";
            comboBox3.DataSource = dt3;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox3.SelectedValue.ToString();
            SqlCommand komut3 = new SqlCommand("Select * from KLASOR where R_ID = " + label8.Text, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox4.ValueMember = "K_ID";
            comboBox4.DisplayMember = "K_AD";
            comboBox4.DataSource = dt3;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = comboBox4.SelectedValue.ToString();
        }

        private void btn_Göster_Click(object sender, EventArgs e)
        {
            kayıtgetir();
        }

        private void btn_Kayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutttt = new SqlCommand("Insert into DOSYA (O_ID,B_ID,R_ID,K_ID,D_AD) values (@1,@2,@3,@4,@5)", baglanti);

            komutttt.Parameters.AddWithValue("@1", label6.Text);
            komutttt.Parameters.AddWithValue("@2", label7.Text);
            komutttt.Parameters.AddWithValue("@3", label8.Text);
            komutttt.Parameters.AddWithValue("@4", label9.Text);
            komutttt.Parameters.AddWithValue("@5", textBox1.Text);

            komutttt.ExecuteNonQuery();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * from DOSYA";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "D_AD LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
