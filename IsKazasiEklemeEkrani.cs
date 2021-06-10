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
        String sicil;
        public ekran_IsKazasıEkleme(String sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ekran_SevkEtme();
            form.ShowDialog();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            int indexId;
            String sqlText;
            sqlText = "Select Personel.id From Personel where Personel.sicilNo =  '" + sicil+ "';";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            indexId = (int)dt.Rows[0]["id"];
            int index = (int)cmb_VardiyaAmiri.SelectedValue;
            
           
            sqlText = "Insert Into IsKazası(amirId, calismaSuresi, kazaZamanı, kazaninAnlatımı, personelId) " +
            "Values("+index+",'"+ tbx_calismaSuresi.Text+ "','" + SqlOps.SqlDateInsert(dtp_kazaZamani.Value.Date,tbx_saat.Text) + "','" + tbx_kazaAnlatimi.Text + "',"+indexId +");";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekran_IsKazasıEkleme_Load(object sender, EventArgs e)
        {
            cmb_VardiyaAmiri.Items.Clear();
            String sqlText = "Select Distinct OzlukBilgileri.ad,OzlukBilgileri.soyAd , P2.id From Personel P1 , Personel P2 left Join OzlukBilgileri on OzlukBilgileri.id = P2.ozlukId where P1.amir = P2.id;";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            

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
