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
        string sicil;
        DataTable dt;
        public ekran_IsKazasiListeleme()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {

        }

        private void dgv_isKazaListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kazaId , index;
            index=SqlOps.GetDataGridViewRowIndex(dgv_isKazaListesi, "sicilNo");
            kazaId = (int)dt.Rows[index]["id"];
            Form form = new ekran_IsKazasiGoruntuleme(kazaId);
            form.ShowDialog();
        }

        

        private void ekran_IsKazasiListeleme_Load(object sender, EventArgs e)
        {
            String sqlText;


            sqlText = "Select IsKazası.id , Personel.sicilNo , OzlukBilgileri.ad , OzlukBilgileri.soyAd, Sirket.sirketAdi ,IsKazası.kazaZamanı  from  "+
             "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)"+
            "Inner join Departman on Departman.id = Personel.departmanId)"+
			"Inner join Sirket on Sirket.id = Departman.sirketId)"+
			"Inner join IsKazası on IsKazası.personelId = Personel.id)";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            dgv_isKazaListesi.DataSource = dt;
        }
    }
}
