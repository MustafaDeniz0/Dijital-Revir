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
            SqlDgridUpdate();
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
            SqlDgridUpdate();
        }
        private void SqlDgridUpdate()
        {
            String sqlText;

            sqlText = "SELECT Poliklinik.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Sirket.sirketAdi, Poliklinik.acıklama " +
            "FROM ((((Personel INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id) " +
            "INNER JOIN Departman ON Departman.id = Personel.departmanId) " +
            "INNER JOIN Sirket ON Sirket.id = Departman.sirketId) " +
            "INNER JOIN Poliklinik ON Poliklinik.personelId = Personel.id) " +
            "ORDER BY Poliklinik.sıraNo DESC";

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            dgv_PoliklinikListeleme.DataSource = dt;
        }
    }
}
