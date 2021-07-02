using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Dijital_Revir
{
    class TakipServisleri
    {
        public static void periyodikMuayene()
        {

        }
        public static void gebelikUpdate()
        {
            String sqlText = "Update Etiket Set gebemi = 1 Where Etiket.personalId in ( Select  Gebelik.personelId From Gebelik Where Gebelik.Gebemi = 1)";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "Update Etiket set gebemi = 0 where not exists (	Select * from Gebelik	where Etiket.personalId = Gebelik.personelId)";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

        }
        public static void gebelikTakip(ListBox lbx)
        {
            String sqlText = "Select  Gebelik.personelId, DATEDIFF(day, Gebelik.sonAdetTarihi , GETDATE())as 'Gün' From Gebelik  Where Gebelik.personelId  in(Select Personel.id From Personel )";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            String dogum = "Doğum gerçekleşti ise gebelik işlemini bitiriniz.";
            foreach (DataRow dr in dt.Rows) {
                String sqlText1 = "Select OzlukBilgileri.ad , OzlukBilgileri.soyAd From OzlukBilgileri Where OzlukBilgileri.id = (Select Personel.ozlukId From Personel Where Personel.id = "+dr["personelId"].ToString()+")";
                DataTable dt1 = SqlOps.CreateDataTableBySqlQuery(sqlText1);
                String ad = dt1.Rows[0]["ad"].ToString() + " " + dt1.Rows[0]["soyAd"].ToString()+" aylık kontrol zamanı geldi.";
                
                if (Convert.ToInt32(dr["Gün"]) >0 && 2 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 30 && 33 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 60 && 63 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 90 && 93 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 120 && 123 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 150 && 153 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 180 && 183 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 210 && 213 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 240 && 242 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 270 && 272 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(ad); }
                if (Convert.ToInt32(dr["Gün"]) > 280 && 282 > Convert.ToInt32(dr["Gün"])) { lbx.Items.Add(dogum); }
            }
        }
    }
}
