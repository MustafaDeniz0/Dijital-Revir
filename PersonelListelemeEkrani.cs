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
        String sicil="";
        DataTable dt = new DataTable();
        public ekran_PersonelListeleme(String arananKelime)
        {
            InitializeComponent();
            this.arananKelime = arananKelime;
        }

        private void dgrid_PersonelBilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            int index = SqlOps.GetDataGridViewRowIndex(dgrid_PersonelBilgileri, "sicilNo");
            sicil = dt.Rows[index]["sicilNo"].ToString();
            Form form = new ekran_PersonelBilgileriGoruntuleme(sicil);
            form.ShowDialog();
        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {
            
            

        }

        private void ekran_PersonelListele_Load(object sender, EventArgs e)
        {
            string sqlText;
           
            if(arananKelime == "Sicil No ya da İsim Giriniz.") {
                sqlText = "Select Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd, Sirket.sirketAdi from" +
                "(((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)" +
                "Inner join Departman on Departman.id = Personel.departmanId)" +
                "Inner join Sirket on Sirket.id = Departman.sirketId); ";
                dgrid_PersonelBilgileri.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
            }
            else {
                 sqlText = "Select Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd, Sirket.sirketAdi from"+
                "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)"+
                "Inner join Departman on Departman.id = Personel.departmanId)"+
			    "Inner join Sirket on Sirket.id = Departman.sirketId))where Personel.sicilNo = "+ "'" + arananKelime + "'" + " or OzlukBilgileri.ad = "+"'"+arananKelime+"'"+";" ;
                dgrid_PersonelBilgileri.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
            }
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
        }
    }
}
