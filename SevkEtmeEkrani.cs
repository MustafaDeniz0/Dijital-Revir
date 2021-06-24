using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dijital_Revir
{
    public partial class ekran_SevkEtme : Form
    {
        String sicil;
        public ekran_SevkEtme(String sicil)
        {
            InitializeComponent();
            this.sicil = sicil;
        }

        private void ekran_SevkEtme_Load(object sender, EventArgs e)
        {

        }
        private void btn_excelAktar_Click(object sender, EventArgs e)
        {
            hedefKlasorSec();
            saveToExcel();

            String sqlText = "INSERT INTO HastaSevk (protokolNo, tarih, ozgecmis, calisilanBolumOzelligi, sevkEdilenBolum, onTanı, personelId) " +
            "VALUES ('" + 
            tbx_protokolNo.Text + "', '" +
            SqlOps.SqlDateInsert(dtp_sevk.Value.Date,"00:00") + "', '" + 
            tbx_ozgecmis.Text + "', '" + 
            tbx_calisilanBolumOzelligi.Text + "', '" +
            tbx_sevkEdilenBolum.Text + "', '" +
            tbx_onTanı.Text + "', " + 
            " (SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + sicil + "'))";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());

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

            String sqlText = "SELECT OzlukBilgileri.ad, OzlukBilgileri.soyAd, OzlukBilgileri.tcNo " +
            "FROM (OzlukBilgileri " +
            "LEFT JOIN Personel ON Personel.ozlukId = OzlukBilgileri.id) Where Personel.sicilNo = " + sicil;

            DataTable dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            targetPath = folderBrowserDialog1.SelectedPath.ToString();

            String fromFile = sourcePath + "\\EKOTEN HASTA SEVK FORMU.xlsx";
            String toFile = targetPath + "\\" + dt.Rows[0]["ad"].ToString() + dt.Rows[0]["soyAd"].ToString() + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".xlsx";

            xlWorkBook = xlOrn.Workbooks.Open(fromFile, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlOrn.Visible = true;
            xlOrn.Range["L5"].Value = dtp_sevk.Value.ToShortDateString();
            xlOrn.Range["L6"].Value = tbx_protokolNo.Text;
            xlOrn.Range["F8"].Value = dt.Rows[0]["ad"].ToString() + " " + dt.Rows[0]["soyAd"].ToString();
            xlOrn.Range["F9"].Value = dt.Rows[0]["tcNo"].ToString();
            xlOrn.Range["F10"].Value = tbx_ozgecmis.Text;
            xlOrn.Range["F11"].Value = tbx_calisilanBolumOzelligi.Text;
            xlOrn.Range["F12"].Value = tbx_sevkEdilenBolum.Text;
            xlOrn.Range["F13"].Value = tbx_onTanı.Text;

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
    }
}
