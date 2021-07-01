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
    public partial class ekran_MuayeneEkleme : Form
    {
        String sicilNo;

        public ekran_MuayeneEkleme(string sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
        }

        private void btn_MuayeneEkleme_Click(object sender, EventArgs e)
        {
            InsertMuayene();   
        }

        private void btn_SevkEt_Click(object sender, EventArgs e)
        {
            Form form = new ekran_SevkEtme(sicilNo);
            form.ShowDialog();
            InsertMuayene();           
        }
        private void InsertMuayene()
        {
            string sqlText;
            DateTime date = DateTime.Today;

            sqlText = "INSERT INTO Muayene (tarih, sikayet, tanı, tedavi, doktor) " +
            "VALUES ('" + date.Year + "-" + date.Month + "-" + date.Day + "','" + tbx_sikayet.Text + "','" + tbx_tani.Text + "','" + tbx_tedavi.Text + "','" + tbx_doktor.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "SELECT TOP 1 * FROM Muayene ORDER BY id DESC";
            DataTable dtMuayene = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "SELECT * FROM  Personel WHERE Personel.sicilNo = " + sicilNo;
            DataTable dtPersonel = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "INSERT INTO ISB (PersonelId, muayeneId) " +
            "VALUES (" + dtPersonel.Rows[0]["id"] + "," + dtMuayene.Rows[0]["id"] + ")";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
           
            Form form = new ekran_PoliklinikEkleme();
            form.ShowDialog();
            this.Close();

        }
    }
}
