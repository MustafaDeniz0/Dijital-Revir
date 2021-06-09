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
    public partial class ekran_IsKazasıEkleme : Form
    {
        public ekran_IsKazasıEkleme()
        {
            InitializeComponent();
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
            DateTime date = dtp_kazaZamani.Value;



            //String sqlText = "Insert Into IsKazası(amirId, kazaZamanı, kazaninAnlatımı, personelId) " +
            //"Values('" +  + "','" + tbx_sikayet.Text + "','" + tbx_tani.Text + "','" + tbx_tedavi.Text + "','" + tbx_doktor.Text + "');";
            //SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekran_IsKazasıEkleme_Load(object sender, EventArgs e)
        {
            cmb_VardiyaAmiri.Items.Clear();
            String sqlText = "Select Distinct OzlukBilgileri.ad,OzlukBilgileri.soyAd From Personel P1 , Personel P2 left Join OzlukBilgileri on OzlukBilgileri.id = P2.ozlukId where P1.amir = P2.id";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            

            foreach (DataRow dr in dt.Rows)
            {
                String obj = dr["ad"] + " " + dr["soyAd"];
                cmb_VardiyaAmiri.Items.Add(new System.Collections.DictionaryEntry(obj, dr["soyAd"].ToString()));
            }

            cmb_VardiyaAmiri.DisplayMember = "Key";
            cmb_VardiyaAmiri.ValueMember = "Value";
            cmb_VardiyaAmiri.DataSource = cmb_VardiyaAmiri.Items;
        }
    }
}
