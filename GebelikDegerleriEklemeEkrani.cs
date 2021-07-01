using System;
using System.Data;
using System.Windows.Forms;

namespace Dijital_Revir
{
    public partial class ekran_GebelikDegerleriEkleme : Form
    {
        String sicilNo;
        int indexId;

        public ekran_GebelikDegerleriEkleme(string sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;

            String sqltext = "SELECT Gebelik.id FROM Gebelik " + 
            "INNER JOIN Personel ON Gebelik.personelId = Personel.id " + 
            "WHERE Personel.sicilNo = " + sicilNo + " " + 
            "ORDER BY id DESC";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqltext);
            
            this.indexId = (int)dt.Rows[0]["id"];
        }

        private void btn_GebelikDegerEkleme_Click(object sender, EventArgs e)
        {
            string sqlText = "INSERT INTO GebelikFormDegeri (gebelikId, tarih, kiloDegeri, taDegeri, nabızDegeri, hmgDegeri, titDegeri, pretibitalOdem, asiDegeri, ekTetkikDegeri, ilac) " +
            "VALUES (" + indexId + ", GETDATE(),'" +
            tbx_kilo.Text + "','" +
            tbx_ta.Text + "','" +
            tbx_nabız.Text + "','" +
            tbx_hmg.Text + "','" + 
            tbx_tit.Text + "','" +
            tbx_odem.Text + "','" + 
            tbx_ekTetkik.Text + "','" + 
            tbx_asi.Text + "','" + 
            tbx_verilenİlac.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            MessageBox.Show("Değerler Eklendi.");
            this.Close();
        }
    }
}
