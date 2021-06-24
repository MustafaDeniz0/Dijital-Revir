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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

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
            Form form = new ekran_SevkEtme(sicilNo);
            form.ShowDialog();
        }

        private void dataBaseyeIsKazasiEkle()
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

        private void btn_exceleaktar_Click(object sender, EventArgs e)
        {
            dataBaseyeIsKazasiEkle();
            hedefKlasorSec();
            saveToExcel();

            MessageBox.Show("Excel'e Aktarıldı.");
            this.Close();
        }

        private void hedefKlasorSec()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1.ShowDialog();
        }

        private void saveToExcel()
        {
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Application xlOrn;
            String targetPath;

            xlOrn = new Excel.Application();

            if (xlOrn == null)
            {
                MessageBox.Show("Excel yüklü değil!!");
                return;
            }

            Object misValue = System.Reflection.Missing.Value;

            String sourcePath = AppDomain.CurrentDomain.BaseDirectory + "ExcelFiles";

            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
            }

            String sqlText = "SELECT * FROM Personel " +
            "LEFT JOIN OzlukBilgileri ON OzlukBilgileri.id = Personel.ozlukId " +
            "LEFT JOIN Departman ON Departman.id = Personel.departmanId " +
            "WHERE Personel.sicilNo = '" + sicilNo + "'";

            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            targetPath = folderBrowserDialog1.SelectedPath.ToString();

            String fromFile = sourcePath + "\\EKOTEN İŞ KAZASI FORMU.xlsm";
            String toFile = targetPath + "\\isKazasi_" + dt.Rows[0]["ad"].ToString() + dt.Rows[0]["soyAd"].ToString() + "_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".xlsm";

            xlWorkBook = xlOrn.Workbooks.Open(fromFile, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlOrn.Visible = true;
            xlOrn.Range["K2"].Value = tbx_protokolNo.Text + ' ' +DateTime.Now.ToShortDateString();
            xlOrn.Range["C4"].Value = dt.Rows[0]["ad"].ToString() + " " + dt.Rows[0]["soyAd"].ToString();
            xlOrn.Range["C5"].Value = dt.Rows[0]["dogumTarihi"].ToString();
            xlOrn.Range["C6"].Value = dt.Rows[0]["iseGiris"].ToString();
            xlOrn.Range["C7"].Value = cmb_VardiyaAmiri.SelectedText;

            xlOrn.Range["I4"].Value = dtp_kazaZamani.Value.ToShortDateString();
            xlOrn.Range["I5"].Value = tbx_saat.Text;
            xlOrn.Range["I6"].Value = dt.Rows[0]["departmanAdi"].ToString();
            xlOrn.Range["I7"].Value = tbx_görev.Text;

            xlOrn.Range["B9"].Value = tbx_kazaAnlatimi.Text;

            try
            {
                xlWorkBook.Close(true, toFile, misValue);
                xlOrn.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex.ToString());
            }

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlOrn);
                xlOrn = null;
            }
            catch (Exception ex)
            {
                xlOrn = null;
                MessageBox.Show("Hata " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } // saveToExcel

        private void tbx_saat_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbx_saat.Clear();
        }
    }
}
