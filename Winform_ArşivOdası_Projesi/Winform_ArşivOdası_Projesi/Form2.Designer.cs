namespace Winform_ArşivOdası_Projesi
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ODA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_RAF = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_KLASOR = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_DOSYA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_E_kayit = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_E_Getir = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(398, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_ODA,
            this.toolStripMenuItem4,
            this.TS_RAF,
            this.TS_KLASOR,
            this.TS_DOSYA});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem1.Text = "Ana Veriler";
            // 
            // TS_ODA
            // 
            this.TS_ODA.Name = "TS_ODA";
            this.TS_ODA.Size = new System.Drawing.Size(180, 22);
            this.TS_ODA.Text = "Oda Tanımları";
            this.TS_ODA.Click += new System.EventHandler(this.TS_ODA_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Bölüm Tanımları";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // TS_RAF
            // 
            this.TS_RAF.Name = "TS_RAF";
            this.TS_RAF.Size = new System.Drawing.Size(180, 22);
            this.TS_RAF.Text = "Raf Tanımları";
            this.TS_RAF.Click += new System.EventHandler(this.TS_RAF_Click);
            // 
            // TS_KLASOR
            // 
            this.TS_KLASOR.Name = "TS_KLASOR";
            this.TS_KLASOR.Size = new System.Drawing.Size(180, 22);
            this.TS_KLASOR.Text = "Klasör Tanımları";
            this.TS_KLASOR.Click += new System.EventHandler(this.TS_KLASOR_Click);
            // 
            // TS_DOSYA
            // 
            this.TS_DOSYA.Name = "TS_DOSYA";
            this.TS_DOSYA.Size = new System.Drawing.Size(180, 22);
            this.TS_DOSYA.Text = "Dosya Tanımları";
            this.TS_DOSYA.Click += new System.EventHandler(this.TS_DOSYA_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_E_kayit,
            this.TS_E_Getir,
            this.evrakGönderToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem2.Text = "Evrak İşlemleri";
            // 
            // TS_E_kayit
            // 
            this.TS_E_kayit.Name = "TS_E_kayit";
            this.TS_E_kayit.Size = new System.Drawing.Size(180, 22);
            this.TS_E_kayit.Text = "Evrak Kayıt";
            this.TS_E_kayit.Click += new System.EventHandler(this.TS_E_kayit_Click);
            // 
            // TS_E_Getir
            // 
            this.TS_E_Getir.Name = "TS_E_Getir";
            this.TS_E_Getir.Size = new System.Drawing.Size(180, 22);
            this.TS_E_Getir.Text = "Evrak Getir";
            this.TS_E_Getir.Click += new System.EventHandler(this.TS_E_Getir_Click);
            // 
            // evrakGönderToolStripMenuItem
            // 
            this.evrakGönderToolStripMenuItem.Name = "evrakGönderToolStripMenuItem";
            this.evrakGönderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.evrakGönderToolStripMenuItem.Text = "Evrak Gönder";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(535, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TS_ODA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem TS_RAF;
        private System.Windows.Forms.ToolStripMenuItem TS_KLASOR;
        private System.Windows.Forms.ToolStripMenuItem TS_DOSYA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TS_E_kayit;
        private System.Windows.Forms.ToolStripMenuItem TS_E_Getir;
        private System.Windows.Forms.ToolStripMenuItem evrakGönderToolStripMenuItem;
    }
}