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
    public partial class ekran_CovidListeleme : Form
    {
        int rowIndex;
        DataTable dt = new DataTable();

        public ekran_CovidListeleme()
        {
            InitializeComponent();
        }

        private void dgv_covidListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = SqlOps.GetDataGridViewRowIndex(dgv_covidListesi, "sicilNo");
            int indexId = (int)dt.Rows[rowIndex]["id"];

            Form form = new ekran_CovidTakipEkrani(indexId);
            form.ShowDialog();
        }

        private void ekran_CovidListeleme_Load(object sender, EventArgs e)
        {
            try
            {

                String sqlText;

                sqlText = "Select Covid.id , Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd, Sirket.sirketAdi ,Covid.vakaDurumu  from  " +
                 "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)" +
                "Inner join Departman on Departman.id = Personel.departmanId)" +
                "Inner join Sirket on Sirket.id = Departman.sirketId)" +
                "Inner join Covid on Covid.personelId = Personel.id)";
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

                dgv_covidListesi.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Listelenecek Personel Bulunmamaktadır. ");
                this.Close();
            }

        }

        private void btn_covidEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_CovidEkleme();
            form.ShowDialog();

        }

        private void btn_covidListele_Click(object sender, EventArgs e)
        {
            try {
                String sqlText;

                sqlText = "Select Covid.id , Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd, Sirket.sirketAdi ,Covid.vakaDurumu  from  " +
                 "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)" +
                "Inner join Departman on Departman.id = Personel.departmanId)" +
                "Inner join Sirket on Sirket.id = Departman.sirketId)" +
                "Inner join Covid on Covid.personelId = Personel.id  and (Personel.sicilNo ='" + txb_sicilNo.Text + "' or OzlukBilgileri.ad = '" + txb_ad.Text + "' or OzlukBilgileri.soyAd = '" + txb_soyad.Text + "' or Sirket.sirketAdi='" + txb_sirket.Text + "' or Covid.vakaDurumu = '" + txb_covidDurumu.Text + "'))";
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

                dgv_covidListesi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listelenecek Personel Bulunmamaktadır. ");
                this.Close();
            }


        }

        private void txb_sicilNo_MouseClick(object sender, MouseEventArgs e)
        {
            txb_sicilNo.Clear();
        }

        private void txb_ad_MouseClick(object sender, MouseEventArgs e)
        {
            txb_ad.Clear();
        }

        private void txb_soyad_MouseClick(object sender, MouseEventArgs e)
        {
            txb_soyad.Clear();
        }

        private void txb_sirket_MouseClick(object sender, MouseEventArgs e)
        {
            txb_sirket.Clear();
        }

        private void txb_covidDurumu_MouseClick(object sender, MouseEventArgs e)
        {
            txb_covidDurumu.Clear();
        }
    }
}
