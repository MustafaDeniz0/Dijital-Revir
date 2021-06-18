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
    public partial class ekran_IsKazasiListeleme : Form
    {
        DataTable dt;

        public ekran_IsKazasiListeleme()
        {
            InitializeComponent();
        }

        private void dgv_isKazaListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kazaId;
            int index;
            Form form;

            index = SqlOps.GetDataGridViewRowIndex(dgv_isKazaListesi, "sicilNo");
            kazaId = (int)dt.Rows[index]["id"];

            form = new ekran_IsKazasiGoruntuleme(kazaId);
            form.ShowDialog();

            SqlDgridUpdate();
        }

        private void ekran_IsKazasiListeleme_Load(object sender, EventArgs e)
        {
            SqlDgridUpdate();
        }

        private void SqlDgridUpdate()
        {
            String sqlText;

            sqlText = "SELECT IsKazası.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, IsKazası.kazaZamanı " +
            "FROM Personel INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id " +
            "INNER JOIN Departman ON Departman.id = Personel.departmanId " +
            "INNER JOIN Sirket ON Sirket.id = Departman.sirketId " +
            "INNER JOIN IsKazası ON IsKazası.personelId = Personel.id";

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            dgv_isKazaListesi.DataSource = dt;    
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            String sqlText;

            sqlText = "SELECT IsKazası.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, IsKazası.kazaZamanı " +
            "FROM ((((Personel INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id) " +
            "INNER JOIN Departman ON Departman.id = Personel.departmanId) " +
            "INNER JOIN Sirket ON Sirket.id = Departman.sirketId) " +
            "INNER JOIN IsKazası ON IsKazası.personelId = Personel.id AND (Personel.sicilNo ='" + tbx_sicilNo.Text + "' OR OzlukBilgileri.ad = '" + tbx_ad.Text + "' OR OzlukBilgileri.soyAd = '" + tbx_soyad.Text + "' OR Sirket.sirketAdi = '" + tbx_sirket.Text + "' OR IsKazası.kazaZamanı = '" + SqlOps.SqlDateInsert(dtp_isKazasi.Value.Date, tbx_KazaSaati.Text) + "'))";

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            dgv_isKazaListesi.DataSource = dt;

            this.Update();
        }

        private void tbx_sicilNo_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_sicilNo.Clear();
        }

        private void tbx_ad_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_ad.Clear();
        }

        private void tbx_soyad_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_soyad.Clear();
        }

        private void tbx_sirket_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_sirket.Clear();
        }
    }
}
