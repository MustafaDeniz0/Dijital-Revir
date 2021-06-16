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
    public partial class ekran_CovidTakipEkrani : Form
    {
        int indexCovidId;
        String sicil;

        public ekran_CovidTakipEkrani(int indexCovidId)
        {
            InitializeComponent();
            this.indexCovidId = indexCovidId;

        }
        public ekran_CovidTakipEkrani(String sicil)
        {
            String sqlText;
            DataTable dt;

            InitializeComponent();
            this.sicil = sicil;

            sqlText = "SELECT Covid.id FROM Personel INNER JOIN Covid ON Covid.personelId = Personel.id AND Personel.sicilNo = " + sicil;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            this.indexCovidId = (int)dt.Rows[0]["id"];
        }

        private void CovidTakipEkrani_Load(object sender, EventArgs e)
        {
            SqlDgvUpdate();
        }

        private void btn_OlcumAtesEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_AtesDegerleriEklemeEkrani(indexCovidId);
            form.ShowDialog();
            SqlDgvUpdate();
        }

        private void btn_TestEkle_Click_1(object sender, EventArgs e)
        {
            Form form = new ekran_TestEklemeEkrani(indexCovidId);
            form.ShowDialog();
            SqlDgvUpdate();
        }
        private void SqlDgvUpdate()
        {
            String sqlText;
            DataTable dt;

            sqlText = "Select * from Covid where Covid.id = " + indexCovidId;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);


            if (dt.Rows.Count != 0)
            {
                this.tbx_CovidListeleme.Text = "Kayıt Durumu : " + dt.Rows[0]["kayitDurumu"].ToString() + Environment.NewLine +
                                               "Statü Durumu : " + dt.Rows[0]["statu"].ToString() + Environment.NewLine +
                                               "Şirket Formülü : " + dt.Rows[0]["sirketFormul"].ToString() + Environment.NewLine +
                                               "Kod : " + dt.Rows[0]["kod"].ToString() + Environment.NewLine +
                                               "Vaka Durumu : " + dt.Rows[0]["vakaDurumu"].ToString() + Environment.NewLine +
                                               "Bulgu : " + dt.Rows[0]["bulgu"].ToString() + Environment.NewLine +
                                               "İlaç : " + dt.Rows[0]["ilac"].ToString() + Environment.NewLine +
                                               "Rapor Süresi : " + dt.Rows[0]["raporSuresi"].ToString() + Environment.NewLine +
                                               "Rapor Tarihi : " + dt.Rows[0]["raporTarihi"].ToString() + Environment.NewLine +
                                               "İşbaşı Tarihi : " + dt.Rows[0]["isBasiTarihi"].ToString() + Environment.NewLine +
                                               "İletişim Durumu : " + dt.Rows[0]["iletisimDurumu"].ToString();
            }

            sqlText = "SELECT Distinct TOP 5 Ates.olcumDegeri, Ates.olcumTarihi FROM Ates LEFT JOIN Covid INNER JOIN Personel on Covid.id = " + indexCovidId + "ON Covid.id = Ates.covidId ORDER BY olcumTarihi DESC";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            this.dgv_olcum.DataSource = dt;

            sqlText = "SELECT Distinct TOP 5 Test.testTuru, Test.testTarihi, Test.testSonucu FROM Test LEFT JOIN Covid ON Covid.id = " + indexCovidId + " AND Covid.id = Test.covidId" + " ORDER BY testTarihi DESC";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            this.dgv_test.DataSource = dt;
        }
    }
}