
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_sorgula = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_sicilNo
            // 
            this.tbx_sicilNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_sicilNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sicilNo.Location = new System.Drawing.Point(165, 54);
            this.tbx_sicilNo.Name = "tbx_sicilNo";
            this.tbx_sicilNo.Size = new System.Drawing.Size(267, 34);
            this.tbx_sicilNo.TabIndex = 3;
            // 
            // lbl_sicilNo
            // 
            this.lbl_sicilNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sicilNo.AutoSize = true;
            this.lbl_sicilNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicilNo.Location = new System.Drawing.Point(60, 61);
            this.lbl_sicilNo.Name = "lbl_sicilNo";
            this.lbl_sicilNo.Size = new System.Drawing.Size(99, 27);
            this.lbl_sicilNo.TabIndex = 2;
            this.lbl_sicilNo.Text = "Sicil No : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(452, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_sorgula
            // 
            this.lbl_sorgula.AutoSize = true;
            this.lbl_sorgula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sorgula.Location = new System.Drawing.Point(165, 120);
            this.lbl_sorgula.Name = "lbl_sorgula";
            this.lbl_sorgula.Size = new System.Drawing.Size(0, 27);
            this.lbl_sorgula.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(233, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ekran_PersonelCikarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_sorgula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_sicilNo);
            this.Controls.Add(this.lbl_sicilNo);
            this.Name = "ekran_PersonelCikarma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelCikarmaEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_sicilNo;
        private System.Windows.Forms.Label lbl_sicilNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_sorgula;
        private System.Windows.Forms.Button button2;
    }
}