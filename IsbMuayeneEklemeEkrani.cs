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
        }

        private void ekran_IsbMuayeneEkleme_Load(object sender, EventArgs e)
        {
            String sqlText = "Select Muayene.tarih, Muayene.tanı,Muayene.doktor From ((ISB inner join Personel on Personel.id = ISB.PersonelId) inner join Muayene on ISB.muayeneId = Muayene.id) Where Personel.sicilNo = '" + sicil+"'; ";
            dgrid_ISBMuayeneEkleme.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);

        }

        private void dgrid_ISBMuayeneEkleme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            int index = SqlOps.GetDataGridViewRowIndex(dgrid_ISBMuayeneEkleme, "muayeneId");    
            Form form = new MuayeneGoruntulemeEkrani(sicil, index);
            form.ShowDialog();

        }
    }
}
