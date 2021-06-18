
namespace Dijital_Revir
{
    partial class ekran_PersonelIslemleri
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
            this.btn_PersonelEkle = new System.Windows.Forms.Button();
            this.btn_PersonelCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PersonelEkle
            // 
            this.btn_PersonelEkle.BackColor = System.Drawing.Color.LightGray;
            this.btn_PersonelEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_PersonelEkle.Location = new System.Drawing.Point(91, 90);
            this.btn_PersonelEkle.Name = "btn_PersonelEkle";
            this.btn_PersonelEkle.Size = new System.Drawing.Size(151, 70);
            this.btn_PersonelEkle.TabIndex = 7;
            this.btn_PersonelEkle.Text = "Personel Ekle";
            this.btn_PersonelEkle.UseVisualStyleBackColor = false;
            this.btn_PersonelEkle.Click += new System.EventHandler(this.btn_PersonelEkle_Click);
            // 
            // btn_PersonelCikar
            // 
            this.btn_PersonelCikar.BackColor = System.Drawing.Color.LightGray;
            this.btn_PersonelCikar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_PersonelCikar.Location = new System.Drawing.Point(266, 90);
            this.btn_PersonelCikar.Name = "btn_PersonelCikar";
            this.btn_PersonelCikar.Size = new System.Drawing.Size(151, 70);
            this.btn_PersonelCikar.TabIndex = 8;
            this.btn_PersonelCikar.Text = "Personel Çıkar";
            this.btn_PersonelCikar.UseVisualStyleBackColor = false;
            this.btn_PersonelCikar.Click += new System.EventHandler(this.btn_PersonelCikar_Click);
            // 
            // ekran_PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 251);
            this.Controls.Add(this.btn_PersonelCikar);
            this.Controls.Add(this.btn_PersonelEkle);
            this.Name = "ekran_PersonelIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PersonelEkle;
        private System.Windows.Forms.Button btn_PersonelCikar;
    }
}