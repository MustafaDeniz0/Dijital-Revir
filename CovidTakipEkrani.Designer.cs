
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
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_OlcumAtesEkle = new System.Windows.Forms.Button();
            this.btn_TestEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.dgv_olcum = new System.Windows.Forms.DataGridView();
            this.tbx_CovidListeleme = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_olcum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 677);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_sil);
            this.panel2.Controls.Add(this.btn_OlcumAtesEkle);
            this.panel2.Controls.Add(this.btn_TestEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1002, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 677);
            this.panel2.TabIndex = 11;
            // 
            // btn_sil
            // 
            this.btn_sil.AutoEllipsis = true;
            this.btn_sil.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_sil.Location = new System.Drawing.Point(18, 227);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(220, 52);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "COVİD KAYDI SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_OlcumAtesEkle
            // 
            this.btn_OlcumAtesEkle.AutoEllipsis = true;
            this.btn_OlcumAtesEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_OlcumAtesEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_OlcumAtesEkle.Location = new System.Drawing.Point(18, 427);
            this.btn_OlcumAtesEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OlcumAtesEkle.Name = "btn_OlcumAtesEkle";
            this.btn_OlcumAtesEkle.Size = new System.Drawing.Size(220, 52);
            this.btn_OlcumAtesEkle.TabIndex = 9;
            this.btn_OlcumAtesEkle.Text = "ATEŞ ÖLÇÜM DEĞERİ EKLE";
            this.btn_OlcumAtesEkle.UseVisualStyleBackColor = false;
            this.btn_OlcumAtesEkle.Click += new System.EventHandler(this.btn_OlcumAtesEkle_Click);
            // 
            // btn_TestEkle
            // 
            this.btn_TestEkle.AutoEllipsis = true;
            this.btn_TestEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_TestEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_TestEkle.Location = new System.Drawing.Point(18, 625);
            this.btn_TestEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TestEkle.Name = "btn_TestEkle";
            this.btn_TestEkle.Size = new System.Drawing.Size(220, 52);
            this.btn_TestEkle.TabIndex = 8;
            this.btn_TestEkle.Text = "TEST ÖLÇÜM DEĞERİ EKLE";
            this.btn_TestEkle.UseVisualStyleBackColor = false;
            this.btn_TestEkle.Click += new System.EventHandler(this.btn_TestEkle_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_test);
            this.panel3.Controls.Add(this.dgv_olcum);
            this.panel3.Controls.Add(this.tbx_CovidListeleme);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 677);
            this.panel3.TabIndex = 13;
            // 
            // dgv_test
            // 
            this.dgv_test.AllowUserToAddRows = false;
            this.dgv_test.AllowUserToDeleteRows = false;
            this.dgv_test.AllowUserToResizeColumns = false;
            this.dgv_test.AllowUserToResizeRows = false;
            this.dgv_test.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_test.Location = new System.Drawing.Point(0, 479);
            this.dgv_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.RowHeadersWidth = 51;
            this.dgv_test.RowTemplate.Height = 29;
            this.dgv_test.Size = new System.Drawing.Size(743, 200);
            this.dgv_test.TabIndex = 42;
            // 
            // dgv_olcum
            // 
            this.dgv_olcum.AllowUserToAddRows = false;
            this.dgv_olcum.AllowUserToDeleteRows = false;
            this.dgv_olcum.AllowUserToResizeColumns = false;
            this.dgv_olcum.AllowUserToResizeRows = false;
            this.dgv_olcum.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_olcum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_olcum.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_olcum.Location = new System.Drawing.Point(0, 279);
            this.dgv_olcum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_olcum.Name = "dgv_olcum";
            this.dgv_olcum.RowHeadersWidth = 51;
            this.dgv_olcum.RowTemplate.Height = 29;
            this.dgv_olcum.Size = new System.Drawing.Size(743, 200);
            this.dgv_olcum.TabIndex = 41;
            // 
            // tbx_CovidListeleme
            // 
            this.tbx_CovidListeleme.BackColor = System.Drawing.Color.LightGray;
            this.tbx_CovidListeleme.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_CovidListeleme.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_CovidListeleme.Location = new System.Drawing.Point(0, 0);
            this.tbx_CovidListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_CovidListeleme.Multiline = true;
            this.tbx_CovidListeleme.Name = "tbx_CovidListeleme";
            this.tbx_CovidListeleme.ReadOnly = true;
            this.tbx_CovidListeleme.Size = new System.Drawing.Size(743, 279);
            this.tbx_CovidListeleme.TabIndex = 40;
            // 
            // ekran_CovidTakipEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1261, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridView dgv_olcum;
        private System.Windows.Forms.TextBox tbx_CovidListeleme;
        private System.Windows.Forms.Button btn_sil;
    }
}