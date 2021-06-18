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
    public partial class ekran_TestEklemeEkrani : Form
    {
        int indexCovidId;
        public ekran_TestEklemeEkrani(int indexCovidId)
        {
            InitializeComponent();
            this.indexCovidId = indexCovidId;
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            String sqlText;

            sqlText = "Insert Into Test(covidId, testTuru, testTarihi , testSonucu) "+
                     " Values(" + indexCovidId + ",'" + tbx_TestTuru.Text + "', getDate(),' "+ tbx_TestSonucu.Text +"')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            this.Close();
        }
    }
}
