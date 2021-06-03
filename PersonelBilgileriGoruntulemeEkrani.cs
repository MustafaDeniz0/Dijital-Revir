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

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ekran_CovidTakipEkrani();
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
            String sqlT = "Select Personel.id from Personel where Personel.sicilNo = " + sicil;
            int index = (int)SqlOps.CreateDataTableBySqlQuery(sqlT).Rows[0]["id"];

            String sqlText = "Select * from Personel where Personel.id = " + index + ";";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            String sqlText2 = "Select * From OzlukBilgileri inner join Personel on Personel.id ="+ index+" and Personel.ozlukId = OzlukBilgileri.id ;";
            DataTable dt2 = SqlOps.CreateDataTableBySqlQuery(sqlText2);
            String sqlText3 = "Select Departman.departmanAdi,Sirket.sirketAdi from ((Personel inner join Departman on Personel.departmanId = departmanId and Personel.id = "+index+") inner Join Sirket on Departman.sirketId = Sirket.id and Departman.id=Personel.departmanId);";
            DataTable dt3 = SqlOps.CreateDataTableBySqlQuery(sqlText3);
            string cinsiyet;
            if ((Boolean)dt2.Rows[0]["cinsiyet"] == true) { cinsiyet = "Erkek"; }
            else { cinsiyet = "Kadın"; }
                this.textBox1.Text = "Sicil No : "+dt.Rows[0]["sicilNo"].ToString() 
                + Environment.NewLine +dt2.Rows[0]["ad"]+" "+ dt2.Rows[0]["soyAd"]+
                Environment.NewLine +"Departman Adı : "+ dt3.Rows[0]["departmanAdi"]
                + Environment.NewLine +"Şirket Adı :  " + dt3.Rows[0]["sirketAdi"]
                + Environment.NewLine+"Cinsiyet : "+cinsiyet;
            if ((Boolean)dt2.Rows[0]["cinsiyet"] == true) { btn_Gebelik.Hide(); }
        }

        private void btn_ISBMuayene_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsbMuayeneEkleme();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_IsKazası_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsKazasıEkleme();
            form.ShowDialog();
        }

        private void btn_Gebelik_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikTakip();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
