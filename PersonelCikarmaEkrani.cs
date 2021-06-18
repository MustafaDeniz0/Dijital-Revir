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
    public partial class ekran_PersonelCikarma : Form
    {
        string sicilNo;
        int indexId;
        
        public ekran_PersonelCikarma()
        {
            InitializeComponent();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;

            try
            {
                sqlText = "SELECT * FROM Personel " + 
                "INNER JOIN OzlukBilgileri ON OzlukBilgileri.id = Personel.ozlukId " + 
                "WHERE Personel.sicilNo = " + tbx_sicilNo.Text;
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

                lbl_Sorgula.Text = dt.Rows[0]["ad"] + " " + dt.Rows[0]["soyAd"];
                sicilNo = tbx_sicilNo.Text;

                sqlText = "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + sicilNo + "'";
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                indexId = (int)dt.Rows[0]["id"];
            }
            catch (Exception ex)
            {
                lbl_Sorgula.Text = "Personel Bulunamadı.";
            }
        }

        private void btn_Sil(object sender, EventArgs e)
        {
            string sqlText = "DELETE FROM Personel WHERE Personel.id = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE OzlukBilgileri FROM OzlukBilgileri LEFT JOIN Personel ON Personel.ozlukId = OzlukBilgileri.id WHERE Personel.id = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM HastaSevk WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Poliklinik WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Ek2 WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Asi WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Etiket WHERE personalId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM IsKazası WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Ek2 WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE Ates FROM Ates LEFT JOIN Covid ON Covid.id = Ates.covidId WHERE Covid.personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE Test FROM Test LEFT JOIN Covid ON Covid.id = Test.covidId WHERE Covid.personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Covid WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE GebelikFormDegeri FROM GebelikFormDegeri LEFT JOIN Gebelik ON Gebelik.id = GebelikFormDegeri.gebelikId WHERE Gebelik.personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM Gebelik WHERE personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE Muayene FROM Muayene LEFT JOIN ISB on Muayene.id = ISB.muayeneId WHERE ISB.PersonelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "DELETE FROM ISB WHERE PersonelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            MessageBox.Show("Personel Silindi.");
            
            this.Close();
        }
    }
}
