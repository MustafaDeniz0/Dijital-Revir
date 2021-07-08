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
    
    public partial class ekran_PersonelBilgileriGoruntuleme : Form
    {
        int indexId;
        string sicilNo;
        public ekran_PersonelBilgileriGoruntuleme(string sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
        }

        private void btn_CovidFormu_Click(object sender, EventArgs e)
        {
            try {
                Form form = new ekran_CovidTakipEkrani(sicilNo);
                form.ShowDialog();
            }
            catch(Exception ex)
            {

            }
        }
        public void ekran_PersonelSayfasi_Load(object sender, EventArgs e)
        {
            String sqlText;
            
            DataTable dt;
            DataTable dt2;
            DataTable dt3;
            String cinsiyet;

            sqlText = "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = " + sicilNo;
            indexId = (int)SqlOps.CreateDataTableBySqlQuery(sqlText).Rows[0]["id"];

            sqlText = "SELECT * FROM Personel WHERE Personel.id = " + indexId;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "SELECT * FROM OzlukBilgileri " + 
            "INNER JOIN Personel ON Personel.id = " + indexId + " AND Personel.ozlukId = OzlukBilgileri.id";
            dt2 = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "SELECT Departman.departmanAdi, Sirket.sirketAdi " + 
            "FROM Personel " + 
            "INNER JOIN Departman ON Personel.departmanId = departmanId AND Personel.id = " + indexId + 
            "INNER JOIN Sirket ON Departman.sirketId = Sirket.id AND Departman.id = Personel.departmanId";
            dt3 = SqlOps.CreateDataTableBySqlQuery(sqlText);

            if ((Boolean)dt2.Rows[0]["cinsiyet"] == true)
            { 
                cinsiyet = "Erkek";
                btn_Gebelik.Hide();
            }
            else 
            { 
                cinsiyet = "Kadın";   
            }

            this.tbx_PersonelBilgileriGoruntuleme.Text = "Sicil No : " + dt.Rows[0]["sicilNo"].ToString() + Environment.NewLine +
            "Personel Adı : " + dt2.Rows[0]["ad"] + " " + dt2.Rows[0]["soyAd"] + Environment.NewLine +
            "Departman Adı : " + dt3.Rows[0]["departmanAdi"] + Environment.NewLine +
            "Şirket Adı :  " + dt3.Rows[0]["sirketAdi"] + Environment.NewLine +
            "Cinsiyet : " + cinsiyet;

            btn_Gebe.Visible = false;
            btn_Engelli.Visible = false;

            sqlText = "SELECT Etiket.engellilik , Etiket.gebemi FROM Etiket WHERE Etiket.personalId = " + indexId;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            if ((bool)dt.Rows[0]["engellilik"]) { btn_Engelli.Visible = true; }
            if ((bool)dt.Rows[0]["gebemi"]) { btn_Gebe.Visible = true; }
            TakipServisleri.periyodikMuayeneTarihHesaplama(lbl_periyodikMuayene, indexId);
        }

        private void btn_ISBMuayene_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsbMuayeneEkleme(sicilNo);
            form.ShowDialog();
        }

        private void btn_IsKazası_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsKazasıEkleme(sicilNo);
            form.ShowDialog();
        }

        private void btn_Gebelik_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikTakip(sicilNo);
            form.ShowDialog();
        }

        private void btn_asiEkleme_Click(object sender, EventArgs e)
        {
            Form form = new ekran_AsiEkleme(sicilNo);
            form.ShowDialog();  
        }

        private void btn_Ek2Ekle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_Ek2EklemeVeGoruntuleme(sicilNo);
            form.ShowDialog();
            
        }

        private void btn_PeriyodikMuayene_Click(object sender, EventArgs e)
        {
            String sqlText = "Update Personel Set sıradakiPerMuayene =DATEADD(MONTH," + TakipServisleri.periyodikMuayene(indexId) + ",GetDate()) Where Personel.id = "+indexId;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            TakipServisleri.periyodikMuayeneTarihHesaplama(lbl_periyodikMuayene, indexId);

        }
    }
}
