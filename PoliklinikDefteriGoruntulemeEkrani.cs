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
    public partial class ekran_PoliklinikDefteriGoruntuleme : Form
    {
        int sıraId;
        public ekran_PoliklinikDefteriGoruntuleme(int sıraId)
        {
            InitializeComponent();
            this.sıraId = sıraId;
        }

        private void ekran_PoliklinikDefteriGoruntuleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;

            sqlText = "SELECT Poliklinik.id, Personel.sicilNo, OzlukBilgileri.ad, OzlukBilgileri.soyAd, Departman.departmanAdi, Sirket.sirketAdi, Poliklinik.tarih, Poliklinik.acıklama, Poliklinik.sonuc, Poliklinik.tanı, Poliklinik.tanıGrubu " +
            "FROM Personel " + 
            "INNER JOIN OzlukBilgileri ON Personel.ozlukId = OzlukBilgileri.id " +
            "INNER JOIN Departman ON Departman.id = Personel.departmanId " +
            "INNER JOIN Sirket ON Sirket.id = Departman.sirketId " +
            "INNER JOIN Poliklinik ON Poliklinik.personelId = Personel.id " + 
            "WHERE Poliklinik.id = " + sıraId;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            tbx_PoliklinikGoruntuleme.Text = "Sicil Numarası : " + dt.Rows[0]["sicilNo"].ToString() + Environment.NewLine +
            "İsim-Soyisim : "       + dt.Rows[0]["ad"].ToString() + " " + dt.Rows[0]["soyAd"].ToString() + Environment.NewLine +
            "Şirket-Departman : "   + dt.Rows[0]["sirketAdi"].ToString() + " " + dt.Rows[0]["departmanAdi"].ToString() + Environment.NewLine +
            "Tarih : "              + dt.Rows[0]["tarih"].ToString() + Environment.NewLine +
            "Açıklama : "           + dt.Rows[0]["acıklama"].ToString() + Environment.NewLine +
            "Sonuç : "              + dt.Rows[0]["sonuc"].ToString() + Environment.NewLine +
            "Tanı : "               + dt.Rows[0]["tanı"].ToString() + Environment.NewLine +
            "Tanı Grubu : "         + dt.Rows[0]["tanıGrubu"].ToString();
        }
    }
}
