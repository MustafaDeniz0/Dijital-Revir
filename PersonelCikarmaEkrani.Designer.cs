
namespace Dijital_Revir
{
    partial class ekran_PersonelCikarma
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
            this.tbx_sicilNo = new System.Windows.Forms.TextBox();
            this.lbl_sicilNo = new System.Windows.Forms.Label();
            this.lbl_Sorgula = new System.Windows.Forms.Label();
            this.btn_PersonelSil = new System.Windows.Forms.Button();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_sicilNo
            // 
            this.tbx_sicilNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_sicilNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sicilNo.Location = new System.Drawing.Point(151, 52);
            this.tbx_sicilNo.Name = "tbx_sicilNo";
            this.tbx_sicilNo.Size = new System.Drawing.Size(267, 34);
            this.tbx_sicilNo.TabIndex = 3;
            // 
            // lbl_sicilNo
            // 
            this.lbl_sicilNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sicilNo.AutoSize = true;
            this.lbl_sicilNo.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicilNo.Location = new System.Drawing.Point(26, 52);
            this.lbl_sicilNo.Name = "lbl_sicilNo";
            this.lbl_sicilNo.Size = new System.Drawing.Size(119, 32);
            this.lbl_sicilNo.TabIndex = 2;
            this.lbl_sicilNo.Text = "Sicil No : ";
            // 
            // lbl_Sorgula
            // 
            this.lbl_Sorgula.AutoSize = true;
            this.lbl_Sorgula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sorgula.Location = new System.Drawing.Point(157, 98);
            this.lbl_Sorgula.Name = "lbl_Sorgula";
            this.lbl_Sorgula.Size = new System.Drawing.Size(0, 27);
            this.lbl_Sorgula.TabIndex = 5;
            // 
            // btn_PersonelSil
            // 
            this.btn_PersonelSil.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PersonelSil.Location = new System.Drawing.Point(434, 98);
            this.btn_PersonelSil.Name = "btn_PersonelSil";
            this.btn_PersonelSil.Size = new System.Drawing.Size(104, 34);
            this.btn_PersonelSil.TabIndex = 6;
            this.btn_PersonelSil.Text = "Sil";
            this.btn_PersonelSil.UseVisualStyleBackColor = true;
            this.btn_PersonelSil.Click += new System.EventHandler(this.btn_Sil);
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sorgula.Location = new System.Drawing.Point(434, 52);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(104, 34);
            this.btn_Sorgula.TabIndex = 7;
            this.btn_Sorgula.Text = "Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // ekran_PersonelCikarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 182);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.btn_PersonelSil);
            this.Controls.Add(this.lbl_Sorgula);
            this.Controls.Add(this.tbx_sicilNo);
            this.Controls.Add(this.lbl_sicilNo);
            this.Name = "ekran_PersonelCikarma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Çıkarma Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_sicilNo;
        private System.Windows.Forms.Label lbl_sicilNo;
        private System.Windows.Forms.Label lbl_Sorgula;
        private System.Windows.Forms.Button btn_PersonelSil;
        private System.Windows.Forms.Button btn_Sorgula;
    }
}