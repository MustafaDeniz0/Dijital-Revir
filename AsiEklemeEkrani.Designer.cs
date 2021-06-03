
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_asi = new System.Windows.Forms.DataGridView();
            this.AşıAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullanımPeriyodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UygulamaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_asiEkle = new System.Windows.Forms.Button();
            this.txb_kullanimPeriyodu = new System.Windows.Forms.TextBox();
            this.txb_asiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 908);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1187, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 908);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_asi);
            this.panel3.Controls.Add(this.btn_asiEkle);
            this.panel3.Controls.Add(this.txb_kullanimPeriyodu);
            this.panel3.Controls.Add(this.txb_asiAdi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 908);
            this.panel3.TabIndex = 8;
            // 
            // dgv_asi
            // 
            this.dgv_asi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_asi.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_asi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AşıAdı,
            this.KullanımPeriyodu,
            this.UygulamaTarihi});
            this.dgv_asi.Location = new System.Drawing.Point(353, 504);
            this.dgv_asi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_asi.Name = "dgv_asi";
            this.dgv_asi.RowHeadersWidth = 51;
            this.dgv_asi.RowTemplate.Height = 25;
            this.dgv_asi.Size = new System.Drawing.Size(403, 245);
            this.dgv_asi.TabIndex = 24;
            // 
            // AşıAdı
            // 
            this.AşıAdı.HeaderText = "Aşı Adı";
            this.AşıAdı.MinimumWidth = 6;
            this.AşıAdı.Name = "AşıAdı";
            this.AşıAdı.ReadOnly = true;
            this.AşıAdı.Width = 125;
            // 
            // KullanımPeriyodu
            // 
            this.KullanımPeriyodu.HeaderText = "Kullanım Periyodu";
            this.KullanımPeriyodu.MinimumWidth = 6;
            this.KullanımPeriyodu.Name = "KullanımPeriyodu";
            this.KullanımPeriyodu.ReadOnly = true;
            this.KullanımPeriyodu.Width = 125;
            // 
            // UygulamaTarihi
            // 
            this.UygulamaTarihi.HeaderText = "Uygulama Tarihi";
            this.UygulamaTarihi.MinimumWidth = 6;
            this.UygulamaTarihi.Name = "UygulamaTarihi";
            this.UygulamaTarihi.ReadOnly = true;
            this.UygulamaTarihi.Width = 125;
            // 
            // btn_asiEkle
            // 
            this.btn_asiEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_asiEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_asiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_asiEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_asiEkle.Location = new System.Drawing.Point(465, 278);
            this.btn_asiEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_asiEkle.Name = "btn_asiEkle";
            this.btn_asiEkle.Size = new System.Drawing.Size(179, 72);
            this.btn_asiEkle.TabIndex = 23;
            this.btn_asiEkle.Text = "Aşı Ekle";
            this.btn_asiEkle.UseVisualStyleBackColor = false;
            // 
            // txb_kullanimPeriyodu
            // 
            this.txb_kullanimPeriyodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txb_kullanimPeriyodu.Location = new System.Drawing.Point(353, 204);
            this.txb_kullanimPeriyodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_kullanimPeriyodu.Name = "txb_kullanimPeriyodu";
            this.txb_kullanimPeriyodu.Size = new System.Drawing.Size(403, 27);
            this.txb_kullanimPeriyodu.TabIndex = 22;
            // 
            // txb_asiAdi
            // 
            this.txb_asiAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txb_asiAdi.Location = new System.Drawing.Point(353, 158);
            this.txb_asiAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_asiAdi.Name = "txb_asiAdi";
            this.txb_asiAdi.Size = new System.Drawing.Size(403, 27);
            this.txb_asiAdi.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kullanım Periyodu :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Aşı adı :";
            // 
            // ekran_AsiEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ekran_AsiEkleme";
            this.Text = "Aşı Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_asi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AşıAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullanımPeriyodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UygulamaTarihi;
        private System.Windows.Forms.Button btn_asiEkle;
        private System.Windows.Forms.TextBox txb_kullanimPeriyodu;
        private System.Windows.Forms.TextBox txb_asiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}