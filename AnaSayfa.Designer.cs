
namespace Dijital_Revir
{
	partial class ekran_AnaSayfa
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_PoliklinikDefteri = new System.Windows.Forms.Button();
            this.btn_Covid = new System.Windows.Forms.Button();
            this.btn_IsKazasi = new System.Windows.Forms.Button();
            this.btn_Gebelik = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbx_Bildirimler = new System.Windows.Forms.ListBox();
            this.btn_AraButonu = new System.Windows.Forms.Button();
            this.tbx_AramaCubugu = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 538);
            this.panel2.TabIndex = 1;
            // 
            // btn_PoliklinikDefteri
            // 
            this.btn_PoliklinikDefteri.AutoEllipsis = true;
            this.btn_PoliklinikDefteri.BackColor = System.Drawing.Color.LightGray;
            this.btn_PoliklinikDefteri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_PoliklinikDefteri.Location = new System.Drawing.Point(0, 0);
            this.btn_PoliklinikDefteri.Name = "btn_PoliklinikDefteri";
            this.btn_PoliklinikDefteri.Size = new System.Drawing.Size(258, 70);
            this.btn_PoliklinikDefteri.TabIndex = 2;
            this.btn_PoliklinikDefteri.Text = "Poliklinik Defteri";
            this.btn_PoliklinikDefteri.UseVisualStyleBackColor = false;
            this.btn_PoliklinikDefteri.Click += new System.EventHandler(this.btn_PoliklinikDefteri_Click);
            // 
            // btn_Covid
            // 
            this.btn_Covid.BackColor = System.Drawing.Color.LightGray;
            this.btn_Covid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Covid.Location = new System.Drawing.Point(0, 69);
            this.btn_Covid.Name = "btn_Covid";
            this.btn_Covid.Size = new System.Drawing.Size(258, 70);
            this.btn_Covid.TabIndex = 3;
            this.btn_Covid.Text = "Covid";
            this.btn_Covid.UseVisualStyleBackColor = false;
            this.btn_Covid.Click += new System.EventHandler(this.btn_Covid_Click);
            // 
            // btn_IsKazasi
            // 
            this.btn_IsKazasi.BackColor = System.Drawing.Color.LightGray;
            this.btn_IsKazasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_IsKazasi.Location = new System.Drawing.Point(0, 138);
            this.btn_IsKazasi.Name = "btn_IsKazasi";
            this.btn_IsKazasi.Size = new System.Drawing.Size(258, 70);
            this.btn_IsKazasi.TabIndex = 4;
            this.btn_IsKazasi.Text = "İş Kazası";
            this.btn_IsKazasi.UseVisualStyleBackColor = false;
            this.btn_IsKazasi.Click += new System.EventHandler(this.btn_IsKazasi_Click);
            // 
            // btn_Gebelik
            // 
            this.btn_Gebelik.BackColor = System.Drawing.Color.LightGray;
            this.btn_Gebelik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Gebelik.Location = new System.Drawing.Point(0, 207);
            this.btn_Gebelik.Name = "btn_Gebelik";
            this.btn_Gebelik.Size = new System.Drawing.Size(258, 70);
            this.btn_Gebelik.TabIndex = 5;
            this.btn_Gebelik.Text = "Gebelik";
            this.btn_Gebelik.UseVisualStyleBackColor = false;
            this.btn_Gebelik.Click += new System.EventHandler(this.btn_Gebelik_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btn_PoliklinikDefteri);
            this.panel4.Controls.Add(this.btn_Covid);
            this.panel4.Controls.Add(this.btn_Gebelik);
            this.panel4.Controls.Add(this.btn_IsKazasi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 538);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbx_Bildirimler);
            this.panel1.Controls.Add(this.btn_AraButonu);
            this.panel1.Controls.Add(this.tbx_AramaCubugu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(258, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 538);
            this.panel1.TabIndex = 5;
            // 
            // lbx_Bildirimler
            // 
            this.lbx_Bildirimler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbx_Bildirimler.FormattingEnabled = true;
            this.lbx_Bildirimler.ItemHeight = 16;
            this.lbx_Bildirimler.Location = new System.Drawing.Point(24, 142);
            this.lbx_Bildirimler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbx_Bildirimler.Name = "lbx_Bildirimler";
            this.lbx_Bildirimler.Size = new System.Drawing.Size(707, 372);
            this.lbx_Bildirimler.TabIndex = 9;
            // 
            // btn_AraButonu
            // 
            this.btn_AraButonu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_AraButonu.AutoEllipsis = true;
            this.btn_AraButonu.BackColor = System.Drawing.Color.White;
            this.btn_AraButonu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AraButonu.Location = new System.Drawing.Point(592, 30);
            this.btn_AraButonu.Name = "btn_AraButonu";
            this.btn_AraButonu.Size = new System.Drawing.Size(139, 52);
            this.btn_AraButonu.TabIndex = 8;
            this.btn_AraButonu.Text = "Personel Ara";
            this.btn_AraButonu.UseVisualStyleBackColor = false;
            this.btn_AraButonu.Click += new System.EventHandler(this.btn_AraButonu_Click_1);
            // 
            // tbx_AramaCubugu
            // 
            this.tbx_AramaCubugu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_AramaCubugu.Location = new System.Drawing.Point(24, 30);
            this.tbx_AramaCubugu.Multiline = true;
            this.tbx_AramaCubugu.Name = "tbx_AramaCubugu";
            this.tbx_AramaCubugu.Size = new System.Drawing.Size(544, 52);
            this.tbx_AramaCubugu.TabIndex = 7;
            this.tbx_AramaCubugu.Text = "Sicil No ya da İsim Giriniz.";
            this.tbx_AramaCubugu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_AramaCubugu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_AramaCubugu_MouseClick);
            this.tbx_AramaCubugu.TextChanged += new System.EventHandler(this.tbx_AramaCubugu_TextChanged);
            // 
            // ekran_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ekran_AnaSayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijital Revir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_PoliklinikDefteri;
        private System.Windows.Forms.Button btn_Covid;
        private System.Windows.Forms.Button btn_IsKazasi;
        private System.Windows.Forms.Button btn_Gebelik;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbx_Bildirimler;
        private System.Windows.Forms.Button btn_AraButonu;
        private System.Windows.Forms.TextBox tbx_AramaCubugu;
    }
}

