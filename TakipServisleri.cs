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
            String sqlText;

            sqlText = "UPDATE Etiket SET gebemi = 1 " + 
            "WHERE Etiket.personalId " + 
            "IN (SELECT Gebelik.personelId FROM Gebelik WHERE Gebelik.Gebemi = 1)";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            sqlText = "UPDATE Etiket SET gebemi = 0 " +
            "WHERE NOT EXISTS (SELECT * FROM Gebelik WHERE Etiket.personalId = Gebelik.personelId)";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
        }
        public static void gebelikTakip(ListBox lbx)
        {
            String sqlText;
            DataTable dt;
            DataTable dt1;

            sqlText = "SELECT Gebelik.personelId, DATEDIFF(day, Gebelik.sonAdetTarihi, GETDATE()) as 'Gün' " + 
            "FROM Gebelik " + 
            "WHERE Gebelik.personelId IN (SELECT Personel.id FROM Personel)";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            foreach (DataRow dr in dt.Rows) {
                sqlText = "SELECT OzlukBilgileri.ad, OzlukBilgileri.soyAd " +
                "FROM OzlukBilgileri " +
                "WHERE OzlukBilgileri.id = (SELECT Personel.ozlukId FROM Personel WHERE Personel.id = " + dr["personelId"].ToString() + ")";
                dt1 = SqlOps.CreateDataTableBySqlQuery(sqlText);

                int gun = Convert.ToInt32(dr["Gün"]);
                String personelIsmi = dt1.Rows[0]["ad"].ToString() + " " + dt1.Rows[0]["soyAd"].ToString() ;
                String gebePersonel = personelIsmi + " aylık kontrol zamanı geldi.";        
                String uyari = personelIsmi + " Doğum gerçekleşti ise gebelik işlemini bitiriniz.";

                if (gun > 0 && 2 > gun) { 
                    lbx.Items.Add(gebePersonel);
                } else if (gun > 30 && 33 > gun) { 
                    lbx.Items.Add(gebePersonel);
                } else if (gun > 60 && 63 > gun) { 
                    lbx.Items.Add(gebePersonel); 
                } else if (gun > 90 && 93 > gun) { 
                    lbx.Items.Add(gebePersonel); 
                } else if (gun > 120 && 123 > gun) { 
                    lbx.Items.Add(gebePersonel); 
                } else if (gun > 150 && 153 > gun) {
                    lbx.Items.Add(gebePersonel);
                } else if (gun > 180 && 183 > gun) {
                    lbx.Items.Add(gebePersonel); 
                } else if (gun > 210 && 213 > gun) {
                    lbx.Items.Add(gebePersonel);
                } else if (gun > 240 && 243 > gun) {
                    lbx.Items.Add(gebePersonel);
                } else if (gun > 270 && 273 > gun) {
                    lbx.Items.Add(gebePersonel);
                } else if (gun > 280 && 283 > gun) { 
                    lbx.Items.Add(uyari);
                }
            }
        }
    }
}
