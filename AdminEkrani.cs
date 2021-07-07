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
    public partial class ekran_Admin : Form
    {
        public ekran_Admin()
        {
            InitializeComponent();
        }

        private void ekran_Admin_Load(object sender, EventArgs e)
        {
            upLoad();
        }

        private void upLoad()
        {
            String sqlText;
            DataTable dt;
            ComboBox cbx = new ComboBox();

            cbx.Items.Clear();

            sqlText = "SELECT DISTINCT Sirket.sirketAdi, Sirket.id FROM Sirket";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            foreach (DataRow dr in dt.Rows)
            {
                cbx.Items.Add(new System.Collections.DictionaryEntry(dr["sirketAdi"].ToString(), dr["id"].ToString()));
            }

            cbx_sirketAdi1.DisplayMember = "Key";
            cbx_sirketAdi1.ValueMember = "Value";
            cbx_sirketAdi1.DataSource = cbx.Items;

            cbx_SirketAdi2.DisplayMember = "Key";
            cbx_SirketAdi2.ValueMember = "Value";
            cbx_SirketAdi2.DataSource = cbx.Items;

            cbx_silinecekSirketAdi.DisplayMember = "Key";
            cbx_silinecekSirketAdi.ValueMember = "Value";
            cbx_silinecekSirketAdi.DataSource = cbx.Items;
        }

        private void btn_departmanEkle_Click(object sender, EventArgs e)
        {
            String sqlText = "Insert into Departman (departmanAdi,sirketId) Values ('" + tbx_eklenecekDepartmanAdi.Text + "', " + cbx_SirketAdi2.SelectedValue + ")";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            upLoad();

            MessageBox.Show("Departman Eklendi. ");
        }

        private void btn_departmanSil_Click(object sender, EventArgs e)
        {
            String sqlText = "Delete Departman From Departman Where Departman.id = "+ cbx_silinecekDepartmanAdi.SelectedValue;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            upLoad();
            MessageBox.Show("Departman Silindi. ");
        }

        private void btn_sirketEkle_Click(object sender, EventArgs e)
        {
            String sqlText = "Insert into Sirket (Sirket.sirketAdi) Values ('"+tbx_eklenecekSirketAdi.Text+ "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            upLoad();
            MessageBox.Show("Şirket Eklendi. ");
        }

        private void btn_sirketSil_Click(object sender, EventArgs e)
        {
            String sqlText = "Delete Sirket From Sirket Where Sirket.id = " + cbx_silinecekSirketAdi.SelectedValue;
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            upLoad();
            MessageBox.Show("Şirket Silindi. ");
        }

        private void cbx_SirketAdi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx;
            String sqlText;
            DataTable dt;

            cbx = new ComboBox();

            sqlText = "SELECT DISTINCT Departman.departmanAdi, Departman.id " +
            "FROM Departman " +
            "WHERE Departman.sirketId = " + cbx_SirketAdi2.SelectedValue;
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            
            cbx.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbx.Items.Add(new System.Collections.DictionaryEntry(dr["departmanAdi"].ToString(), dr["id"].ToString()));
            }

            cbx_silinecekDepartmanAdi.DisplayMember = "Key";
            cbx_silinecekDepartmanAdi.ValueMember = "Value";
            cbx_silinecekDepartmanAdi.DataSource = cbx.Items;
        }

        private void tbx_eklenecekDepartmanAdi_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_eklenecekDepartmanAdi.Clear();
        }

        private void tbx_Sirket_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_eklenecekSirketAdi.Clear();
        }

        private void btn_personelSorgula_Click(object sender, EventArgs e)
        {
            String sqlText = "Select OzlukBilgileri.ad , OzlukBilgileri.soyAd From OzlukBilgileri Where OzlukBilgileri.id = (Select Personel.ozlukId From Personel Where Personel.sicilNo = '"+tbx_sicilNo.Text+"')";
            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            lbl_personelAdi.Text = dt.Rows[0]["ad"] + " " + dt.Rows[0]["soyAd"];
        }

        private void btn_amirOlarakAta_Click(object sender, EventArgs e)
        {
            String sqlText = "UPDATE Personel " +
            "SET amir = (Select Personel.id FROM Personel WHERE Personel.sicilNo = '" + tbx_sicilNo.Text + "') " + 
            "WHERE Personel.sicilNo = '" + tbx_sicilNo.Text + "'";

            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            MessageBox.Show("Amir olarak eklendi.");     
        }
    }
}
