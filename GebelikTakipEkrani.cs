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
    public partial class ekran_GebelikTakip : Form
    {
        
       String indexId;

        public ekran_GebelikTakip(String indexId)
        {
            InitializeComponent();

            //this.sicilNo = sicilNo;

            //String sqltext = "SELECT Gebelik.id, Gebelik.sonAdetTarihi " + 
            //"FROM Gebelik " + 
            //"INNER JOIN Personel ON Gebelik.personelId = Personel.id " +
            //"WHERE Personel.sicilNo = " + sicilNo + " " +
            //"ORDER BY id DESC";
            this.indexId = indexId;

            //DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqltext);

            //try
            //{
            //    indexId = (int)dt.Rows[0]["id"];
            //    this.lbl_sonAdetTarihi.Text = dt.Rows[0]["sonAdetTarihi"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    btn_degerEkle.Enabled = false;
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ekran_GebelikTakip_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void updateDataGridView()
        {
            DataTable dt;
            String sqlText;

            sqlText = "SELECT tarih, kiloDegeri, taDegeri, nabızDegeri, hmgDegeri, titDegeri, pretibitalOdem, asiDegeri, ekTetkikDegeri, ilac " + 
            "FROM GebelikFormDegeri " + 
            "WHERE gebelikId = " + indexId + " " +
            "ORDER BY id DESC";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            
            dgv_gebelikTablosu.DataSource = dt;
        }

        private void btn_degerEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikDegerleriEkleme(indexId);
            form.ShowDialog();
            updateDataGridView();
        }

        private void btn_gebelikSonlandır_Click(object sender, EventArgs e)
        {
            String sqlText = "Update Gebelik Set Gebemi = 0 Where Gebelik.id = "+ indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "Delete From GebelikFormDegeri Where GebelikFormDegeri.gebelikId in (Select Gebelik.id From Gebelik Where Gebelik.Gebemi = 0) " +
                      "Delete From Gebelik Where Gebelik.Gebemi = 0";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            this.Close();
        }
    }
}
