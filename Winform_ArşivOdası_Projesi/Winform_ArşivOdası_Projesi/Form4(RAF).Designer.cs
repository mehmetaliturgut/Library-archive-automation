namespace Winform_ArşivOdası_Projesi
{
    partial class Form4_RAF_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_RtoU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bOLUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.web_302DataSet_rafkayıt = new Winform_ArşivOdası_Projesi.Web_302DataSet_rafkayıt();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oDABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oDATableAdapter = new Winform_ArşivOdası_Projesi.Web_302DataSet_rafkayıtTableAdapters.ODATableAdapter();
            this.bOLUMTableAdapter = new Winform_ArşivOdası_Projesi.Web_302DataSet_rafkayıtTableAdapters.BOLUMTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_göster = new System.Windows.Forms.Button();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOLUMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_302DataSet_rafkayıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RtoU
            // 
            this.btn_RtoU.BackColor = System.Drawing.Color.Orange;
            this.btn_RtoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RtoU.ForeColor = System.Drawing.Color.Brown;
            this.btn_RtoU.Location = new System.Drawing.Point(611, 46);
            this.btn_RtoU.Name = "btn_RtoU";
            this.btn_RtoU.Size = new System.Drawing.Size(142, 39);
            this.btn_RtoU.TabIndex = 0;
            this.btn_RtoU.Text = "Geri gel";
            this.btn_RtoU.UseVisualStyleBackColor = false;
            this.btn_RtoU.Click += new System.EventHandler(this.btn_RtoU_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.btn_kayıt);
            this.groupBox1.Controls.Add(this.btn_göster);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(64, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raf Kaydet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raf Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm seçiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oda seçiniz:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.bOLUMBindingSource;
            this.comboBox2.DisplayMember = "B_AD";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bOLUMBindingSource
            // 
            this.bOLUMBindingSource.DataMember = "BOLUM";
            this.bOLUMBindingSource.DataSource = this.web_302DataSet_rafkayıt;
            // 
            // web_302DataSet_rafkayıt
            // 
            this.web_302DataSet_rafkayıt.DataSetName = "Web_302DataSet_rafkayıt";
            this.web_302DataSet_rafkayıt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oDABindingSource, "O_ID", true));
            this.comboBox1.DataSource = this.oDABindingSource1;
            this.comboBox1.DisplayMember = "O_AD";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "O_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // oDABindingSource
            // 
            this.oDABindingSource.DataMember = "ODA";
            this.oDABindingSource.DataSource = this.web_302DataSet_rafkayıt;
            // 
            // oDABindingSource1
            // 
            this.oDABindingSource1.DataMember = "ODA";
            this.oDABindingSource1.DataSource = this.web_302DataSet_rafkayıt;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // oDATableAdapter
            // 
            this.oDATableAdapter.ClearBeforeFill = true;
            // 
            // bOLUMTableAdapter
            // 
            this.bOLUMTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "...";
            // 
            // btn_göster
            // 
            this.btn_göster.BackColor = System.Drawing.Color.Thistle;
            this.btn_göster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_göster.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_göster.Location = new System.Drawing.Point(16, 162);
            this.btn_göster.Name = "btn_göster";
            this.btn_göster.Size = new System.Drawing.Size(100, 49);
            this.btn_göster.TabIndex = 8;
            this.btn_göster.Text = "Verileri Göster";
            this.btn_göster.UseVisualStyleBackColor = false;
            this.btn_göster.Click += new System.EventHandler(this.btn_göster_Click);
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.BackColor = System.Drawing.Color.Thistle;
            this.btn_kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayıt.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_kayıt.Location = new System.Drawing.Point(122, 162);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(88, 49);
            this.btn_kayıt.TabIndex = 9;
            this.btn_kayıt.Text = "Kayıt";
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Thistle;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Sil.Location = new System.Drawing.Point(216, 162);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(84, 49);
            this.btn_Sil.TabIndex = 10;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form4_RAF_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RtoU);
            this.Name = "Form4_RAF_";
            this.Text = "Form4_RAF_";
            this.Load += new System.EventHandler(this.Form4_RAF__Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOLUMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_302DataSet_rafkayıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RtoU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Web_302DataSet_rafkayıt web_302DataSet_rafkayıt;
        private System.Windows.Forms.BindingSource oDABindingSource;
        private Web_302DataSet_rafkayıtTableAdapters.ODATableAdapter oDATableAdapter;
        private System.Windows.Forms.BindingSource bOLUMBindingSource;
        private Web_302DataSet_rafkayıtTableAdapters.BOLUMTableAdapter bOLUMTableAdapter;
        private System.Windows.Forms.BindingSource oDABindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.Button btn_göster;
        private System.Windows.Forms.TextBox textBox2;
    }
}