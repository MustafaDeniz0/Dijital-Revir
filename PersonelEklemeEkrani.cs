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
    public partial class ekran_PersonelEkleme : Form
    {
        public ekran_PersonelEkleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sqlText;
            
            sqlText = "INSERT INTO OzlukBilgileri (tcNo, ad, soyad, cinsiyet, dogumTarihi, telefonNo) " + 
            "VALUES ('" + 
            tbx_tc.Text + "','" + 
            tbx_isim.Text + "','" + 
            tbx_soyisim.Text + "'," + 
            Cinsiyet() + ",'" + 
            tbx_dogumTarihi.Text + "','" + 
            tbx_telefonNo.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            
            sqlText = "INSERT INTO Personel (sicilNo, ozlukId, departmanId, amir, iseGiris) " + 
            "VALUES ('" +
            tbx_sicil.Text + "', " + 
            "SELECT TOP 1 OzlukBilgileri.id FROM OzlukBilgileri ORDER BY OzlukBilgileri.id DESC" + ", " +
            cbx_departman.SelectedValue + ", " + 
            cbx_amir.SelectedValue + ", '" + 
            SqlOps.SqlDateInsert(dtp_iseGiris.Value.Date, "00:00") + "')";

            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

            MessageBox.Show("Personel Eklendi ");
            this.Close();
        }

        private void PersonelEklemeEkrani_Load(object sender, EventArgs e)
        {
            String sqlText;
            DataTable dt;

            cbx_amir.Items.Clear();
            sqlText = "SELECT DISTINCT OzlukBilgileri.ad, OzlukBilgileri.soyAd, P2.id " + 
            "FROM Personel P1, Personel P2 " + 
            "LEFT JOIN OzlukBilgileri ON OzlukBilgileri.id = P2.ozlukId " + 
            "WHERE P1.amir = P2.id";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            foreach (DataRow dr in dt.Rows)
            {
                String obj = dr["ad"] + " " + dr["soyAd"];
                cbx_amir.Items.Add(new System.Collections.DictionaryEntry(obj, dr["id"]));
            }

            cbx_amir.DisplayMember = "Key";
            cbx_amir.ValueMember = "Value";
            cbx_amir.DataSource = cbx_amir.Items;

            cbx_Sirket.Items.Clear();

            sqlText = "SELECT DISTINCT Sirket.sirketAdi, Sirket.id FROM Sirket";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            foreach(DataRow dr in dt.Rows)
            {
                cbx_Sirket.Items.Add(new System.Collections.DictionaryEntry(dr["sirketAdi"], dr["id"].ToString()));
            }

            cbx_Sirket.DisplayMember = "Key";
            cbx_Sirket.ValueMember = "Value";
            cbx_Sirket.DataSource = cbx_Sirket.Items;       
        }

        private void cbx_Sirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx;
            String sqlText;
            DataTable dt;

            cbx = new ComboBox();

            sqlText = "SELECT DISTINCT Departman.departmanAdi, Departman.id " + 
            "FROM Departman " + 
            "WHERE Departman.sirketId = " + cbx_Sirket.SelectedValue;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            foreach (DataRow dr in dt.Rows)
            {
                cbx.Items.Add(new System.Collections.DictionaryEntry(dr["departmanAdi"], dr["id"].ToString()));
            }

            cbx_departman.DisplayMember = "Key";
            cbx_departman.ValueMember = "Value";
            cbx_departman.DataSource = cbx.Items;
        }

        private int Cinsiyet()
        {
            if(cbx_cinsiyet.SelectedItem.ToString() == "Erkek") {
                return 1;
            }
            else if(cbx_cinsiyet.SelectedItem.ToString() == "Kadın") { 
                return 0; 
            }
            return 2;
        }
    }
}
