using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijital_Revir
{
    class TakipServisleri
    {
        public static void periyodikMuayene()
        {

        }
        public static void gebelikUpdate()
        {
            String sqlText = "Update Etiket Set gebemi = (Select Gebelik.Gebemi From Gebelik Where Gebelik.personelId = Etiket.personalId)";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
        }
        public static void gebelikTakip()
        {

        }
    }
}
