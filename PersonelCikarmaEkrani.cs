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
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sil(object sender, EventArgs e)
        {
            String sqlText = "Exec Personel_SIL " + indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            MessageBox.Show("Personel Silindi.");
            
            this.Close();
        }
    }
}
