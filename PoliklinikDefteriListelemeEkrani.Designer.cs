
namespace Dijital_Revir
{
    partial class ekran_PoliklinikDefteriListeleme
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
            this.txb_sirketAdi = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txb_soyad = new System.Windows.Forms.TextBox();
            this.txb_ad = new System.Windows.Forms.TextBox();
            this.btn_poliklinikDefteriListele = new System.Windows.Forms.Button();
            this.txb_sicilNo = new System.Windows.Forms.TextBox();
            this.txb_siraNo = new System.Windows.Forms.TextBox();
            this.dgv_PoliklinikListeleme = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PoliklinikListeleme)).BeginInit();
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
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_temizle);
            this.panel2.Controls.Add(this.txb_sirketAdi);
            this.panel2.Controls.Add(this.btn_ekle);
            this.panel2.Controls.Add(this.txb_soyad);
            this.panel2.Controls.Add(this.txb_ad);
            this.panel2.Controls.Add(this.btn_poliklinikDefteriListele);
            this.panel2.Controls.Add(this.txb_sicilNo);
            this.panel2.Controls.Add(this.txb_siraNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 11;
            // 
            // btn_temizle
            // 
            this.btn_temizle.AutoEllipsis = true;
            this.btn_temizle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_temizle.Location = new System.Drawing.Point(134, 240);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 52);
            this.btn_temizle.TabIndex = 17;
            this.btn_temizle.TabStop = false;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // txb_sirketAdi
            // 
            this.txb_sirketAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sirketAdi.Location = new System.Drawing.Point(14, 200);
            this.txb_sirketAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_sirketAdi.Multiline = true;
            this.txb_sirketAdi.Name = "txb_sirketAdi";
            this.txb_sirketAdi.Size = new System.Drawing.Size(231, 26);
            this.txb_sirketAdi.TabIndex = 15;
            this.txb_sirketAdi.TabStop = false;
            this.txb_sirketAdi.Text = "ŞİRKET ADI";
            this.txb_sirketAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sirketAdi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_taniGrubu_MouseClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.AutoEllipsis = true;
            this.btn_ekle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(14, 298);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(232, 52);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.TabStop = false;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txb_soyad
            // 
            this.txb_soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soyad.Location = new System.Drawing.Point(14, 161);
            this.txb_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_soyad.Multiline = true;
            this.txb_soyad.Name = "txb_soyad";
            this.txb_soyad.Size = new System.Drawing.Size(231, 26);
            this.txb_soyad.TabIndex = 13;
            this.txb_soyad.TabStop = false;
            this.txb_soyad.Text = "SOYAD";
            this.txb_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_soyad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_soyad_MouseClick);
            // 
            // txb_ad
            // 
            this.txb_ad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ad.Location = new System.Drawing.Point(14, 122);
            this.txb_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ad.Multiline = true;
            this.txb_ad.Name = "txb_ad";
            this.txb_ad.Size = new System.Drawing.Size(232, 26);
            this.txb_ad.TabIndex = 12;
            this.txb_ad.TabStop = false;
            this.txb_ad.Text = "AD";
            this.txb_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_ad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_ad_MouseClick);
            // 
            // btn_poliklinikDefteriListele
            // 
            this.btn_poliklinikDefteriListele.AutoEllipsis = true;
            this.btn_poliklinikDefteriListele.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_poliklinikDefteriListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_poliklinikDefteriListele.Location = new System.Drawing.Point(14, 240);
            this.btn_poliklinikDefteriListele.Name = "btn_poliklinikDefteriListele";
            this.btn_poliklinikDefteriListele.Size = new System.Drawing.Size(114, 52);
            this.btn_poliklinikDefteriListele.TabIndex = 14;
            this.btn_poliklinikDefteriListele.TabStop = false;
            this.btn_poliklinikDefteriListele.Text = "LİSTELE";
            this.btn_poliklinikDefteriListele.UseVisualStyleBackColor = false;
            this.btn_poliklinikDefteriListele.Click += new System.EventHandler(this.btn_poliklinikDefteriListele_Click);
            // 
            // txb_sicilNo
            // 
            this.txb_sicilNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sicilNo.Location = new System.Drawing.Point(14, 81);
            this.txb_sicilNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_sicilNo.Multiline = true;
            this.txb_sicilNo.Name = "txb_sicilNo";
            this.txb_sicilNo.Size = new System.Drawing.Size(232, 26);
            this.txb_sicilNo.TabIndex = 11;
            this.txb_sicilNo.TabStop = false;
            this.txb_sicilNo.Text = "SİCİL NO";
            this.txb_sicilNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sicilNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_sicilNo_MouseClick);
            // 
            // txb_siraNo
            // 
            this.txb_siraNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_siraNo.Location = new System.Drawing.Point(14, 39);
            this.txb_siraNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_siraNo.Multiline = true;
            this.txb_siraNo.Name = "txb_siraNo";
            this.txb_siraNo.Size = new System.Drawing.Size(232, 26);
            this.txb_siraNo.TabIndex = 0;
            this.txb_siraNo.TabStop = false;
            this.txb_siraNo.Text = "SIRA NO";
            this.txb_siraNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_siraNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_siraNo_MouseClick);
            // 
            // dgv_PoliklinikListeleme
            // 
            this.dgv_PoliklinikListeleme.AllowUserToAddRows = false;
            this.dgv_PoliklinikListeleme.AllowUserToDeleteRows = false;
            this.dgv_PoliklinikListeleme.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_PoliklinikListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PoliklinikListeleme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button});
            this.dgv_PoliklinikListeleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PoliklinikListeleme.GridColor = System.Drawing.Color.Salmon;
            this.dgv_PoliklinikListeleme.Location = new System.Drawing.Point(0, 0);
            this.dgv_PoliklinikListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_PoliklinikListeleme.Name = "dgv_PoliklinikListeleme";
            this.dgv_PoliklinikListeleme.RowHeadersWidth = 51;
            this.dgv_PoliklinikListeleme.RowTemplate.Height = 29;
            this.dgv_PoliklinikListeleme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PoliklinikListeleme.Size = new System.Drawing.Size(746, 538);
            this.dgv_PoliklinikListeleme.TabIndex = 13;
            this.dgv_PoliklinikListeleme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_PoliklinikListeleme);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 538);
            this.panel3.TabIndex = 14;
            // 
            // ekran_PoliklinikDefteriListeleme
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
            this.Name = "ekran_PoliklinikDefteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik Defteri Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_PoliklinikDefteriListeleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PoliklinikListeleme)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_siraNo;
        private System.Windows.Forms.DataGridView dgv_PoliklinikListeleme;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.TextBox txb_sirketAdi;
        private System.Windows.Forms.Button btn_poliklinikDefteriListele;
        private System.Windows.Forms.TextBox txb_soyad;
        private System.Windows.Forms.TextBox txb_ad;
        private System.Windows.Forms.TextBox txb_sicilNo;
    }
}