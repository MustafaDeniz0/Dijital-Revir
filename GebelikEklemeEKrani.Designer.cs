
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sicilNo = new System.Windows.Forms.Label();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.dtp_Regl = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.Location = new System.Drawing.Point(492, 146);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(172, 34);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "GEBELİK EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // tbx_sicilNo
            // 
            this.tbx_sicilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sicilNo.Location = new System.Drawing.Point(247, 43);
            this.tbx_sicilNo.Name = "tbx_sicilNo";
            this.tbx_sicilNo.Size = new System.Drawing.Size(239, 30);
            this.tbx_sicilNo.TabIndex = 6;
            // 
            // lbl_AtesOlcumDegeri
            // 
            this.lbl_AtesOlcumDegeri.AutoSize = true;
            this.lbl_AtesOlcumDegeri.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_AtesOlcumDegeri.Location = new System.Drawing.Point(125, 41);
            this.lbl_AtesOlcumDegeri.Name = "lbl_AtesOlcumDegeri";
            this.lbl_AtesOlcumDegeri.Size = new System.Drawing.Size(116, 32);
            this.lbl_AtesOlcumDegeri.TabIndex = 5;
            this.lbl_AtesOlcumDegeri.Text = "Sicil No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Son Regl Tarihi :";
            // 
            // lbl_sicilNo
            // 
            this.lbl_sicilNo.AutoSize = true;
            this.lbl_sicilNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicilNo.Location = new System.Drawing.Point(244, 96);
            this.lbl_sicilNo.Name = "lbl_sicilNo";
            this.lbl_sicilNo.Size = new System.Drawing.Size(0, 27);
            this.lbl_sicilNo.TabIndex = 10;
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Sorgula.Location = new System.Drawing.Point(492, 43);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(172, 32);
            this.btn_Sorgula.TabIndex = 23;
            this.btn_Sorgula.Text = "PERSONEL SORGULA";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // dtp_Regl
            // 
            this.dtp_Regl.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_Regl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_Regl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Regl.Location = new System.Drawing.Point(247, 146);
            this.dtp_Regl.Name = "dtp_Regl";
            this.dtp_Regl.Size = new System.Drawing.Size(237, 34);
            this.dtp_Regl.TabIndex = 24;
            // 
            // ekran_GebelikEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 258);
            this.Controls.Add(this.dtp_Regl);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.lbl_sicilNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tbx_sicilNo);
            this.Controls.Add(this.lbl_AtesOlcumDegeri);
            this.Name = "ekran_GebelikEklemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gebelik Ekleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox tbx_sicilNo;
        private System.Windows.Forms.Label lbl_AtesOlcumDegeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sicilNo;
        private System.Windows.Forms.Button btn_Sorgula;
        private System.Windows.Forms.DateTimePicker dtp_Regl;
    }
}