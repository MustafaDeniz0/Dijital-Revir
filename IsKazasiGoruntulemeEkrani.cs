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
    public partial class ekran_IsKazasiGoruntuleme : Form
    {
        int indexIsKazasıId;
        public ekran_IsKazasiGoruntuleme(int indexIsKazasıId)
        {
            InitializeComponent();
            this.indexIsKazasıId = indexIsKazasıId;
        }

        private void ekran_IsKazasiGoruntuleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;

            sqlText = "SELECT IsKazası.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Departman.departmanAdi, Sirket.sirketAdi, IsKazası.kazaZamanı, IsKazası.kazaninAnlatımı " +
            "FROM Personel " + 
            "INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id " +
            "INNER JOIN Departman ON Departman.id = Personel.departmanId " +
            "INNER JOIN Sirket ON Sirket.id = Departman.sirketId " +
            "INNER JOIN IsKazası ON IsKazası.personelId = Personel.id " + 
            "WHERE IsKazası.id = " + indexIsKazasıId;
            
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            tbx_IsKazasıGoruntuleme.Text = "Sicil Numarası : " + dt.Rows[0]["sicilNo"].ToString() + Environment.NewLine +
            "İsim Soyisim : " + dt.Rows[0]["ad"].ToString() + " " + dt.Rows[0]["soyAd"].ToString() + Environment.NewLine +
            "Şirket-Bölüm : " + dt.Rows[0]["sirketAdi"].ToString() + dt.Rows[0]["departmanAdi"].ToString() + Environment.NewLine +
            "Kaza Zamanı : " + dt.Rows[0]["kazaZamanı"].ToString() + Environment.NewLine +
            "Kazanın Anlatımı : " + dt.Rows[0]["KazaninAnlatımı"].ToString();
        }
    }
}
