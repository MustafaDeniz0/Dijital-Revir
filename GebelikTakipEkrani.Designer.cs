
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gebelikTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 726);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 726);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btn_degerEkle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgv_gebelikTablosu);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 726);
            this.panel3.TabIndex = 8;
            // 
            // btn_degerEkle
            // 
            this.btn_degerEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_degerEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_degerEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_degerEkle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_degerEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_degerEkle.Location = new System.Drawing.Point(6, 83);
            this.btn_degerEkle.Name = "btn_degerEkle";
            this.btn_degerEkle.Size = new System.Drawing.Size(179, 58);
            this.btn_degerEkle.TabIndex = 21;
            this.btn_degerEkle.Text = "Değer Ekle";
            this.btn_degerEkle.UseVisualStyleBackColor = false;
            this.btn_degerEkle.Click += new System.EventHandler(this.btn_degerEkle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Son Adet Tarihi :";
            // 
            // dgv_gebelikTablosu
            // 
            this.dgv_gebelikTablosu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_gebelikTablosu.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_gebelikTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gebelikTablosu.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_gebelikTablosu.Location = new System.Drawing.Point(6, 160);
            this.dgv_gebelikTablosu.Name = "dgv_gebelikTablosu";
            this.dgv_gebelikTablosu.RowHeadersWidth = 35;
            this.dgv_gebelikTablosu.RowTemplate.Height = 25;
            this.dgv_gebelikTablosu.Size = new System.Drawing.Size(913, 185);
            this.dgv_gebelikTablosu.TabIndex = 19;
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
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ekran_GebelikTakip";
            this.Text = "Gebelik Takibi";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_GebelikTakip_Load);
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
    }
}