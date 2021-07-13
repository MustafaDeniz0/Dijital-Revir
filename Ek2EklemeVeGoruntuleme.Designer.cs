
namespace Dijital_Revir
{
    partial class ekran_Ek2EklemeVeGoruntuleme
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
            this.dgv_pdf = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_pdfEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pdf)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pdf
            // 
            this.dgv_pdf.AllowUserToAddRows = false;
            this.dgv_pdf.AllowUserToDeleteRows = false;
            this.dgv_pdf.AllowUserToResizeColumns = false;
            this.dgv_pdf.AllowUserToResizeRows = false;
            this.dgv_pdf.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_pdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pdf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button});
            this.dgv_pdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pdf.GridColor = System.Drawing.Color.Salmon;
            this.dgv_pdf.Location = new System.Drawing.Point(258, 0);
            this.dgv_pdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_pdf.MultiSelect = false;
            this.dgv_pdf.Name = "dgv_pdf";
            this.dgv_pdf.RowHeadersWidth = 51;
            this.dgv_pdf.RowTemplate.Height = 29;
            this.dgv_pdf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pdf.Size = new System.Drawing.Size(717, 661);
            this.dgv_pdf.TabIndex = 10;
            this.dgv_pdf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pdf_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 661);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_pdfEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(975, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 661);
            this.panel2.TabIndex = 8;
            // 
            // btn_pdfEkle
            // 
            this.btn_pdfEkle.AutoEllipsis = true;
            this.btn_pdfEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_pdfEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_pdfEkle.Location = new System.Drawing.Point(15, 327);
            this.btn_pdfEkle.Name = "btn_pdfEkle";
            this.btn_pdfEkle.Size = new System.Drawing.Size(220, 52);
            this.btn_pdfEkle.TabIndex = 6;
            this.btn_pdfEkle.TabStop = false;
            this.btn_pdfEkle.Text = "PDF EKLE";
            this.btn_pdfEkle.UseVisualStyleBackColor = false;
            this.btn_pdfEkle.Click += new System.EventHandler(this.btn_pdfEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ekran_Ek2EklemeVeGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1233, 661);
            this.Controls.Add(this.dgv_pdf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "ekran_Ek2EklemeVeGoruntuleme";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ek2EklemeVeGoruntuleme";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ek2EklemeVeGoruntuleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pdf)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pdf;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pdfEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}