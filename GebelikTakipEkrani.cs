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
        String sicilNo;
        int indexId;

        public ekran_GebelikTakip(String sicilNo)
        {
            InitializeComponent();

            this.sicilNo = sicilNo;

            String sqltext = "SELECT Gebelik.id, Gebelik.sonAdetTarihi " + 
            "FROM Gebelik " + 
            "INNER JOIN Personel ON Gebelik.personelId = Personel.id " +
            "WHERE Personel.sicilNo = " + sicilNo + " " +
            "ORDER BY id DESC";

            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqltext);

            try
            {
                indexId = (int)dt.Rows[0]["id"];
                this.lbl_sonAdetTarihi.Text = dt.Rows[0]["sonAdetTarihi"].ToString();
            }
            catch (Exception ex)
            {
                btn_degerEkle.Enabled = false;
            }
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
            Form form = new ekran_GebelikDegerleriEkleme(sicilNo);
            form.ShowDialog();
            updateDataGridView();
        }
    }
}
