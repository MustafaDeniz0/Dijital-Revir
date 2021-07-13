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
            this.indexId = indexId;
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

            sqlText = "SELECT Gebelik.sonAdetTarihi " +
            "FROM Gebelik " +
            "INNER JOIN Personel ON Gebelik.personelId = Personel.id " +
            "WHERE Gebelik.id = " + indexId;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            this.lbl_sonAdetTarihi.Text = dt.Rows[0]["sonAdetTarihi"].ToString().Substring(0,10);
        }

        private void btn_degerEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikDegerleriEkleme(indexId);
            form.ShowDialog();
            updateDataGridView();
        }

        private void btn_gebelikSonlandır_Click(object sender, EventArgs e)
        {
            String mesaj = "Gebelik Sonlandırılsın mı?";
            String baslik = "";
            MessageBoxButtons butonlar = MessageBoxButtons.YesNo;
            DialogResult sonuc = MessageBox.Show(mesaj, baslik, butonlar);

            if (sonuc == DialogResult.Yes)
            {
                String sqlText = "Update Gebelik Set Gebemi = 0 " +
                "Where Gebelik.id = " + indexId;
                SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

                sqlText = "Delete From GebelikFormDegeri " +
                "Where GebelikFormDegeri.gebelikId in (Select Gebelik.id From Gebelik Where Gebelik.Gebemi = 0) " +
                "Delete From Gebelik " +
                "Where Gebelik.Gebemi = 0";
                SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

                this.Close();
            }
        }
    }
}
