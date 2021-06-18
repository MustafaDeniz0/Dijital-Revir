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
    public partial class ekran_GebelikDegerleriEkleme : Form
    {
        string sicil;
        int indexId;
        public ekran_GebelikDegerleriEkleme(string sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
            string sqltext = "select Gebelik.id from Gebelik left join Personel on Gebelik.personelId = Personel.id  where Personel.sicilNo = " + sicil+ " Order by id Desc ";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqltext);
            indexId = (int)dt.Rows[0]["id"];
            
        }

        private void btn_GebelikDegerEkleme_Click(object sender, EventArgs e)
        {
            string sqlText = "insert into GebelikFormDegeri (gebelikId,tarih, kiloDegeri,taDegeri,nabızDegeri,hmgDegeri,titDegeri,pretibitalOdem,asiDegeri,ekTetkikDegeri,ilac) values (" + indexId + ",GETDATE(),'" + tbx_kilo.Text + "','" + tbx_ta.Text + "','" + tbx_nabız.Text + "','" + tbx_hmg.Text + "','" + tbx_tit.Text + "','" + tbx_odem.Text + "','" + tbx_ekTetkik.Text + "','" + tbx_asi.Text + "','" + tbx_verilenİlac.Text + "')";

            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            MessageBox.Show("Değerler Eklendi.");
            this.Close();
        }
    }
}
