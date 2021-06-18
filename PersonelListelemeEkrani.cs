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
    public partial class ekran_PersonelListeleme : Form
    {
        String arananKelime;
        String sicilNo = "";
        DataTable dt = new DataTable();

        public ekran_PersonelListeleme(String arananKelime)
        {
            InitializeComponent();

            this.arananKelime = arananKelime;
        }

        private void dgrid_PersonelBilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            Form form;

            index = SqlOps.GetDataGridViewRowIndex(dgrid_PersonelBilgileri, "sicilNo");
            sicilNo = dt.Rows[index]["sicilNo"].ToString();

            form = new ekran_PersonelBilgileriGoruntuleme(sicilNo);
            form.ShowDialog();
        }

        private void ekran_PersonelListele_Load(object sender, EventArgs e)
        {
            String sqlText;
            

            
            if(arananKelime == "Sicil No ya da İsim Giriniz." || arananKelime == "") {
                sqlText = "SELECT Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi " +
                "FROM (((Personel INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id) " +
                "INNER JOIN Departman ON Departman.id = Personel.departmanId) " +
                "INNER JOIN Sirket ON Sirket.id = Departman.sirketId); ";

                dgrid_PersonelBilgileri.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
            }
            else {
                 sqlText = "SELECT Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi " +
                "FROM ((((Personel Inner join OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id)" +
                "INNER JOIN Departman ON Departman.id = Personel.departmanId)" +
                "INNER JOIN Sirket ON Sirket.id = Departman.sirketId)) " + 
                "WHERE Personel.sicilNo = " + "'" + arananKelime + "'" + " OR OzlukBilgileri.ad = " + "'" + arananKelime + "'";

                dgrid_PersonelBilgileri.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
            }

            if(dgrid_PersonelBilgileri.RowCount == 1)
            {
                MessageBox.Show("Girdiğiniz kelime hatalıdır. Tekrar deneyiniz.");
            }

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
        }
    }
}
