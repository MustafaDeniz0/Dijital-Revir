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

        string sicil;
        public ekran_PersonelBilgileriGoruntuleme(string sicil)
        {
            InitializeComponent();
            this.sicil = sicil;

        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {

        }

        private void btn_CovidFormu_Click(object sender, EventArgs e)
        {
            Form form = new ekran_CovidTakipEkrani(sicil);
            form.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            
          
           
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        public void ekran_PersonelSayfasi_Load(object sender, EventArgs e)
        {
            String sqlText;
            int indexId;
            DataTable dt;
            DataTable dt2;
            DataTable dt3;
            String cinsiyet;

            sqlText = "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = " + sicil;
            indexId = (int)SqlOps.CreateDataTableBySqlQuery(sqlText).Rows[0]["id"];

            sqlText = "SELECT * FROM Personel WHERE Personel.id = " + indexId;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "SELECT * FROM OzlukBilgileri INNER JOIN Personel ON Personel.id = " + indexId + " AND Personel.ozlukId = OzlukBilgileri.id";
            dt2 = SqlOps.CreateDataTableBySqlQuery(sqlText);

            sqlText = "SELECT Departman.departmanAdi, Sirket.sirketAdi FROM ((Personel INNER JOIN Departman ON Personel.departmanId = departmanId and Personel.id = " + indexId + ") INNER JOIN Sirket ON Departman.sirketId = Sirket.id AND Departman.id=Personel.departmanId)";
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


            this.textBox1.Text =    "Sicil No : "       + dt.Rows[0]["sicilNo"].ToString()                  + Environment.NewLine +
                                    "Personel Adı : "   + dt2.Rows[0]["ad"] + " " + dt2.Rows[0]["soyAd"]    + Environment.NewLine +
                                    "Departman Adı : "  + dt3.Rows[0]["departmanAdi"]                       + Environment.NewLine +
                                    "Şirket Adı :  "    + dt3.Rows[0]["sirketAdi"]                          + Environment.NewLine +
                                    "Cinsiyet : "       + cinsiyet;
        }

        private void btn_ISBMuayene_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsbMuayeneEkleme(sicil);
            form.ShowDialog();
        }

        private void btn_IsKazası_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsKazasıEkleme(sicil);
            form.ShowDialog();
        }

        private void btn_Gebelik_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikTakip(sicil);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_asiEkleme_Click(object sender, EventArgs e)
        {
            Form form = new ekran_AsiEkleme(sicil);
            form.ShowDialog();  
        }
    }
}
