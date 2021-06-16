using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijital_Revir
{
    public partial class ekran_CovidEkleme : Form
    {
        String sicilNo;
        public ekran_CovidEkleme()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlText = "Select *From (Personel inner join OzlukBilgileri on OzlukBilgileri.id = Personel.ozlukId) where Personel.sicilNo = " + tbx_SicilNo.Text;
                DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                lbl_Sorgula.Text = dt.Rows[0]["ad"] + " " + dt.Rows[0]["soyAd"];
                sicilNo = tbx_SicilNo.Text;
                this.Update();
            }
            catch(Exception ex)
            {
                lbl_Sorgula.Text = "Personel Bulunamadı. ";
            }
            
        }

        private void btn_covidEkle_Click(object sender, EventArgs e)
        {
            String sqlText = "INSERT INTO [dbo].[Covid] ([personelId],[kayitDurumu],[statu],[sirketFormul],[kod],[vakaDurumu],[bulgu],[ilac],[raporSuresi],[raporTarihi],[isBasiTarihi],[iletisimDurumu],[atesDurumu]) " +
                                "Values((Select Personel.id From Personel Where Personel.sicilNo = '" + tbx_SicilNo.Text + "'),'" + tbx_kayitDurumu.Text + "' ,'"+tbx_statu.Text+"','"+tbx_sirketFormul.Text+"','"+tbx_kod.Text+"','"+tbx_vakaDurumu.Text+"','"+tbx_bulgu.Text+"','"+tbx_ilac.Text+"','"+tbx_raporSuresi.Text+"','"+tbx_raporTarihi.Text+"','"+tbx_isBası.Text+"','"+tbx_iletisimDurumu.Text+"','"+tbx_atesDurumu.Text+"');";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            this.Close();
            Form.ActiveForm.Update();
        }
    }
}
