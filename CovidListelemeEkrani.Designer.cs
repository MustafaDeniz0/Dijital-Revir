
namespace Dijital_Revir
{
    partial class ekran_CovidListeleme
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
            this.txb_covidDurumu = new System.Windows.Forms.TextBox();
            this.txb_sirket = new System.Windows.Forms.TextBox();
            this.btn_covidListele = new System.Windows.Forms.Button();
            this.txb_soyad = new System.Windows.Forms.TextBox();
            this.txb_ad = new System.Windows.Forms.TextBox();
            this.txb_sicilNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_covidListesi = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_covidListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 538);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.txb_covidDurumu);
            this.panel2.Controls.Add(this.txb_sirket);
            this.panel2.Controls.Add(this.btn_covidListele);
            this.panel2.Controls.Add(this.txb_soyad);
            this.panel2.Controls.Add(this.txb_ad);
            this.panel2.Controls.Add(this.txb_sicilNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 8;
            // 
            // txb_covidDurumu
            // 
            this.txb_covidDurumu.Location = new System.Drawing.Point(25, 240);
            this.txb_covidDurumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_covidDurumu.Multiline = true;
            this.txb_covidDurumu.Name = "txb_covidDurumu";
            this.txb_covidDurumu.Size = new System.Drawing.Size(220, 26);
            this.txb_covidDurumu.TabIndex = 8;
            this.txb_covidDurumu.Text = "Covid Durumu";
            this.txb_covidDurumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_covidDurumu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txb_sirket
            // 
            this.txb_sirket.Location = new System.Drawing.Point(25, 195);
            this.txb_sirket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_sirket.Multiline = true;
            this.txb_sirket.Name = "txb_sirket";
            this.txb_sirket.Size = new System.Drawing.Size(220, 26);
            this.txb_sirket.TabIndex = 7;
            this.txb_sirket.Text = "Şirket";
            this.txb_sirket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sirket.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_covidListele
            // 
            this.btn_covidListele.AutoEllipsis = true;
            this.btn_covidListele.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_covidListele.Location = new System.Drawing.Point(25, 285);
            this.btn_covidListele.Name = "btn_covidListele";
            this.btn_covidListele.Size = new System.Drawing.Size(220, 52);
            this.btn_covidListele.TabIndex = 6;
            this.btn_covidListele.Text = "Listele";
            this.btn_covidListele.UseVisualStyleBackColor = false;
            // 
            // txb_soyad
            // 
            this.txb_soyad.Location = new System.Drawing.Point(25, 146);
            this.txb_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_soyad.Multiline = true;
            this.txb_soyad.Name = "txb_soyad";
            this.txb_soyad.Size = new System.Drawing.Size(220, 26);
            this.txb_soyad.TabIndex = 2;
            this.txb_soyad.Text = "Soyad";
            this.txb_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_ad
            // 
            this.txb_ad.Location = new System.Drawing.Point(25, 95);
            this.txb_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ad.Multiline = true;
            this.txb_ad.Name = "txb_ad";
            this.txb_ad.Size = new System.Drawing.Size(220, 26);
            this.txb_ad.TabIndex = 1;
            this.txb_ad.Text = "Ad";
            this.txb_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_sicilNo
            // 
            this.txb_sicilNo.Location = new System.Drawing.Point(25, 43);
            this.txb_sicilNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_sicilNo.Multiline = true;
            this.txb_sicilNo.Name = "txb_sicilNo";
            this.txb_sicilNo.Size = new System.Drawing.Size(220, 26);
            this.txb_sicilNo.TabIndex = 0;
            this.txb_sicilNo.Text = "Sicil No";
            this.txb_sicilNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_covidListesi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 538);
            this.panel3.TabIndex = 10;
            // 
            // dgv_covidListesi
            // 
            this.dgv_covidListesi.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_covidListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_covidListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button});
            this.dgv_covidListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_covidListesi.GridColor = System.Drawing.Color.Salmon;
            this.dgv_covidListesi.Location = new System.Drawing.Point(0, 0);
            this.dgv_covidListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_covidListesi.Name = "dgv_covidListesi";
            this.dgv_covidListesi.RowHeadersWidth = 51;
            this.dgv_covidListesi.RowTemplate.Height = 29;
            this.dgv_covidListesi.Size = new System.Drawing.Size(746, 538);
            this.dgv_covidListesi.TabIndex = 11;
            this.dgv_covidListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_covidListesi_CellContentClick_1);
            // 
            // button
            // 
            this.button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.button.HeaderText = "";
            this.button.MinimumWidth = 6;
            this.button.Name = "button";
            this.button.ReadOnly = true;
            this.button.Width = 187;
            // 
            // ekran_CovidListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ekran_CovidListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_CovidListeleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_covidListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_covidListele;
        private System.Windows.Forms.TextBox txb_soyad;
        private System.Windows.Forms.TextBox txb_ad;
        private System.Windows.Forms.TextBox txb_sicilNo;
        private System.Windows.Forms.TextBox txb_sirket;
        private System.Windows.Forms.TextBox txb_covidDurumu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_covidListesi;
        private System.Windows.Forms.DataGridViewButtonColumn button;
    }
}