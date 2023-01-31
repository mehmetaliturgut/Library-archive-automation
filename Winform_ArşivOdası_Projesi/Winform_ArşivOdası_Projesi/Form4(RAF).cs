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
    public partial class Form4_RAF_ : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = 302--0030; Initial Catalog = Web_302; User ID = WebMobile_302;Password=webmobile.302");
        public Form4_RAF_()
        {
            InitializeComponent();
        }

        public void Kayitgetirr()
        {
            string kayit = "SELECT * from RAF";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public void kayıtsil(int kayitt)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from RAF where R_ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", kayitt);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btn_RtoU_Click(object sender, EventArgs e)
        {
            Form2 form2_2sec = new Form2();
            form2_2sec.Show();
            this.Hide();
        }

        private void Form4_RAF__Load(object sender, EventArgs e)
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
            label4.Text = comboBox1.SelectedValue.ToString();
            SqlCommand komut2 = new SqlCommand("Select * from BOLUM where O_ID = " + label4.Text, baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "B_ID";
            comboBox2.DisplayMember = "B_AD";
            comboBox2.DataSource = dt2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox2.SelectedValue.ToString();
            
        }

        private void btn_göster_Click(object sender, EventArgs e)
        {
            Kayitgetirr();
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komuttt = new SqlCommand("Insert into RAF (O_ID,B_ID,R_AD) values (@1,@2,@3)", baglanti);

            komuttt.Parameters.AddWithValue("@1", label4.Text);
            komuttt.Parameters.AddWithValue("@2", label5.Text);
            komuttt.Parameters.AddWithValue("@3", textBox1.Text);

            komuttt.ExecuteNonQuery();
            baglanti.Close();
            Kayitgetirr();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int kayitt = Convert.ToInt32(drow.Cells[0].Value);
                kayıtsil(kayitt);
            }
            Kayitgetirr();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string kayit = "SELECT * from RAF";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "R_AD LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
