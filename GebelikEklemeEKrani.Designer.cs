
namespace Dijital_Revir
{
    partial class ekran_GebelikEklemeEkrani
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.tbx_sicilNo = new System.Windows.Forms.TextBox();
            this.lbl_AtesOlcumDegeri = new System.Windows.Forms.Label();
            this.tbx_sonReglTarihi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sicilNo = new System.Windows.Forms.Label();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(335, 246);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 40);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // tbx_sicilNo
            // 
            this.tbx_sicilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sicilNo.Location = new System.Drawing.Point(271, 80);
            this.tbx_sicilNo.Name = "tbx_sicilNo";
            this.tbx_sicilNo.Size = new System.Drawing.Size(239, 30);
            this.tbx_sicilNo.TabIndex = 6;
            // 
            // lbl_AtesOlcumDegeri
            // 
            this.lbl_AtesOlcumDegeri.AutoSize = true;
            this.lbl_AtesOlcumDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AtesOlcumDegeri.Location = new System.Drawing.Point(166, 80);
            this.lbl_AtesOlcumDegeri.Name = "lbl_AtesOlcumDegeri";
            this.lbl_AtesOlcumDegeri.Size = new System.Drawing.Size(99, 25);
            this.lbl_AtesOlcumDegeri.TabIndex = 5;
            this.lbl_AtesOlcumDegeri.Text = "Sicil No :";
            // 
            // tbx_sonReglTarihi
            // 
            this.tbx_sonReglTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sonReglTarihi.Location = new System.Drawing.Point(271, 175);
            this.tbx_sonReglTarihi.Name = "tbx_sonReglTarihi";
            this.tbx_sonReglTarihi.Size = new System.Drawing.Size(239, 30);
            this.tbx_sonReglTarihi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Son Regl Tarihi :";
            // 
            // lbl_sicilNo
            // 
            this.lbl_sicilNo.AutoSize = true;
            this.lbl_sicilNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicilNo.Location = new System.Drawing.Point(268, 133);
            this.lbl_sicilNo.Name = "lbl_sicilNo";
            this.lbl_sicilNo.Size = new System.Drawing.Size(0, 27);
            this.lbl_sicilNo.TabIndex = 10;
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Location = new System.Drawing.Point(522, 78);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(109, 34);
            this.btn_Sorgula.TabIndex = 23;
            this.btn_Sorgula.Text = "Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // ekran_GebelikEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 363);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.lbl_sicilNo);
            this.Controls.Add(this.tbx_sonReglTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tbx_sicilNo);
            this.Controls.Add(this.lbl_AtesOlcumDegeri);
            this.Name = "ekran_GebelikEklemeEkrani";
            this.Text = "Gebelik Ekleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox tbx_sicilNo;
        private System.Windows.Forms.Label lbl_AtesOlcumDegeri;
        private System.Windows.Forms.TextBox tbx_sonReglTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sicilNo;
        private System.Windows.Forms.Button btn_Sorgula;
    }
}