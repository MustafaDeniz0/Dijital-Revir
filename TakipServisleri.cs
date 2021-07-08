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
        public static int periyodikMuayene(int indexId)
        {
            String sqlText = "Select Etiket.engellilik,Etiket.gebemi , Sirket.sirketAdi From Etiket "+
                             "inner join Sirket on Sirket.id = (Select Departman.sirketId From Departman Where Departman.id = (Select Personel.departmanId From Personel Where Personel.id = "+ indexId+")) " +
                             "Where Etiket.personalId = " + indexId;
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            if ((bool)dt.Rows[0]["gebemi"]) { return 6; }
            else if (dt.Rows[0]["sirketAdi"].ToString()=="Ekoten") { return 36; }
            else if ((bool)dt.Rows[0]["engellilik"]) { return 36; }
            else { return 60; }
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
        
        public static void periyodikMuayeneTarihHesaplama(Label label,int indexId)
        {
            String sqlText = "Select sıradakiPerMuayene From Personel Where Personel.id = "+ indexId;
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            
            if (dt.Rows[0][0].Equals(null)) {
                sqlText = "Update Personel Set sıradakiPerMuayene = DATEADD(month," + periyodikMuayene(indexId) + ",sonPeriyodikMuayene) ";
                SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            }
            label.Text = "Sıradaki Periyodik Tarih zamanı : " + dt.Rows[0][0].ToString();

        }

        public static void periyodikMuayeneTakip(ListBox lbx)
        {
            String sqlText = "Select Personel.id, DATEDIFF(day,GETDATE(),Personel.sıradakiPerMuayene) as tarih From Personel Where sonPeriyodikMuayene IS NOT NULL";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            foreach (DataRow dr in dt.Rows)
            {
                // periyodik muayenede sıradaki hesaplaması anasayfada yapman lazım

               if((int)dr[1]<10) 
               {
                    sqlText = " Select Personel.sicilNo From Personel Where Personel.id = " + dr[0].ToString();
                    DataTable dt1 = SqlOps.CreateDataTableBySqlQuery(sqlText);
                    lbx.Items.Add("Sicil Numarası "+dt1.Rows[0][0]+" olan Personelin Periyodik Muayenesine Son " +dr[1].ToString()+" Gün.");

               }

            }
        }
    }
}
