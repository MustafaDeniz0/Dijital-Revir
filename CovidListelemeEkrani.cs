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
        String sicil = "";
        DataTable dt = new DataTable();

        public ekran_CovidListeleme()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_covidListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String sicilNo;

            rowIndex = SqlOps.GetDataGridViewRowIndex(dgv_covidListesi, "sicilNo");     
            sicilNo = dt.Rows[rowIndex]["sicilNo"].ToString();

            Form form = new ekran_CovidTakipEkrani(sicilNo);
            form.ShowDialog();
        }

        private void ekran_CovidListeleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            

            sqlText = "Select Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd, Sirket.sirketAdi ,Covid.vakaDurumu  from  " +
             "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)" +
            "Inner join Departman on Departman.id = Personel.departmanId)" +
            "Inner join Sirket on Sirket.id = Departman.sirketId)" +
            "Inner join Covid on Covid.personelId = Personel.id)";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            dgv_covidListesi.DataSource = dt;
        }
    }
}
