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

            String sqltext = "SELECT Gebelik.id " + 
            "FROM Gebelik LEFT JOIN Personel ON Gebelik.personelId = Personel.id " +
            "WHERE Personel.sicilNo = " + sicilNo + " " +
            "ORDER BY id DESC";

            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqltext);
            indexId = (int)dt.Rows[0]["id"];
        }

        private void ekran_GebelikTakip_Load(object sender, EventArgs e)
        {            
                DataTable dt;
                String sqlText;

                sqlText = "SELECT * FROM GebelikFormDegeri WHERE gebelikId = " + indexId;
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

                dgv_gebelikTablosu.DataSource = dt;  
        }

        private void btn_degerEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikDegerleriEkleme(sicilNo);
            form.ShowDialog();
        }
    }
}
