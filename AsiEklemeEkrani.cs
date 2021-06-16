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
    public partial class ekran_AsiEkleme : Form
    {
        string sicil; 
        public ekran_AsiEkleme(string sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
        }

        private void btn_asiEkle_Click(object sender, EventArgs e)
        {
            string sqlText;
            int indexId;

            sqlText = "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = " + sicil;
            indexId = (int)SqlOps.CreateDataTableBySqlQuery(sqlText).Rows[0]["id"];

            sqlText = "Insert Into Asi(personelId, ad, kullanımPeriyodu, uygulanmaTarihi) values (" + indexId + ",'"+ tbx_asiAdi.Text + "','" + tbx_kullanimPeriyodu.Text + "','" + tbx_uygulamaTarihi.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            tbx_asiAdi.Clear();
            tbx_kullanimPeriyodu.Clear();
            tbx_uygulamaTarihi.Clear();
            this.Update();
        }

        private void ekran_AsiEkleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;
            int indexId;

            sqlText = "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = " + sicil;
            indexId = (int)SqlOps.CreateDataTableBySqlQuery(sqlText).Rows[0]["id"];

            sqlText = "SELECT Personel.sicilNo, OzlukBilgileri.ad ,OzlukBilgileri.soyAd, Asi.ad, Asi.kullanımPeriyodu, Asi.uygulanmaTarihi " +
                      "FROM ((Personel INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id) " +
                      "INNER JOIN Asi ON Personel.id = Asi.personelId)";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            dgv_asi.DataSource = dt;
        }

        private void ekran_AsiEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
