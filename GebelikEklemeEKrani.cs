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
    
    public partial class ekran_GebelikEklemeEkrani : Form
    {
        string sicilNo;
        
        public ekran_GebelikEklemeEkrani()
        {
            InitializeComponent();
            

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            String sqlText;

            sqlText = "Insert Into Gebelik (sonAdetTarihi, personelId) values('"+tbx_sonReglTarihi.Text+"',(SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '"+(tbx_sicilNo.Text)+"') )";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            
            this.Close();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlText = "Select *From (Personel inner join OzlukBilgileri on OzlukBilgileri.id = Personel.ozlukId) where Personel.sicilNo = " + tbx_sicilNo.Text;
                DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                lbl_sicilNo.Text = dt.Rows[0]["ad"] + " " + dt.Rows[0]["soyAd"];
                sicilNo = tbx_sicilNo.Text;
                this.Update();
            }
            catch (Exception ex)
            {
                lbl_sicilNo.Text = "Personel Bulunamadı. ";
            }
        }

        private void ekran_GebelikEklemeEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
