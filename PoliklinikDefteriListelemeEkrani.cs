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
            Form form = new ekran_PoliklinikEklemeEkranı();
            form.ShowDialog();
            SqlDgridUpdate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sıraId, index;
            index = SqlOps.GetDataGridViewRowIndex(dgv_PoliklinikListeleme, "sıraNo");
            sıraId = (int)dt.Rows[index]["sıraNo"];
            Form form = new ekran_PoliklinikDefteriGoruntuleme(sıraId);
            form.ShowDialog();
        }

        private void ekran_PoliklinikDefteriListeleme_Load(object sender, EventArgs e)
        {
            SqlDgridUpdate();
        }
        private void SqlDgridUpdate()
        {
            String sqlText;


            sqlText = "Select Poliklinik.sıraNo , Personel.sicilNo , OzlukBilgileri.ad , OzlukBilgileri.soyAd, Sirket.sirketAdi ,Poliklinik.acıklama  from  " +
             "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id) " +
            "Inner join Departman on Departman.id = Personel.departmanId) " +
            "Inner join Sirket on Sirket.id = Departman.sirketId)" +
            "Inner join Poliklinik on Poliklinik.personelId = Personel.id) ";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            dgv_PoliklinikListeleme.DataSource = dt;
        }
    }
}
