
namespace Dijital_Revir
{
    partial class ekran_GebelikTakip
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_degerEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_gebelikTablosu = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TADeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabızDeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HMGDeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TİTDeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretibialÖdemDeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AşıDeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EkTetkikDeğeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verilenİlaç = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gebelikTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 726);
            this.panel2.TabIndex = 7;
            this.panel2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 726);
            this.panel1.TabIndex = 7;
            this.panel1.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btn_degerEkle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgv_gebelikTablosu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 726);
            this.panel3.TabIndex = 8;
            this.panel3.UseWaitCursor = true;
            // 
            // btn_degerEkle
            // 
            this.btn_degerEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_degerEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_degerEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_degerEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_degerEkle.Location = new System.Drawing.Point(6, 83);
            this.btn_degerEkle.Name = "btn_degerEkle";
            this.btn_degerEkle.Size = new System.Drawing.Size(179, 58);
            this.btn_degerEkle.TabIndex = 21;
            this.btn_degerEkle.Text = "Değer Ekle";
            this.btn_degerEkle.UseVisualStyleBackColor = false;
            this.btn_degerEkle.UseWaitCursor = true;
            this.btn_degerEkle.Click += new System.EventHandler(this.btn_degerEkle_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Son Adet Tarihi :";
            this.label2.UseWaitCursor = true;
            // 
            // dgv_gebelikTablosu
            // 
            this.dgv_gebelikTablosu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_gebelikTablosu.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_gebelikTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gebelikTablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.Kilo,
            this.TADeğeri,
            this.NabızDeğeri,
            this.HMGDeğeri,
            this.TİTDeğeri,
            this.PretibialÖdemDeğeri,
            this.AşıDeğeri,
            this.EkTetkikDeğeri,
            this.Verilenİlaç});
            this.dgv_gebelikTablosu.Location = new System.Drawing.Point(6, 160);
            this.dgv_gebelikTablosu.Name = "dgv_gebelikTablosu";
            this.dgv_gebelikTablosu.RowHeadersWidth = 35;
            this.dgv_gebelikTablosu.RowTemplate.Height = 25;
            this.dgv_gebelikTablosu.Size = new System.Drawing.Size(913, 160);
            this.dgv_gebelikTablosu.TabIndex = 19;
            this.dgv_gebelikTablosu.UseWaitCursor = true;
            // 
            // Tarih
            // 
            this.Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Kilo
            // 
            this.Kilo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kilo.HeaderText = "Kilo";
            this.Kilo.MinimumWidth = 6;
            this.Kilo.Name = "Kilo";
            this.Kilo.ReadOnly = true;
            // 
            // TADeğeri
            // 
            this.TADeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TADeğeri.HeaderText = "TA Değeri";
            this.TADeğeri.MinimumWidth = 6;
            this.TADeğeri.Name = "TADeğeri";
            this.TADeğeri.ReadOnly = true;
            // 
            // NabızDeğeri
            // 
            this.NabızDeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NabızDeğeri.HeaderText = "Nabız Değeri";
            this.NabızDeğeri.MinimumWidth = 6;
            this.NabızDeğeri.Name = "NabızDeğeri";
            this.NabızDeğeri.ReadOnly = true;
            // 
            // HMGDeğeri
            // 
            this.HMGDeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HMGDeğeri.HeaderText = "HMG Değeri";
            this.HMGDeğeri.MinimumWidth = 6;
            this.HMGDeğeri.Name = "HMGDeğeri";
            this.HMGDeğeri.ReadOnly = true;
            // 
            // TİTDeğeri
            // 
            this.TİTDeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TİTDeğeri.HeaderText = "TİT Değeri";
            this.TİTDeğeri.MinimumWidth = 6;
            this.TİTDeğeri.Name = "TİTDeğeri";
            this.TİTDeğeri.ReadOnly = true;
            // 
            // PretibialÖdemDeğeri
            // 
            this.PretibialÖdemDeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PretibialÖdemDeğeri.HeaderText = "Pretibial Ödem Değeri";
            this.PretibialÖdemDeğeri.MinimumWidth = 6;
            this.PretibialÖdemDeğeri.Name = "PretibialÖdemDeğeri";
            this.PretibialÖdemDeğeri.ReadOnly = true;
            // 
            // AşıDeğeri
            // 
            this.AşıDeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AşıDeğeri.HeaderText = "Aşı Değeri";
            this.AşıDeğeri.MinimumWidth = 6;
            this.AşıDeğeri.Name = "AşıDeğeri";
            this.AşıDeğeri.ReadOnly = true;
            // 
            // EkTetkikDeğeri
            // 
            this.EkTetkikDeğeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EkTetkikDeğeri.HeaderText = "Ek Tetkik Değeri";
            this.EkTetkikDeğeri.MinimumWidth = 6;
            this.EkTetkikDeğeri.Name = "EkTetkikDeğeri";
            this.EkTetkikDeğeri.ReadOnly = true;
            // 
            // Verilenİlaç
            // 
            this.Verilenİlaç.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Verilenİlaç.HeaderText = "Verilen İlaç";
            this.Verilenİlaç.MinimumWidth = 6;
            this.Verilenİlaç.Name = "Verilenİlaç";
            this.Verilenİlaç.ReadOnly = true;
            // 
            // ekran_GebelikTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1445, 726);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ekran_GebelikTakip";
            this.Text = "Gebelik Takibi";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gebelik_Ekrani_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gebelikTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_degerEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_gebelikTablosu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TADeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabızDeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn HMGDeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn TİTDeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretibialÖdemDeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn AşıDeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn EkTetkikDeğeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verilenİlaç;
    }
}