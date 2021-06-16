
namespace Dijital_Revir
{
    partial class ekran_IsbMuayeneEkleme
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
            this.btn_Muayene = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrid_ISBMuayeneEkleme = new System.Windows.Forms.DataGridView();
            this.dgbtn_Sec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ISBMuayeneEkleme)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 538);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_Muayene);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 5;
            // 
            // btn_Muayene
            // 
            this.btn_Muayene.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Muayene.AutoEllipsis = true;
            this.btn_Muayene.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Muayene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Muayene.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Muayene.ForeColor = System.Drawing.Color.Black;
            this.btn_Muayene.Location = new System.Drawing.Point(59, 448);
            this.btn_Muayene.Name = "btn_Muayene";
            this.btn_Muayene.Size = new System.Drawing.Size(146, 53);
            this.btn_Muayene.TabIndex = 11;
            this.btn_Muayene.Text = "Muayene Ekle";
            this.btn_Muayene.UseVisualStyleBackColor = false;
            this.btn_Muayene.Click += new System.EventHandler(this.btn_Muayene_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrid_ISBMuayeneEkleme);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 538);
            this.panel3.TabIndex = 6;
            // 
            // dgrid_ISBMuayeneEkleme
            // 
            this.dgrid_ISBMuayeneEkleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ISBMuayeneEkleme.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgrid_ISBMuayeneEkleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ISBMuayeneEkleme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbtn_Sec});
            this.dgrid_ISBMuayeneEkleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_ISBMuayeneEkleme.GridColor = System.Drawing.Color.LightSalmon;
            this.dgrid_ISBMuayeneEkleme.Location = new System.Drawing.Point(0, 0);
            this.dgrid_ISBMuayeneEkleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_ISBMuayeneEkleme.Name = "dgrid_ISBMuayeneEkleme";
            this.dgrid_ISBMuayeneEkleme.RowHeadersWidth = 51;
            this.dgrid_ISBMuayeneEkleme.RowTemplate.Height = 29;
            this.dgrid_ISBMuayeneEkleme.Size = new System.Drawing.Size(746, 538);
            this.dgrid_ISBMuayeneEkleme.TabIndex = 5;
            this.dgrid_ISBMuayeneEkleme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ISBMuayeneEkleme_CellContentClick);
            // 
            // dgbtn_Sec
            // 
            this.dgbtn_Sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgbtn_Sec.HeaderText = "";
            this.dgbtn_Sec.MinimumWidth = 6;
            this.dgbtn_Sec.Name = "dgbtn_Sec";
            this.dgbtn_Sec.ReadOnly = true;
            this.dgbtn_Sec.Text = "Seç";
            this.dgbtn_Sec.UseColumnTextForButtonValue = true;
            this.dgbtn_Sec.Width = 125;
            // 
            // ekran_IsbMuayeneEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ekran_IsbMuayeneEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB Muayene Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_IsbMuayeneEkleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ISBMuayeneEkleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Muayene;
        private System.Windows.Forms.DataGridView dgrid_ISBMuayeneEkleme;
        private System.Windows.Forms.DataGridViewButtonColumn dgbtn_Sec;
    }
}