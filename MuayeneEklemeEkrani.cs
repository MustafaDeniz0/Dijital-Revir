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
        String sicil;
        public ekran_MuayeneEkleme(string sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_MuayeneEkleme_Click(object sender, EventArgs e)
        {
            string sqlText;
            DateTime date = DateTime.Today;

            sqlText = "Insert Into Muayene(tarih, sikayet, tanı, tedavi, doktor) " +
            "Values('" + date.Year + "-" + date.Month + "-" + date.Day + "','" + tbx_sikayet.Text + "','" + tbx_tani.Text + "','" + tbx_tedavi.Text + "','" + tbx_doktor.Text + "');";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "SELECT Top 1 * FROM Muayene ORDER BY id DESC ;";
            DataTable dtMuayene = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "SELECT * FROM  Personel WHERE Personel.sicilNo = " + sicil + ";";
            DataTable dtPersonel = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "Insert Into ISB(PersonelId, muayeneId) " +
            "Values(" + dtPersonel.Rows[0]["id"] + "," + dtMuayene.Rows[0]["id"] + ");";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            this.Close();
        }

        private void lbl_Sikayet_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ekran_SevkEtme();
            form.ShowDialog();
        }
    }
}
