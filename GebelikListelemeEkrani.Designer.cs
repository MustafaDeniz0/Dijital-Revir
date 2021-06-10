
namespace Dijital_Revir
{
    partial class ekran_GebelikListeleme
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
            this.tbx_sirket = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.tbx_soyad = new System.Windows.Forms.TextBox();
            this.tbx_ad = new System.Windows.Forms.TextBox();
            this.txb_sicilNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_gebelikListesi = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gebelikListesi)).BeginInit();
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
            this.panel2.Controls.Add(this.tbx_sirket);
            this.panel2.Controls.Add(this.btn_listele);
            this.panel2.Controls.Add(this.tbx_soyad);
            this.panel2.Controls.Add(this.tbx_ad);
            this.panel2.Controls.Add(this.txb_sicilNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 8;
            // 
            // tbx_sirket
            // 
            this.tbx_sirket.Location = new System.Drawing.Point(25, 190);
            this.tbx_sirket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_sirket.Multiline = true;
            this.tbx_sirket.Name = "tbx_sirket";
            this.tbx_sirket.Size = new System.Drawing.Size(220, 26);
            this.tbx_sirket.TabIndex = 7;
            this.tbx_sirket.Text = "Şirket";
            this.tbx_sirket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_listele
            // 
            this.btn_listele.AutoEllipsis = true;
            this.btn_listele.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_listele.Location = new System.Drawing.Point(25, 250);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(220, 52);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_AraButonu_Click);
            // 
            // tbx_soyad
            // 
            this.tbx_soyad.Location = new System.Drawing.Point(25, 146);
            this.tbx_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_soyad.Multiline = true;
            this.tbx_soyad.Name = "tbx_soyad";
            this.tbx_soyad.Size = new System.Drawing.Size(220, 26);
            this.tbx_soyad.TabIndex = 2;
            this.tbx_soyad.Text = "Soyad";
            this.tbx_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_ad
            // 
            this.tbx_ad.Location = new System.Drawing.Point(25, 95);
            this.tbx_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_ad.Multiline = true;
            this.tbx_ad.Name = "tbx_ad";
            this.tbx_ad.Size = new System.Drawing.Size(220, 26);
            this.tbx_ad.TabIndex = 1;
            this.tbx_ad.Text = "Ad";
            this.tbx_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel3.Controls.Add(this.dgv_gebelikListesi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 538);
            this.panel3.TabIndex = 10;
            // 
            // dgv_gebelikListesi
            // 
            this.dgv_gebelikListesi.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_gebelikListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gebelikListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button});
            this.dgv_gebelikListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_gebelikListesi.GridColor = System.Drawing.Color.Salmon;
            this.dgv_gebelikListesi.Location = new System.Drawing.Point(0, 0);
            this.dgv_gebelikListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_gebelikListesi.Name = "dgv_gebelikListesi";
            this.dgv_gebelikListesi.RowHeadersWidth = 51;
            this.dgv_gebelikListesi.RowTemplate.Height = 29;
            this.dgv_gebelikListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gebelikListesi.Size = new System.Drawing.Size(746, 538);
            this.dgv_gebelikListesi.TabIndex = 11;
            this.dgv_gebelikListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gebelikListesi_CellContentClick_1);
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
            // ekran_GebelikListeleme
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
            this.Name = "ekran_GebelikListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gebelik Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_GebelikListeleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gebelikListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_sirket;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.TextBox tbx_soyad;
        private System.Windows.Forms.TextBox tbx_ad;
        private System.Windows.Forms.TextBox txb_sicilNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_gebelikListesi;
        private System.Windows.Forms.DataGridViewButtonColumn button;
    }
}