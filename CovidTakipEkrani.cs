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
    public partial class ekran_CovidTakipEkrani : Form
    {
        string sicil;

        public ekran_CovidTakipEkrani(string sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
        }

        private void CovidTakipEkrani_Load(object sender, EventArgs e)
        {
            String sqlText;
            int indexId;
            DataTable dt;

            sqlText= "Select Personel.id from Personel where Personel.sicilNo = " + sicil;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            indexId = (int)dt.Rows[0]["id"];

            sqlText = "Select * from Covid where Covid.personelId = " + indexId + ";";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            this.tbx_CovidListeleme.Text = "Kayıt Durumu : "    + dt.Rows[0]["kayitDurumu"].ToString() + Environment.NewLine +
                                           "Statü Durumu : "    + dt.Rows[0]["statu"].ToString() + Environment.NewLine +
                                           "Şirket Formülü : "   + dt.Rows[0]["sirketFormul"].ToString();   
        }

            sqlText = "Select top 5 * from Ates left join Covid on Covid.personelId = " + indexId + " and Covid.id = Ates.covidId " + "order by olcumTarihi desc "+";";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            this.dgv_olcum.DataSource = dt;  

            sqlText = "Select top 5 * from Test left join Covid on Covid.personelId = " + indexId + " and Covid.id = Test.covidId " + "order by testTarihi desc "+";";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            this.dgv_test.DataSource = dt;
        }

        private void tbx_CovidListeleme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
