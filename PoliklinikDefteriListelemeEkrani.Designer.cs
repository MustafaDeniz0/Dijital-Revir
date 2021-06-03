
namespace Dijital_Revir
{
    partial class ekran_PoliklinikDefteriListeleme
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Filtrele = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanıGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btn_ekle);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.btn_Filtrele);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1004, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 673);
            this.panel2.TabIndex = 11;
            // 
            // btn_ekle
            // 
            this.btn_ekle.AutoEllipsis = true;
            this.btn_ekle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ekle.Location = new System.Drawing.Point(25, 414);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(220, 65);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 185);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 31);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Tanı Grubu";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Filtrele
            // 
            this.btn_Filtrele.AutoEllipsis = true;
            this.btn_Filtrele.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Filtrele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Filtrele.Location = new System.Drawing.Point(25, 313);
            this.btn_Filtrele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Filtrele.Name = "btn_Filtrele";
            this.btn_Filtrele.Size = new System.Drawing.Size(220, 65);
            this.btn_Filtrele.TabIndex = 6;
            this.btn_Filtrele.Text = "Filtrele";
            this.btn_Filtrele.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 249);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 31);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Sicil No";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Ad Soyad";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Sıra No";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siraNo,
            this.sicil,
            this.adiSoyadi,
            this.tanıGrubu,
            this.button});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Salmon;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(746, 673);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siraNo
            // 
            this.siraNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siraNo.HeaderText = "Sıra No";
            this.siraNo.MinimumWidth = 6;
            this.siraNo.Name = "siraNo";
            this.siraNo.ReadOnly = true;
            // 
            // sicil
            // 
            this.sicil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sicil.HeaderText = "Sicil No";
            this.sicil.MinimumWidth = 6;
            this.sicil.Name = "sicil";
            this.sicil.ReadOnly = true;
            // 
            // adiSoyadi
            // 
            this.adiSoyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adiSoyadi.HeaderText = "Adı Soyadı";
            this.adiSoyadi.MinimumWidth = 6;
            this.adiSoyadi.Name = "adiSoyadi";
            this.adiSoyadi.ReadOnly = true;
            // 
            // tanıGrubu
            // 
            this.tanıGrubu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanıGrubu.HeaderText = "Tanı Grubu";
            this.tanıGrubu.MinimumWidth = 6;
            this.tanıGrubu.Name = "tanıGrubu";
            this.tanıGrubu.ReadOnly = true;
            // 
            // button
            // 
            this.button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.button.HeaderText = "";
            this.button.MinimumWidth = 6;
            this.button.Name = "button";
            this.button.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 673);
            this.panel3.TabIndex = 14;
            // 
            // ekran_PoliklinikDefteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ekran_PoliklinikDefteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik Defteri Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_Filtrele;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn siraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicil;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanıGrubu;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.Panel panel3;
    }
}