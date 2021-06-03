
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Muayene = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 673);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 673);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Muayene);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 673);
            this.panel3.TabIndex = 6;
            // 
            // btn_Muayene
            // 
            this.btn_Muayene.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Muayene.AutoEllipsis = true;
            this.btn_Muayene.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Muayene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Muayene.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Muayene.ForeColor = System.Drawing.Color.Black;
            this.btn_Muayene.Location = new System.Drawing.Point(301, 531);
            this.btn_Muayene.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Muayene.Name = "btn_Muayene";
            this.btn_Muayene.Size = new System.Drawing.Size(146, 66);
            this.btn_Muayene.TabIndex = 11;
            this.btn_Muayene.Text = "Muayene Ekle";
            this.btn_Muayene.UseVisualStyleBackColor = false;
            this.btn_Muayene.Click += new System.EventHandler(this.btn_Muayene_Click_1);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Location = new System.Drawing.Point(99, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 388);
            this.panel4.TabIndex = 10;
            // 
            // ekran_IsbMuayeneEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ekran_IsbMuayeneEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB Muayene Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Muayene;
        private System.Windows.Forms.Panel panel4;
    }
}