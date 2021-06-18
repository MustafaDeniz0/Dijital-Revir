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
    public partial class ekran_IsbMuayeneEkleme : Form
    {
        String sicil;
        public ekran_IsbMuayeneEkleme(String sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
        }

        private void btn_Muayene_Click_1(object sender, EventArgs e)
        {
            Form form = new ekran_MuayeneEkleme(sicil);
            form.ShowDialog();

            DgridUpdate();
        }

        private void ekran_IsbMuayeneEkleme_Load(object sender, EventArgs e)
        {
            DgridUpdate();
        }

        private void dgrid_ISBMuayeneEkleme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            Form form;

            index = SqlOps.GetDataGridViewRowIndex(dgrid_ISBMuayeneEkleme, "muayeneId"); 
            
            form = new MuayeneGoruntulemeEkrani(sicil, index);
            form.ShowDialog();

            DgridUpdate();
        }

        private void DgridUpdate()
        {
            String sqlText = "SELECT Muayene.tarih, Muayene.tanı, Muayene.doktor " +
            "FROM ISB " + 
            "INNER JOIN Personel ON Personel.id = ISB.PersonelId " + 
            "INNER JOIN Muayene ON ISB.muayeneId = Muayene.id " + 
            "WHERE Personel.sicilNo = " + sicil +
            "ORDER BY Muayene.tarih DESC";

            dgrid_ISBMuayeneEkleme.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
        }
    }
}
