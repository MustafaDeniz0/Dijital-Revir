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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlText = "Select *From (Personel inner join OzlukBilgileri on OzlukBilgileri.id = Personel.ozlukId) where Personel.sicilNo = " + tbx_sicilNo.Text;

                DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                lbl_sorgula.Text = dt.Rows[0]["ad"] + " " + dt.Rows[0]["soyAd"];
                sicilNo = tbx_sicilNo.Text;
                sqlText = "select Personel.id from Personel where Personel.sicilNo = '"+sicilNo+"'"; 
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                indexId = (int)dt.Rows[0]["id"];
            }
            catch (Exception ex)
            {
                lbl_sorgula.Text = "Personel Bulunamadı. ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlText = "delete from Personel where Personel.id = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete OzlukBilgileri from OzlukBilgileri left join Personel on Personel.ozlukId = OzlukBilgileri.id where Personel.id = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from HastaSevk where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from Poliklinik where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from Ek2 where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from Asi where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from Etiket where personalId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from IsKazası where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection()); 
            sqlText = "delete from Ek2 where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete Ates from Ates left join Covid on Covid.id = Ates.covidId where Covid.personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete Test from Test left join Covid on Covid.id = Test.covidId where Covid.personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from Covid where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete GebelikFormDegeri from GebelikFormDegeri left join Gebelik on Gebelik.id = GebelikFormDegeri.gebelikId where Gebelik.personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from Gebelik where personelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete Muayene from Muayene left join ISB on Muayene.id = ISB.muayeneId where ISB.PersonelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "delete from ISB where PersonelId = " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            MessageBox.Show("Personel Silindi ");
            this.Close();

        }
    }
}
