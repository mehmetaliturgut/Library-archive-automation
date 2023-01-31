using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_ArşivOdası_Projesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void TS_ODA_Click(object sender, EventArgs e)
        {
            Form4_ODA_ form4sec = new Form4_ODA_();
            form4sec.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form4_BOLUM_ form4_4sec = new Form4_BOLUM_();
            form4_4sec.Show();
            this.Hide();
        }

        private void TS_RAF_Click(object sender, EventArgs e)
        {
            Form4_RAF_ form4_5sec = new Form4_RAF_();
            form4_5sec.Show();
            this.Hide();
        }

        private void TS_KLASOR_Click(object sender, EventArgs e)
        {
            Form4_KLASOR_ form4_6sec = new Form4_KLASOR_();
            form4_6sec.Show();
            this.Hide();
        }

        private void TS_DOSYA_Click(object sender, EventArgs e)
        {
            Form4_DOSYA_ form4_7sec = new Form4_DOSYA_();
            form4_7sec.Show();
            this.Hide();
        }

        private void TS_E_kayit_Click(object sender, EventArgs e)
        {
            Form5_eKayit_ form5sec = new Form5_eKayit_();
            form5sec.Show();
            this.Hide();
        }

        private void TS_E_Getir_Click(object sender, EventArgs e)
        {
            Form5_e_Getir_ form5_5sec = new Form5_e_Getir_();
            form5_5sec.Show();
            this.Hide();
        }
    }
}
