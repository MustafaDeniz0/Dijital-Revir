
namespace Dijital_Revir
{
    partial class ekran_PersonelListeleme
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
            this.dgrid_PersonelBilgileri = new System.Windows.Forms.DataGridView();
            this.dgbtn_Sec = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_PersonelBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 538);
            this.panel1.TabIndex = 3;
            // 
            // dgrid_PersonelBilgileri
            // 
            this.dgrid_PersonelBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_PersonelBilgileri.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgrid_PersonelBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_PersonelBilgileri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbtn_Sec});
            this.dgrid_PersonelBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_PersonelBilgileri.GridColor = System.Drawing.Color.LightSalmon;
            this.dgrid_PersonelBilgileri.Location = new System.Drawing.Point(258, 0);
            this.dgrid_PersonelBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_PersonelBilgileri.Name = "dgrid_PersonelBilgileri";
            this.dgrid_PersonelBilgileri.RowHeadersWidth = 51;
            this.dgrid_PersonelBilgileri.RowTemplate.Height = 29;
            this.dgrid_PersonelBilgileri.Size = new System.Drawing.Size(746, 538);
            this.dgrid_PersonelBilgileri.TabIndex = 4;
            this.dgrid_PersonelBilgileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_PersonelBilgileri_CellContentClick);
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
            // ekran_PersonelListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.dgrid_PersonelBilgileri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ekran_PersonelListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ekran_PersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_PersonelBilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrid_PersonelBilgileri;
        private System.Windows.Forms.DataGridViewButtonColumn dgbtn_Sec;
    }
}