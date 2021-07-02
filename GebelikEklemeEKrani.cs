using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            sqlText = "INSERT INTO Gebelik (sonAdetTarihi, personelId, Gebemi) " +
             "VALUES ('" + SqlOps.SqlDateInsert(dtp_Regl.Value,"00:00") + "', (SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + tbx_sicilNo.Text + "'), 1)";
             SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
             MessageBox.Show("Gebelik Eklendi");
   
            this.Close();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;
            //try { 
            sqlText = "SELECT * FROM (Personel INNER JOIN OzlukBilgileri ON OzlukBilgileri.id = Personel.ozlukId) " +
            "WHERE Personel.sicilNo = " + tbx_sicilNo.Text;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            lbl_sicilNo.Text = dt.Rows[0]["ad"] + " " + dt.Rows[0]["soyAd"];
            sicilNo = tbx_sicilNo.Text;

                //sqlText = "Select @param1 = OzlukBilgileri.cinsiyet From OzlukBilgileri inner join Personel on Personel.ozlukId = OzlukBilgileri.id Where Personel.sicilNo ='" + sicilNo + "'";
                //if ((bool)(SqlOps.SqlExecute(sqlText, "param1", SqlOps.GetSqlConnection()).Value))
                //{
                //    btn_Ekle.Enabled = false;
                //}
                //else
                //{
                //    btn_Ekle.Enabled = true;
                //}
            sqlText = "Select  OzlukBilgileri.cinsiyet From OzlukBilgileri inner join Personel on Personel.ozlukId = OzlukBilgileri.id Where Personel.sicilNo ='" + sicilNo + "'";             
            if ((bool)SqlOps.CreateDataTableBySqlQuery(sqlText).Rows[0]["cinsiyet"]) { btn_Ekle.Enabled = false; }
            else { btn_Ekle.Enabled = true; }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
