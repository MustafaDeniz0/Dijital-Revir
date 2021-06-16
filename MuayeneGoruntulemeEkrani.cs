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
        String sicil;
        int index;
        public MuayeneGoruntulemeEkrani(String sicil,int index)
        {
            InitializeComponent();
            this.sicil = sicil;
            this.index = index;
        }

        

        private void MuayeneGoruntulemeEkrani_Load(object sender, EventArgs e)
        {
            String sqlText = "Select * From ((ISB inner join Personel on Personel.id = ISB.PersonelId) inner join Muayene on ISB.muayeneId = Muayene.id) Where Personel.sicilNo = '" + sicil + "'; ";
            DataTable dt1 = SqlOps.CreateDataTableBySqlQuery(sqlText);
            String id = dt1.Rows[index]["muayeneId"].ToString();
            sqlText = "Select*From Muayene Where Muayene.id = " + id + ";";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            tbx_MuayeneGoruntulemeEkrani.Text = "\r\n \r\n \r\n Tarih : " + dt.Rows[0]["tarih"] + "\r\n Şikayet : " + dt.Rows[0]["sikayet"] + "\r\n Tanı : " + dt.Rows[0]["tanı"] + "\r\n Tedavi : " + dt.Rows[0]["tedavi"] + "\r\n Doktor : " + dt.Rows[0]["doktor"];

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
