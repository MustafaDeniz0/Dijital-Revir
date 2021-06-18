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
    public partial class ekran_GebelikTakip : Form
    {
        String sicil;
        int indexId;
        public ekran_GebelikTakip(String sicil)
        {
            this.sicil = sicil;
            InitializeComponent();
            
            string sqltext = "select Gebelik.id from Gebelik left join Personel on Gebelik.personelId = Personel.id  where Personel.sicilNo = " + sicil + " Order by id Desc ";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqltext);
            indexId = (int)dt.Rows[0]["id"];
        }

        private void ekran_GebelikTakip_Load(object sender, EventArgs e)
        {            
                DataTable dt;
                String sqlText;

                sqlText = "Select * From GebelikFormDegeri Where gebelikId = "+ indexId;
                dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

                dgv_gebelikTablosu.DataSource = dt;
           
        }

        private void btn_degerEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikDegerleriEkleme(sicil);
            form.ShowDialog();
        }
    }
}
