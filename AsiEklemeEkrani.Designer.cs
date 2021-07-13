
namespace Dijital_Revir
{
    partial class ekran_AsiEkleme
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_asiEkle = new System.Windows.Forms.Button();
            this.dgv_asi = new System.Windows.Forms.DataGridView();
            this.lbl_KullanimPeriyodu = new System.Windows.Forms.Label();
            this.lbl_AsiAdi = new System.Windows.Forms.Label();
            this.tbx_kullanimPeriyodu = new System.Windows.Forms.TextBox();
            this.tbx_asiAdi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbx_uygulamaTarihi = new System.Windows.Forms.TextBox();
            this.lbl_UygulamaTarihi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asi)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 599);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 599);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_asiEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1112, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 599);
            this.panel2.TabIndex = 7;
            // 
            // btn_asiEkle
            // 
            this.btn_asiEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_asiEkle.BackColor = System.Drawing.Color.White;
            this.btn_asiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_asiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asiEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_asiEkle.Location = new System.Drawing.Point(15, 257);
            this.btn_asiEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_asiEkle.Name = "btn_asiEkle";
            this.btn_asiEkle.Size = new System.Drawing.Size(232, 46);
            this.btn_asiEkle.TabIndex = 23;
            this.btn_asiEkle.Text = "AŞI KAYDI EKLE";
            this.btn_asiEkle.UseVisualStyleBackColor = false;
            this.btn_asiEkle.Click += new System.EventHandler(this.btn_asiEkle_Click);
            // 
            // dgv_asi
            // 
            this.dgv_asi.AllowUserToAddRows = false;
            this.dgv_asi.AllowUserToDeleteRows = false;
            this.dgv_asi.AllowUserToResizeColumns = false;
            this.dgv_asi.AllowUserToResizeRows = false;
            this.dgv_asi.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_asi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_asi.Location = new System.Drawing.Point(259, 303);
            this.dgv_asi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_asi.Name = "dgv_asi";
            this.dgv_asi.RowHeadersWidth = 51;
            this.dgv_asi.RowTemplate.Height = 25;
            this.dgv_asi.Size = new System.Drawing.Size(853, 296);
            this.dgv_asi.TabIndex = 24;
            // 
            // lbl_KullanimPeriyodu
            // 
            this.lbl_KullanimPeriyodu.AutoSize = true;
            this.lbl_KullanimPeriyodu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_KullanimPeriyodu.Location = new System.Drawing.Point(74, 91);
            this.lbl_KullanimPeriyodu.Name = "lbl_KullanimPeriyodu";
            this.lbl_KullanimPeriyodu.Size = new System.Drawing.Size(229, 28);
            this.lbl_KullanimPeriyodu.TabIndex = 20;
            this.lbl_KullanimPeriyodu.Text = "KULLANIM PERİYODU :";
            // 
            // lbl_AsiAdi
            // 
            this.lbl_AsiAdi.AutoSize = true;
            this.lbl_AsiAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_AsiAdi.Location = new System.Drawing.Point(74, 41);
            this.lbl_AsiAdi.Name = "lbl_AsiAdi";
            this.lbl_AsiAdi.Size = new System.Drawing.Size(95, 28);
            this.lbl_AsiAdi.TabIndex = 19;
            this.lbl_AsiAdi.Text = "AŞI ADI :";
            // 
            // tbx_kullanimPeriyodu
            // 
            this.tbx_kullanimPeriyodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_kullanimPeriyodu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbx_kullanimPeriyodu.Location = new System.Drawing.Point(367, 91);
            this.tbx_kullanimPeriyodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_kullanimPeriyodu.Name = "tbx_kullanimPeriyodu";
            this.tbx_kullanimPeriyodu.Size = new System.Drawing.Size(361, 34);
            this.tbx_kullanimPeriyodu.TabIndex = 22;
            // 
            // tbx_asiAdi
            // 
            this.tbx_asiAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_asiAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbx_asiAdi.Location = new System.Drawing.Point(367, 41);
            this.tbx_asiAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_asiAdi.Name = "tbx_asiAdi";
            this.tbx_asiAdi.Size = new System.Drawing.Size(361, 34);
            this.tbx_asiAdi.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.tbx_uygulamaTarihi);
            this.panel3.Controls.Add(this.lbl_UygulamaTarihi);
            this.panel3.Controls.Add(this.tbx_asiAdi);
            this.panel3.Controls.Add(this.tbx_kullanimPeriyodu);
            this.panel3.Controls.Add(this.lbl_AsiAdi);
            this.panel3.Controls.Add(this.lbl_KullanimPeriyodu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(259, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 303);
            this.panel3.TabIndex = 8;
            // 
            // tbx_uygulamaTarihi
            // 
            this.tbx_uygulamaTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_uygulamaTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbx_uygulamaTarihi.Location = new System.Drawing.Point(367, 140);
            this.tbx_uygulamaTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_uygulamaTarihi.Name = "tbx_uygulamaTarihi";
            this.tbx_uygulamaTarihi.Size = new System.Drawing.Size(361, 34);
            this.tbx_uygulamaTarihi.TabIndex = 25;
            // 
            // lbl_UygulamaTarihi
            // 
            this.lbl_UygulamaTarihi.AutoSize = true;
            this.lbl_UygulamaTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_UygulamaTarihi.Location = new System.Drawing.Point(74, 140);
            this.lbl_UygulamaTarihi.Name = "lbl_UygulamaTarihi";
            this.lbl_UygulamaTarihi.Size = new System.Drawing.Size(205, 28);
            this.lbl_UygulamaTarihi.TabIndex = 24;
            this.lbl_UygulamaTarihi.Text = "UYGULANIŞ TARİHİ :";
            // 
            // ekran_AsiEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1371, 599);
            this.Controls.Add(this.dgv_asi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ekran_AsiEkleme";
            this.Text = "Aşı Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_AsiEkleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_asi;
        private System.Windows.Forms.Label lbl_KullanimPeriyodu;
        private System.Windows.Forms.Label lbl_AsiAdi;
        private System.Windows.Forms.TextBox tbx_kullanimPeriyodu;
        private System.Windows.Forms.TextBox tbx_asiAdi;
        private System.Windows.Forms.Button btn_asiEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbx_uygulamaTarihi;
        private System.Windows.Forms.Label lbl_UygulamaTarihi;
    }
}