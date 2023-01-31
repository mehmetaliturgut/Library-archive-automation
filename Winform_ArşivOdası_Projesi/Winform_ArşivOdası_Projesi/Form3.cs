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
    public partial class Form3 : Form
    {
        static string conString = "Data Source=302--0030;Initial Catalog=Web_302;User ID=WebMobile_302;Password=webmobile.302";
        SqlConnection baglanti = new SqlConnection(conString);
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    if (textBox2.Text==textBox3.Text)
                    {
                        baglanti.Open();

                        string kayit = "Insert into ID_PW (Kullanici_ID, Kullanici_PW) values (@1, @2)";

                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@1", textBox1.Text);
                        komut.Parameters.AddWithValue("@2", textBox2.Text);

                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Başarıyla gerçekleşti, Lütfen tekrar giriş yapınız");

                        Form1 form1sec = new Form1();
                        form1sec.Show();
                        this.Hide();
                    }
                    


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu. "+ex.Message);
            }


        }
    }
}
