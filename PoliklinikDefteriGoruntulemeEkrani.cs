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
        int sıraNo;
        public ekran_PoliklinikDefteriGoruntuleme(int sıraNo)
        {
            InitializeComponent();
            this.sıraNo = sıraNo;
        }

        private void ekran_PoliklinikDefteriGoruntuleme_Load(object sender, EventArgs e)
        {

            String sqlText;
            DataTable dt;

            sqlText = "Select Poliklinik.id ,Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd,Departman.departmanAdi, Sirket.sirketAdi ,Poliklinik.tarih ,Poliklinik.acıklama,Poliklinik.sonuc,Poliklinik.tanı,Poliklinik.tanıGrubu from  " +
             "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)" +
            "Inner join Departman on Departman.id = Personel.departmanId)" +
            "Inner join Sirket on Sirket.id = Departman.sirketId)" +
            "Inner join Poliklinik on Poliklinik.personelId = Personel.id) where Poliklinik.sıraNo = "+sıraNo;

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            tbx_PoliklinikGoruntuleme.Text = "Sicil Numarası : " + dt.Rows[0]["sicilNo"].ToString() +
                                        "\r\n İsim Soyisim : " + dt.Rows[0]["ad"].ToString() + " " + dt.Rows[0]["soyAd"].ToString() +
                                              "\r\n Şirket-Bölüm : " + dt.Rows[0]["sirketAdi"].ToString() + dt.Rows[0]["departmanAdi"].ToString() +

                                              "\r\n Tarih : " + dt.Rows[0]["tarih"].ToString() +
                                              "\r\n Açıklama : " + dt.Rows[0]["acıklama"].ToString()+
                                              "\r\n Sonuç : "+ dt.Rows[0]["sonuc"].ToString()+
                                              "\r\n Tanı : "+ dt.Rows[0]["tanı"].ToString()+
                                              "\r\n Tanı Grubu : "+ dt.Rows[0]["tanıGrubu"].ToString();
        }
    }
}
