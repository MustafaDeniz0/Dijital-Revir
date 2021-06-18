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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ekran_IsKazasiGoruntuleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;

            sqlText = "Select IsKazası.id ,Personel.sicilNo,OzlukBilgileri.ad ,OzlukBilgileri.soyAd,Departman.departmanAdi, Sirket.sirketAdi ,IsKazası.kazaZamanı ,IsKazası.kazaninAnlatımı from  " +
             "((((Personel Inner join OzlukBilgileri On Personel.ozlukId = OzlukBilgileri.id)" +
            "Inner join Departman on Departman.id = Personel.departmanId)" +
            "Inner join Sirket on Sirket.id = Departman.sirketId)" +
            "Inner join IsKazası on IsKazası.personelId = Personel.id) where IsKazası.id = "+ indexIsKazasıId;
            
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            tbx_IsKazasıGoruntuleme.Text = "Sicil Numarası : " + dt.Rows[0]["sicilNo"].ToString() +
                                        "\r\n İsim Soyisim : " + dt.Rows[0]["ad"].ToString() + " " + dt.Rows[0]["soyAd"].ToString() +
                                              "\r\n Şirket-Bölüm : " + dt.Rows[0]["sirketAdi"].ToString() + dt.Rows[0]["departmanAdi"].ToString()+
                                             
                                              "\r\n Kaza Zamanı : " + dt.Rows[0]["kazaZamanı"].ToString() +
                                              "\r\n Kazanın Anlatımı : " + dt.Rows[0]["KazaninAnlatımı"].ToString();

        }
    }
}
