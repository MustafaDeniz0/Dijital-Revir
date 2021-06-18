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
    public partial class MuayeneGoruntulemeEkrani : Form
    {
        String sicilNo;
        int index;

        public MuayeneGoruntulemeEkrani(String sicilNo, int index)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
            this.index = index;
        }

        private void MuayeneGoruntulemeEkrani_Load(object sender, EventArgs e)
        {
            String sqlText;
            String id;
            DataTable dt;

            sqlText = "SELECT * " + "FROM ISB " +
            "INNER JOIN Personel ON Personel.id = ISB.PersonelId " +
            "INNER JOIN Muayene ON ISB.muayeneId = Muayene.id " + 
            "WHERE Personel.sicilNo = '" + sicilNo + "'";

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            id = dt.Rows[index]["muayeneId"].ToString();
            
            sqlText = "SELECT * " + "FROM Muayene " + 
            "WHERE Muayene.id = " + id;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            tbx_MuayeneGoruntulemeEkrani.Text = "Tarih : " + dt.Rows[0]["tarih"] + Environment.NewLine +
            "Şikayet : " + dt.Rows[0]["sikayet"] + Environment.NewLine + 
            "Tanı : " + dt.Rows[0]["tanı"] + Environment.NewLine + 
            "Tedavi : " + dt.Rows[0]["tedavi"] + Environment.NewLine + 
            "Doktor : " + dt.Rows[0]["doktor"];
        }
    }
}
