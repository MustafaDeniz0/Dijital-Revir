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
    public partial class ekran_PoliklinikDefteriListeleme : Form
    {
        DataTable dt;

        public ekran_PoliklinikDefteriListeleme()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form form;

            form = new ekran_PoliklinikEkleme();
            form.ShowDialog();
            updateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sıraId;
            int index;
            Form form;

            index = SqlOps.GetDataGridViewRowIndex(dgv_PoliklinikListeleme, "id");
            sıraId = (int)dt.Rows[index]["id"];

            form = new ekran_PoliklinikDefteriGoruntuleme(sıraId);
            form.ShowDialog();
        }

        private void ekran_PoliklinikDefteriListeleme_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void btn_poliklinikDefteriListele_Click(object sender, EventArgs e)
        {
            String sqlText;

            int temp;

            if (int.TryParse(txb_siraNo.Text, out temp))
            {
                sqlText = "SELECT Poliklinik.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, Poliklinik.acıklama " +
                "FROM Personel " +
                "INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id " +
                "INNER JOIN Departman ON Departman.id = Personel.departmanId " +
                "INNER JOIN Sirket ON Sirket.id = Departman.sirketId " +
                "INNER JOIN Poliklinik ON Poliklinik.personelId = Personel.id " +
                "WHERE Poliklinik.id = '" + txb_siraNo.Text + "' OR Personel.sicilNo = '" + txb_sicilNo.Text + "' OR OzlukBilgileri.ad = '" + txb_ad.Text + "' OR OzlukBilgileri.soyAd = '" + txb_soyad.Text + "' OR Sirket.sirketAdi = '" + txb_sirketAdi.Text + "'";

                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                dgv_PoliklinikListeleme.DataSource = dt;
            }
            else if (txb_siraNo.Text.Equals("Sıra No"))
            {
                sqlText = "SELECT Poliklinik.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, Poliklinik.acıklama " +
                "FROM Personel " +
                "INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id " +
                "INNER JOIN Departman ON Departman.id = Personel.departmanId " +
                "INNER JOIN Sirket ON Sirket.id = Departman.sirketId " +
                "INNER JOIN Poliklinik ON Poliklinik.personelId = Personel.id " +
                "WHERE Personel.sicilNo = '" + txb_sicilNo.Text + "' OR OzlukBilgileri.ad = '" + txb_ad.Text + "' OR OzlukBilgileri.soyAd = '" + txb_soyad.Text + "' OR Sirket.sirketAdi = '" + txb_sirketAdi.Text + "'";

                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                dgv_PoliklinikListeleme.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Geçersiz Sıra No.");
            }
        }

        private void updateDataGridView()
        {
            String sqlText;

            sqlText = "SELECT Poliklinik.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, Poliklinik.acıklama " +
            "FROM Personel " +
            "INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id " +
            "INNER JOIN Departman ON Departman.id = Personel.departmanId " +
            "INNER JOIN Sirket ON Sirket.id = Departman.sirketId " +
            "INNER JOIN Poliklinik ON Poliklinik.personelId = Personel.id " +
            "ORDER BY Poliklinik.id DESC";

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            dgv_PoliklinikListeleme.DataSource = dt;
        }

        private void txb_siraNo_MouseClick(object sender, MouseEventArgs e)
        {
            txb_siraNo.Clear();
        }

        private void txb_ad_MouseClick(object sender, MouseEventArgs e)
        {
            txb_ad.Clear();
        }

        private void txb_soyad_MouseClick(object sender, MouseEventArgs e)
        {
            txb_soyad.Clear();
        }

        private void txb_taniGrubu_MouseClick(object sender, MouseEventArgs e)
        {
            txb_sirketAdi.Clear();
        }

        private void txb_sicilNo_MouseClick(object sender, MouseEventArgs e)
        {
            txb_sicilNo.Clear();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txb_siraNo.Clear();
            txb_siraNo.Text = "Sıra No";

            txb_sicilNo.Clear();
            txb_sicilNo.Text = "Sicil No";

            txb_ad.Clear();
            txb_ad.Text = "Ad";

            txb_soyad.Clear();
            txb_soyad.Text = "Soyad";

            txb_sirketAdi.Clear();
            txb_sirketAdi.Text = "Şirket Adı";

            updateDataGridView();
        } 
    }
}
