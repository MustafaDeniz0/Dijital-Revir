
namespace Dijital_Revir
{
    partial class ekran_MuayeneEkleme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SevkEt = new System.Windows.Forms.Button();
            this.btn_MuayeneEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbx_doktor = new System.Windows.Forms.TextBox();
            this.tbx_tedavi = new System.Windows.Forms.TextBox();
            this.tbx_tani = new System.Windows.Forms.TextBox();
            this.tbx_sikayet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Sikayet = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 510);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_SevkEt);
            this.panel2.Controls.Add(this.btn_MuayeneEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 510);
            this.panel2.TabIndex = 5;
            // 
            // btn_SevkEt
            // 
            this.btn_SevkEt.AutoEllipsis = true;
            this.btn_SevkEt.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SevkEt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SevkEt.Location = new System.Drawing.Point(17, 434);
            this.btn_SevkEt.Name = "btn_SevkEt";
            this.btn_SevkEt.Size = new System.Drawing.Size(220, 52);
            this.btn_SevkEt.TabIndex = 7;
            this.btn_SevkEt.Text = "HASTAYI SEVK ET";
            this.btn_SevkEt.UseVisualStyleBackColor = false;
            this.btn_SevkEt.Click += new System.EventHandler(this.btn_SevkEt_Click);
            // 
            // btn_MuayeneEkle
            // 
            this.btn_MuayeneEkle.AutoEllipsis = true;
            this.btn_MuayeneEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_MuayeneEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_MuayeneEkle.Location = new System.Drawing.Point(17, 351);
            this.btn_MuayeneEkle.Name = "btn_MuayeneEkle";
            this.btn_MuayeneEkle.Size = new System.Drawing.Size(220, 52);
            this.btn_MuayeneEkle.TabIndex = 6;
            this.btn_MuayeneEkle.Text = "MUAYENE BİLGİSİ EKLE";
            this.btn_MuayeneEkle.UseVisualStyleBackColor = false;
            this.btn_MuayeneEkle.Click += new System.EventHandler(this.btn_MuayeneEkleme_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.tbx_doktor);
            this.panel3.Controls.Add(this.tbx_tedavi);
            this.panel3.Controls.Add(this.tbx_tani);
            this.panel3.Controls.Add(this.tbx_sikayet);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbl_Sikayet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 510);
            this.panel3.TabIndex = 7;
            // 
            // tbx_doktor
            // 
            this.tbx_doktor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_doktor.Location = new System.Drawing.Point(49, 445);
            this.tbx_doktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_doktor.Multiline = true;
            this.tbx_doktor.Name = "tbx_doktor";
            this.tbx_doktor.Size = new System.Drawing.Size(650, 41);
            this.tbx_doktor.TabIndex = 22;
            // 
            // tbx_tedavi
            // 
            this.tbx_tedavi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tedavi.Location = new System.Drawing.Point(49, 313);
            this.tbx_tedavi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_tedavi.Multiline = true;
            this.tbx_tedavi.Name = "tbx_tedavi";
            this.tbx_tedavi.Size = new System.Drawing.Size(650, 81);
            this.tbx_tedavi.TabIndex = 21;
            // 
            // tbx_tani
            // 
            this.tbx_tani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tani.Location = new System.Drawing.Point(50, 183);
            this.tbx_tani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_tani.Multiline = true;
            this.tbx_tani.Name = "tbx_tani";
            this.tbx_tani.Size = new System.Drawing.Size(650, 81);
            this.tbx_tani.TabIndex = 20;
            // 
            // tbx_sikayet
            // 
            this.tbx_sikayet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_sikayet.Location = new System.Drawing.Point(50, 51);
            this.tbx_sikayet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_sikayet.Multiline = true;
            this.tbx_sikayet.Name = "tbx_sikayet";
            this.tbx_sikayet.Size = new System.Drawing.Size(650, 81);
            this.tbx_sikayet.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "SORUMLU DOKTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "UYGULANAN TEDAVİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "HASTALIK TANISI";
            // 
            // lbl_Sikayet
            // 
            this.lbl_Sikayet.AutoSize = true;
            this.lbl_Sikayet.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Sikayet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Sikayet.Location = new System.Drawing.Point(45, 21);
            this.lbl_Sikayet.Name = "lbl_Sikayet";
            this.lbl_Sikayet.Size = new System.Drawing.Size(159, 28);
            this.lbl_Sikayet.TabIndex = 15;
            this.lbl_Sikayet.Text = "HASTA ŞİKAYETİ";
            // 
            // ekran_MuayeneEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1262, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ekran_MuayeneEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_MuayeneEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbx_doktor;
        private System.Windows.Forms.TextBox tbx_tedavi;
        private System.Windows.Forms.TextBox tbx_tani;
        private System.Windows.Forms.TextBox tbx_sikayet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Sikayet;
        private System.Windows.Forms.Button btn_SevkEt;
    }
}