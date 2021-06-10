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
        public ekran_GebelikListeleme()
        {
            InitializeComponent();
        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {

        }

        private void dgv_gebelikListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void ekran_GebelikListeleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;
            sqlText = "SELECT Personel.sicilNo ,OzlukBilgileri.ad,OzlukBilgileri.soyAd, Gebelik.sonAdetTarihi  FROM Gebelik LEFT JOIN Personel ON Gebelik.personelId = Personel.id Left join OzlukBilgileri on OzlukBilgileri.id =Personel.ozlukId";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            dgv_gebelikListesi.DataSource = dt;
        }
    }
}
