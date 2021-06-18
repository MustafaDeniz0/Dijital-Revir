
namespace Dijital_Revir
{
    partial class ekran_IsKazasıEkleme
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_SevkEt = new System.Windows.Forms.Button();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_VardiyaAmiri = new System.Windows.Forms.ComboBox();
            this.tbx_kazaAnlatimi = new System.Windows.Forms.TextBox();
            this.tbx_saat = new System.Windows.Forms.TextBox();
            this.dtp_kazaZamani = new System.Windows.Forms.DateTimePicker();
            this.tbx_calismaSuresi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(258, 538);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_Ekle);
            this.panel2.Controls.Add(this.btn_SevkEt);
            this.panel2.Controls.Add(this.btn_aktar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 5;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.AutoEllipsis = true;
            this.btn_Ekle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.Location = new System.Drawing.Point(39, 327);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(177, 52);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_SevkEt
            // 
            this.btn_SevkEt.AutoEllipsis = true;
            this.btn_SevkEt.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SevkEt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SevkEt.Location = new System.Drawing.Point(39, 398);
            this.btn_SevkEt.Name = "btn_SevkEt";
            this.btn_SevkEt.Size = new System.Drawing.Size(177, 52);
            this.btn_SevkEt.TabIndex = 7;
            this.btn_SevkEt.Text = "Sevk Et";
            this.btn_SevkEt.UseVisualStyleBackColor = false;
            this.btn_SevkEt.Click += new System.EventHandler(this.btn_SevkEt_Click);
            // 
            // btn_aktar
            // 
            this.btn_aktar.AutoEllipsis = true;
            this.btn_aktar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_aktar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_aktar.Location = new System.Drawing.Point(39, 464);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(177, 52);
            this.btn_aktar.TabIndex = 6;
            this.btn_aktar.Text = "Excel\'e Aktar";
            this.btn_aktar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.cmb_VardiyaAmiri);
            this.panel3.Controls.Add(this.tbx_kazaAnlatimi);
            this.panel3.Controls.Add(this.tbx_saat);
            this.panel3.Controls.Add(this.dtp_kazaZamani);
            this.panel3.Controls.Add(this.tbx_calismaSuresi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 538);
            this.panel3.TabIndex = 7;
            // 
            // cmb_VardiyaAmiri
            // 
            this.cmb_VardiyaAmiri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_VardiyaAmiri.FormattingEnabled = true;
            this.cmb_VardiyaAmiri.Location = new System.Drawing.Point(266, 93);
            this.cmb_VardiyaAmiri.Name = "cmb_VardiyaAmiri";
            this.cmb_VardiyaAmiri.Size = new System.Drawing.Size(408, 24);
            this.cmb_VardiyaAmiri.TabIndex = 25;
            // 
            // tbx_kazaAnlatimi
            // 
            this.tbx_kazaAnlatimi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_kazaAnlatimi.Location = new System.Drawing.Point(266, 280);
            this.tbx_kazaAnlatimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_kazaAnlatimi.Multiline = true;
            this.tbx_kazaAnlatimi.Name = "tbx_kazaAnlatimi";
            this.tbx_kazaAnlatimi.Size = new System.Drawing.Size(408, 170);
            this.tbx_kazaAnlatimi.TabIndex = 24;
            // 
            // tbx_saat
            // 
            this.tbx_saat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_saat.Location = new System.Drawing.Point(516, 202);
            this.tbx_saat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_saat.MaxLength = 5;
            this.tbx_saat.Multiline = true;
            this.tbx_saat.Name = "tbx_saat";
            this.tbx_saat.Size = new System.Drawing.Size(59, 23);
            this.tbx_saat.TabIndex = 23;
            this.tbx_saat.Text = "00 : 00";
            // 
            // dtp_kazaZamani
            // 
            this.dtp_kazaZamani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_kazaZamani.CustomFormat = "";
            this.dtp_kazaZamani.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kazaZamani.Location = new System.Drawing.Point(266, 203);
            this.dtp_kazaZamani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_kazaZamani.Name = "dtp_kazaZamani";
            this.dtp_kazaZamani.Size = new System.Drawing.Size(195, 22);
            this.dtp_kazaZamani.TabIndex = 22;
            // 
            // tbx_calismaSuresi
            // 
            this.tbx_calismaSuresi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_calismaSuresi.Location = new System.Drawing.Point(266, 150);
            this.tbx_calismaSuresi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_calismaSuresi.Multiline = true;
            this.tbx_calismaSuresi.Name = "tbx_calismaSuresi";
            this.tbx_calismaSuresi.Size = new System.Drawing.Size(408, 28);
            this.tbx_calismaSuresi.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kazanın Anlatımı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(72, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kaza Zamanı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Çalışma Süresi";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vardiya Amiri";
            // 
            // ekran_IsKazasıEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ekran_IsKazasıEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Kazası Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_IsKazasıEkleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbx_kazaAnlatimi;
        private System.Windows.Forms.TextBox tbx_saat;
        private System.Windows.Forms.DateTimePicker dtp_kazaZamani;
        private System.Windows.Forms.TextBox tbx_calismaSuresi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SevkEt;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ComboBox cmb_VardiyaAmiri;
    }
}