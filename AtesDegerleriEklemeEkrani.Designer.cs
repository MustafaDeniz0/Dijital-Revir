
namespace Dijital_Revir
{
    partial class ekran_AtesDegerleriEklemeEkrani
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
            this.lbl_AtesOlcumTarihi = new System.Windows.Forms.Label();
            this.lbl_AtesOlcumDegeri = new System.Windows.Forms.Label();
            this.tbx_InputAtesOlcumDegeri = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dtp_AtesOlcumTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_AtesOlcumTarihi
            // 
            this.lbl_AtesOlcumTarihi.AutoSize = true;
            this.lbl_AtesOlcumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AtesOlcumTarihi.Location = new System.Drawing.Point(38, 49);
            this.lbl_AtesOlcumTarihi.Name = "lbl_AtesOlcumTarihi";
            this.lbl_AtesOlcumTarihi.Size = new System.Drawing.Size(192, 25);
            this.lbl_AtesOlcumTarihi.TabIndex = 0;
            this.lbl_AtesOlcumTarihi.Text = "Ateş Ölçüm Tarihi:";
            // 
            // lbl_AtesOlcumDegeri
            // 
            this.lbl_AtesOlcumDegeri.AutoSize = true;
            this.lbl_AtesOlcumDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AtesOlcumDegeri.Location = new System.Drawing.Point(30, 122);
            this.lbl_AtesOlcumDegeri.Name = "lbl_AtesOlcumDegeri";
            this.lbl_AtesOlcumDegeri.Size = new System.Drawing.Size(200, 25);
            this.lbl_AtesOlcumDegeri.TabIndex = 1;
            this.lbl_AtesOlcumDegeri.Text = "Ateş Ölçüm Değeri:";
            // 
            // tbx_InputAtesOlcumDegeri
            // 
            this.tbx_InputAtesOlcumDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_InputAtesOlcumDegeri.Location = new System.Drawing.Point(252, 117);
            this.tbx_InputAtesOlcumDegeri.Name = "tbx_InputAtesOlcumDegeri";
            this.tbx_InputAtesOlcumDegeri.Size = new System.Drawing.Size(239, 30);
            this.tbx_InputAtesOlcumDegeri.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(391, 182);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 40);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dtp_AtesOlcumTarihi
            // 
            this.dtp_AtesOlcumTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_AtesOlcumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_AtesOlcumTarihi.Location = new System.Drawing.Point(252, 52);
            this.dtp_AtesOlcumTarihi.Name = "dtp_AtesOlcumTarihi";
            this.dtp_AtesOlcumTarihi.Size = new System.Drawing.Size(239, 22);
            this.dtp_AtesOlcumTarihi.TabIndex = 5;
            // 
            // ekran_AtesDegerleriEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.dtp_AtesOlcumTarihi);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tbx_InputAtesOlcumDegeri);
            this.Controls.Add(this.lbl_AtesOlcumDegeri);
            this.Controls.Add(this.lbl_AtesOlcumTarihi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ekran_AtesDegerleriEklemeEkrani";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtesDegerleriEklemeEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AtesOlcumTarihi;
        private System.Windows.Forms.Label lbl_AtesOlcumDegeri;
        private System.Windows.Forms.TextBox tbx_InputAtesOlcumDegeri;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DateTimePicker dtp_AtesOlcumTarihi;
    }
}