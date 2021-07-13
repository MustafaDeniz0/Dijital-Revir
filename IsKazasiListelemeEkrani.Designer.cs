
namespace Dijital_Revir
{
    partial class ekran_IsKazasiListeleme
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
            this.btn_temizle = new System.Windows.Forms.Button();
            this.tbx_KazaSaati = new System.Windows.Forms.TextBox();
            this.tbx_sirket = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dtp_isKazasi = new System.Windows.Forms.DateTimePicker();
            this.tbx_soyad = new System.Windows.Forms.TextBox();
            this.tbx_ad = new System.Windows.Forms.TextBox();
            this.tbx_sicilNo = new System.Windows.Forms.TextBox();
            this.dgv_isKazaListesi = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_isKazaListesi)).BeginInit();
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
            this.panel2.Controls.Add(this.btn_temizle);
            this.panel2.Controls.Add(this.tbx_KazaSaati);
            this.panel2.Controls.Add(this.tbx_sirket);
            this.panel2.Controls.Add(this.btn_listele);
            this.panel2.Controls.Add(this.dtp_isKazasi);
            this.panel2.Controls.Add(this.tbx_soyad);
            this.panel2.Controls.Add(this.tbx_ad);
            this.panel2.Controls.Add(this.tbx_sicilNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 5;
            // 
            // btn_temizle
            // 
            this.btn_temizle.AutoEllipsis = true;
            this.btn_temizle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(140, 292);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(109, 52);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // tbx_KazaSaati
            // 
            this.tbx_KazaSaati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_KazaSaati.Location = new System.Drawing.Point(164, 241);
            this.tbx_KazaSaati.MaxLength = 5;
            this.tbx_KazaSaati.Name = "tbx_KazaSaati";
            this.tbx_KazaSaati.Size = new System.Drawing.Size(81, 27);
            this.tbx_KazaSaati.TabIndex = 8;
            this.tbx_KazaSaati.TabStop = false;
            this.tbx_KazaSaati.Text = "00:00";
            this.tbx_KazaSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_KazaSaati.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_KazaSaati_MouseClick);
            // 
            // tbx_sirket
            // 
            this.tbx_sirket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sirket.Location = new System.Drawing.Point(25, 190);
            this.tbx_sirket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_sirket.Multiline = true;
            this.tbx_sirket.Name = "tbx_sirket";
            this.tbx_sirket.Size = new System.Drawing.Size(220, 26);
            this.tbx_sirket.TabIndex = 7;
            this.tbx_sirket.TabStop = false;
            this.tbx_sirket.Text = "ŞİRKET";
            this.tbx_sirket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_sirket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_sirket_MouseClick);
            // 
            // btn_listele
            // 
            this.btn_listele.AutoEllipsis = true;
            this.btn_listele.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(25, 292);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(109, 52);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.TabStop = false;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // dtp_isKazasi
            // 
            this.dtp_isKazasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_isKazasi.Location = new System.Drawing.Point(25, 242);
            this.dtp_isKazasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_isKazasi.Name = "dtp_isKazasi";
            this.dtp_isKazasi.Size = new System.Drawing.Size(133, 27);
            this.dtp_isKazasi.TabIndex = 3;
            this.dtp_isKazasi.TabStop = false;
            // 
            // tbx_soyad
            // 
            this.tbx_soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_soyad.Location = new System.Drawing.Point(25, 146);
            this.tbx_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_soyad.Multiline = true;
            this.tbx_soyad.Name = "tbx_soyad";
            this.tbx_soyad.Size = new System.Drawing.Size(220, 26);
            this.tbx_soyad.TabIndex = 2;
            this.tbx_soyad.TabStop = false;
            this.tbx_soyad.Text = "SOYAD";
            this.tbx_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_soyad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_soyad_MouseClick);
            // 
            // tbx_ad
            // 
            this.tbx_ad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_ad.Location = new System.Drawing.Point(25, 95);
            this.tbx_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_ad.Multiline = true;
            this.tbx_ad.Name = "tbx_ad";
            this.tbx_ad.Size = new System.Drawing.Size(220, 26);
            this.tbx_ad.TabIndex = 1;
            this.tbx_ad.TabStop = false;
            this.tbx_ad.Text = "AD";
            this.tbx_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_ad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_ad_MouseClick);
            // 
            // tbx_sicilNo
            // 
            this.tbx_sicilNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sicilNo.Location = new System.Drawing.Point(25, 43);
            this.tbx_sicilNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_sicilNo.Multiline = true;
            this.tbx_sicilNo.Name = "tbx_sicilNo";
            this.tbx_sicilNo.Size = new System.Drawing.Size(220, 26);
            this.tbx_sicilNo.TabIndex = 0;
            this.tbx_sicilNo.TabStop = false;
            this.tbx_sicilNo.Text = "SİCİL NO";
            this.tbx_sicilNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_sicilNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_sicilNo_MouseClick);
            // 
            // dgv_isKazaListesi
            // 
            this.dgv_isKazaListesi.AllowDrop = true;
            this.dgv_isKazaListesi.AllowUserToAddRows = false;
            this.dgv_isKazaListesi.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_isKazaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_isKazaListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button});
            this.dgv_isKazaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_isKazaListesi.GridColor = System.Drawing.Color.Salmon;
            this.dgv_isKazaListesi.Location = new System.Drawing.Point(258, 0);
            this.dgv_isKazaListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_isKazaListesi.MultiSelect = false;
            this.dgv_isKazaListesi.Name = "dgv_isKazaListesi";
            this.dgv_isKazaListesi.RowHeadersWidth = 51;
            this.dgv_isKazaListesi.RowTemplate.Height = 29;
            this.dgv_isKazaListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_isKazaListesi.Size = new System.Drawing.Size(746, 538);
            this.dgv_isKazaListesi.TabIndex = 7;
            this.dgv_isKazaListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_isKazaListesi_CellContentClick);
            // 
            // button
            // 
            this.button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.button.HeaderText = "";
            this.button.MinimumWidth = 6;
            this.button.Name = "button";
            this.button.ReadOnly = true;
            this.button.Width = 125;
            // 
            // ekran_IsKazasiListeleme
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.dgv_isKazaListesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ekran_IsKazasiListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Kazası Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_IsKazasiListeleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_isKazaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_sicilNo;
        private System.Windows.Forms.DataGridView dgv_isKazaListesi;
        private System.Windows.Forms.DateTimePicker dtp_isKazasi;
        private System.Windows.Forms.TextBox tbx_soyad;
        private System.Windows.Forms.TextBox tbx_ad;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.TextBox tbx_sirket;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.TextBox tbx_KazaSaati;
        private System.Windows.Forms.Button btn_temizle;
    }
}