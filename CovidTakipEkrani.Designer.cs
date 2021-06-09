
namespace Dijital_Revir
{
    partial class ekran_CovidTakipEkrani
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
            this.btn_OlcumAtesEkle = new System.Windows.Forms.Button();
            this.btn_TestEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testSonucu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_olcum = new System.Windows.Forms.DataGridView();
            this.olcumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olcumDegeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbx_CovidListeleme = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_olcum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 437);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btn_OlcumAtesEkle);
            this.panel2.Controls.Add(this.btn_TestEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(752, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 437);
            this.panel2.TabIndex = 11;
            // 
            // btn_OlcumAtesEkle
            // 
            this.btn_OlcumAtesEkle.AutoEllipsis = true;
            this.btn_OlcumAtesEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_OlcumAtesEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_OlcumAtesEkle.Location = new System.Drawing.Point(7, 293);
            this.btn_OlcumAtesEkle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_OlcumAtesEkle.Name = "btn_OlcumAtesEkle";
            this.btn_OlcumAtesEkle.Size = new System.Drawing.Size(165, 42);
            this.btn_OlcumAtesEkle.TabIndex = 9;
            this.btn_OlcumAtesEkle.Text = "Ölçüm Ekle";
            this.btn_OlcumAtesEkle.UseVisualStyleBackColor = false;
            // 
            // btn_TestEkle
            // 
            this.btn_TestEkle.AutoEllipsis = true;
            this.btn_TestEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_TestEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_TestEkle.Location = new System.Drawing.Point(7, 364);
            this.btn_TestEkle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_TestEkle.Name = "btn_TestEkle";
            this.btn_TestEkle.Size = new System.Drawing.Size(165, 42);
            this.btn_TestEkle.TabIndex = 8;
            this.btn_TestEkle.Text = "Test Ekle";
            this.btn_TestEkle.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_test);
            this.panel3.Controls.Add(this.dgv_olcum);
            this.panel3.Controls.Add(this.tbx_CovidListeleme);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 437);
            this.panel3.TabIndex = 13;
            // 
            // dgv_test
            // 
            this.dgv_test.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_test.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.testSonucu});
            this.dgv_test.Location = new System.Drawing.Point(5, 367);
            this.dgv_test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.RowHeadersWidth = 51;
            this.dgv_test.RowTemplate.Height = 29;
            this.dgv_test.Size = new System.Drawing.Size(552, 60);
            this.dgv_test.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Test Tarihi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Test Türü";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // testSonucu
            // 
            this.testSonucu.HeaderText = "Test Sonucu";
            this.testSonucu.MinimumWidth = 6;
            this.testSonucu.Name = "testSonucu";
            this.testSonucu.ReadOnly = true;
            this.testSonucu.Width = 125;
            // 
            // dgv_olcum
            // 
            this.dgv_olcum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_olcum.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_olcum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_olcum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.olcumTarihi,
            this.olcumDegeri});
            this.dgv_olcum.Location = new System.Drawing.Point(5, 296);
            this.dgv_olcum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_olcum.Name = "dgv_olcum";
            this.dgv_olcum.RowHeadersWidth = 51;
            this.dgv_olcum.RowTemplate.Height = 29;
            this.dgv_olcum.Size = new System.Drawing.Size(552, 60);
            this.dgv_olcum.TabIndex = 41;
            // 
            // olcumTarihi
            // 
            this.olcumTarihi.HeaderText = "Ölçüm Tarihi";
            this.olcumTarihi.MinimumWidth = 6;
            this.olcumTarihi.Name = "olcumTarihi";
            this.olcumTarihi.ReadOnly = true;
            this.olcumTarihi.Width = 125;
            // 
            // olcumDegeri
            // 
            this.olcumDegeri.HeaderText = "Ölçüm Değeri";
            this.olcumDegeri.MinimumWidth = 6;
            this.olcumDegeri.Name = "olcumDegeri";
            this.olcumDegeri.ReadOnly = true;
            this.olcumDegeri.Width = 125;
            // 
            // tbx_CovidListeleme
            // 
            this.tbx_CovidListeleme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_CovidListeleme.Location = new System.Drawing.Point(5, 13);
            this.tbx_CovidListeleme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_CovidListeleme.Multiline = true;
            this.tbx_CovidListeleme.Name = "tbx_CovidListeleme";
            this.tbx_CovidListeleme.Size = new System.Drawing.Size(553, 270);
            this.tbx_CovidListeleme.TabIndex = 40;
            this.tbx_CovidListeleme.TextChanged += new System.EventHandler(this.tbx_CovidListeleme_TextChanged);
            // 
            // ekran_CovidTakipEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(946, 437);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ekran_CovidTakipEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid Takip Ekran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CovidTakipEkrani_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_olcum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_OlcumAtesEkle;
        private System.Windows.Forms.Button btn_TestEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn testSonucu;
        private System.Windows.Forms.DataGridView dgv_olcum;
        private System.Windows.Forms.DataGridViewTextBoxColumn olcumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn olcumDegeri;
        private System.Windows.Forms.TextBox tbx_CovidListeleme;
    }
}