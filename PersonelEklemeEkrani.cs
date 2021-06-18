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
            String sqlText = "insert into OzlukBilgileri (tcNo,ad,soyad,cinsiyet,dogumTarihi,telefonNo) values('"+tbx_tc.Text+"','"+tbx_isim.Text+ "','" + tbx_soyisim.Text + "',"+Cinsiyet()+ ",'" + tbx_dogumTarihi.Text + "','" + tbx_telefonNo.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            sqlText = "insert into Personel (sicilNo,ozlukId,departmanId,amir,iseGiris) Values ('" + tbx_sicil.Text + "',(Select Top 1 OzlukBilgileri.id From OzlukBilgileri Order by OzlukBilgileri.id Desc) ,"+cbx_departman.SelectedValue+ "," + cbx_amir.SelectedValue + ",'"+ SqlOps.SqlDateInsert(dtp_iseGiris.Value.Date, "00:00") + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            MessageBox.Show("Personel Eklendi ");
            this.Close();
        }

        private void PersonelEklemeEkrani_Load(object sender, EventArgs e)
        {
            cbx_amir.Items.Clear();
            String sqlText = "Select Distinct OzlukBilgileri.ad,OzlukBilgileri.soyAd , P2.id From Personel P1 , Personel P2 left Join OzlukBilgileri on OzlukBilgileri.id = P2.ozlukId where P1.amir = P2.id;";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);


            foreach (DataRow dr in dt.Rows)
            {
                String obj = dr["ad"] + " " + dr["soyAd"];
                cbx_amir.Items.Add(new System.Collections.DictionaryEntry(obj, dr["id"]));
            }

            cbx_amir.DisplayMember = "Key";
            cbx_amir.ValueMember = "Value";
            cbx_amir.DataSource = cbx_amir.Items;
////////////////////////////////////////////////////////////////
            cbx_Sirket.Items.Clear();
            sqlText = "Select Distinct Sirket.sirketAdi , Sirket.id From Sirket ";
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
            ComboBox cbx = new ComboBox();
            String sqlText = "Select Distinct Departman.departmanAdi ,Departman.id From Departman where Departman.sirketId = "+ cbx_Sirket.SelectedValue ;
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

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
            if(cbx_cinsiyet.SelectedItem.ToString() == "Erkek") { return 1; }
            else if(cbx_cinsiyet.SelectedItem.ToString() == "Kadın") { return 0; }
            return 2;
        }
    }
}
