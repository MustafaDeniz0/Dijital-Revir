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
        String sicil;
        DataTable dt;
        
        public ekran_GebelikListeleme()
        {
            InitializeComponent(); 
        }

        private void dgv_gebelikListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            Form form;

            index = SqlOps.GetDataGridViewRowIndex(dgv_gebelikListesi, "sicilNo");
            sicil = dt.Rows[index]["sicilNo"].ToString();

            form = new ekran_GebelikTakip(sicil);
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
            try
            {
                String sqlText;

                sqlText = "SELECT Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Gebelik.sonAdetTarihi " +
                "FROM Gebelik LEFT JOIN Personel ON Gebelik.personelId = Personel.id LEFT JOIN OzlukBilgileri ON OzlukBilgileri.id = Personel.ozlukId " +
                "ORDER BY Gebelik.id DESC";
                
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
                dgv_gebelikListesi.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Listelenecek Personel Bulunamadı.");
                this.Close();
            }
        }
    }
}
