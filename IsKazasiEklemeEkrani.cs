using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dijital_Revir
{
    public partial class ekran_IsKazasıEkleme : Form
    {
        String sicilNo;

        public ekran_IsKazasıEkleme(String sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
        }

        private void btn_SevkEt_Click(object sender, EventArgs e)
        {
            Form form = new ekran_SevkEtme();
            form.ShowDialog();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            int indexId;
            String sqlText;
            DataTable dt;
            int index;

            sqlText = "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = " + sicilNo;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            indexId = (int)dt.Rows[0]["id"];
            index = (int)cmb_VardiyaAmiri.SelectedValue;
            
            sqlText = "INSERT INTO IsKazası(amirId, calismaSuresi, kazaZamanı, kazaninAnlatımı, personelId) " +
            "VALUES(" + index  + ",'" + tbx_calismaSuresi.Text + "','" + SqlOps.SqlDateInsert(dtp_kazaZamani.Value.Date,tbx_saat.Text) + "','" + tbx_kazaAnlatimi.Text + "'," + indexId + ")";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            
            this.Close();
        }

        private void ekran_IsKazasıEkleme_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;

            cmb_VardiyaAmiri.Items.Clear();

            sqlText = "SELECT DISTINCT OzlukBilgileri.ad, OzlukBilgileri.soyAd, P2.id " + 
            "FROM Personel P1, Personel P2 LEFT JOIN OzlukBilgileri ON OzlukBilgileri.id = P2.ozlukId " + 
            "WHERE P1.amir = P2.id";

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);        

            foreach (DataRow dr in dt.Rows)
            {
                String obj = dr["ad"] + " " + dr["soyAd"];
                cmb_VardiyaAmiri.Items.Add(new System.Collections.DictionaryEntry(obj, dr["id"]));
            }

            cmb_VardiyaAmiri.DisplayMember = "Key";
            cmb_VardiyaAmiri.ValueMember = "Value";
            cmb_VardiyaAmiri.DataSource = cmb_VardiyaAmiri.Items;
        }
    }
}
