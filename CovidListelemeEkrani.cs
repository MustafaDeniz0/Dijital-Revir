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
        DataTable dt = new DataTable();

        public ekran_CovidListeleme()
        {
            InitializeComponent();
        }

        private void dgv_covidListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex;
            int indexId;
            Form form;

            rowIndex = SqlOps.GetDataGridViewRowIndex(dgv_covidListesi, "sicilNo");
            indexId = (int)dt.Rows[rowIndex]["id"];

            form = new ekran_CovidTakipEkrani(indexId);
            form.ShowDialog();
        }

        private void ekran_CovidListeleme_Load(object sender, EventArgs e)
        {
            try
            {
                String sqlText;

                sqlText = "SELECT Covid.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, Covid.vakaDurumu " +
                "FROM ((((Personel INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id)" +
                "INNER JOIN Departman ON Departman.id = Personel.departmanId)" +
                "INNER JOIN Sirket ON Sirket.id = Departman.sirketId)" +
                "INNER JOIN Covid ON Covid.personelId = Personel.id)" +
                "ORDER BY OzlukBilgileri.ad, OzlukBilgileri.soyAd DESC";

                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                dgv_covidListesi.DataSource = dt;
            }
            catch(Exception ex)
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
            try 
            {
                String sqlText;

                sqlText = "SELECT Covid.id, Personel.sicilNo,OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, Covid.vakaDurumu " +
                "FROM ((((Personel Inner join OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id) " +
                "INNER JOIN Departman ON Departman.id = Personel.departmanId) " +
                "INNER JOIN Sirket ON Sirket.id = Departman.sirketId) " +
                "INNER JOIN Covid ON Covid.personelId = Personel.id AND (Personel.sicilNo ='" + txb_sicilNo.Text + "' OR OzlukBilgileri.ad = '" + txb_ad.Text + "' OR OzlukBilgileri.soyAd = '" + txb_soyad.Text + "' OR Sirket.sirketAdi='" + txb_sirket.Text + "' OR Covid.vakaDurumu = '" + txb_covidDurumu.Text + "'))";
                
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                dgv_covidListesi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listelenecek Personel Bulunmamaktadır.");
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
