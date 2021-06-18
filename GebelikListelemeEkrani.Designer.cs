
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
            this.btn_GebelikEkle = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 538);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_GebelikEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 8;
            // 
            // btn_GebelikEkle
            // 
            this.btn_GebelikEkle.AutoEllipsis = true;
            this.btn_GebelikEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GebelikEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GebelikEkle.Location = new System.Drawing.Point(25, 343);
            this.btn_GebelikEkle.Name = "btn_GebelikEkle";
            this.btn_GebelikEkle.Size = new System.Drawing.Size(220, 52);
            this.btn_GebelikEkle.TabIndex = 10;
            this.btn_GebelikEkle.Text = "Ekle";
            this.btn_GebelikEkle.UseVisualStyleBackColor = false;
            this.btn_GebelikEkle.Click += new System.EventHandler(this.btn_GebelikEkle_Click);
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
            this.dgv_gebelikListesi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dgv_gebelikListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gebelikListesi_CellContentClick);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gebelikListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_gebelikListesi;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.Button btn_GebelikEkle;
    }
}