
namespace Dijital_Revir
{
    partial class ekran_TestEklemeEkrani
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
            this.tbx_TestTuru = new System.Windows.Forms.TextBox();
            this.lbl_AtesOlcumDegeri = new System.Windows.Forms.Label();
            this.tbx_TestSonucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(421, 249);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 40);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // tbx_TestTuru
            // 
            this.tbx_TestTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_TestTuru.Location = new System.Drawing.Point(282, 108);
            this.tbx_TestTuru.Name = "tbx_TestTuru";
            this.tbx_TestTuru.Size = new System.Drawing.Size(239, 30);
            this.tbx_TestTuru.TabIndex = 6;
            // 
            // lbl_AtesOlcumDegeri
            // 
            this.lbl_AtesOlcumDegeri.AutoSize = true;
            this.lbl_AtesOlcumDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AtesOlcumDegeri.Location = new System.Drawing.Point(61, 108);
            this.lbl_AtesOlcumDegeri.Name = "lbl_AtesOlcumDegeri";
            this.lbl_AtesOlcumDegeri.Size = new System.Drawing.Size(125, 25);
            this.lbl_AtesOlcumDegeri.TabIndex = 5;
            this.lbl_AtesOlcumDegeri.Text = "Test Türü : ";
            // 
            // tbx_TestSonucu
            // 
            this.tbx_TestSonucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_TestSonucu.Location = new System.Drawing.Point(282, 182);
            this.tbx_TestSonucu.Name = "tbx_TestSonucu";
            this.tbx_TestSonucu.Size = new System.Drawing.Size(239, 30);
            this.tbx_TestSonucu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Test Sonucu : ";
            // 
            // ekran_TestEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.tbx_TestSonucu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tbx_TestTuru);
            this.Controls.Add(this.lbl_AtesOlcumDegeri);
            this.Name = "ekran_TestEklemeEkrani";
            this.Text = "TestEklemeEkrani";
            this.Load += new System.EventHandler(this.TestEklemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox tbx_TestTuru;
        private System.Windows.Forms.Label lbl_AtesOlcumDegeri;
        private System.Windows.Forms.TextBox tbx_TestSonucu;
        private System.Windows.Forms.Label label1;
    }
}