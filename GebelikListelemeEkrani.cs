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
    public partial class ekran_GebelikListeleme : Form
    {
        String sicilNo;
        DataTable dt;
        public ekran_GebelikListeleme()
        {
            InitializeComponent();
        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {

        }

        private void dgv_gebelikListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            Form form;

            index = SqlOps.GetDataGridViewRowIndex(dgv_gebelikListesi, "sicilNo");
            sicilNo = dt.Rows[index]["sicilNo"].ToString();

            form = new ekran_GebelikTakip(sicilNo);
            form.ShowDialog();
        }

        private void ekran_GebelikListeleme_Load(object sender, EventArgs e)
        {
            SqlDgvUpdate();
        }

        private void btn_GebelikEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikEklemeEkrani();
            form.ShowDialog();

            SqlDgvUpdate();
        }

        private void SqlDgvUpdate()
        {
            String sqlText;

            sqlText = "SELECT Personel.sicilNo ,OzlukBilgileri.ad,OzlukBilgileri.soyAd, Gebelik.sonAdetTarihi  FROM Gebelik LEFT JOIN Personel ON Gebelik.personelId = Personel.id Left join OzlukBilgileri on OzlukBilgileri.id = Personel.ozlukId ORDER BY OzlukBilgileri.ad, OzlukBilgileri.soyAd DESC";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            dgv_gebelikListesi.DataSource = dt;
        }
    }
}
