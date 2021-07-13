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
using System.Diagnostics;

namespace Dijital_Revir
{
    public partial class ekran_Ek2EklemeVeGoruntuleme : Form
    {
        string sicil;
        DataTable dt;
        public ekran_Ek2EklemeVeGoruntuleme(string sicil)
        {
            InitializeComponent();
            this.sicil = sicil;     
        }

        private void Ek2EklemeVeGoruntuleme_Load(object sender, EventArgs e)
        {
            Ek2Listeleme(); 
        }

        private void Ek2Listeleme()
        {
            string sqlText;
            
            sqlText = "SELECT Ek2.id, Ek2.eklendiğiTarih " + 
            "FROM Ek2 " + 
            "INNER JOIN Personel on Personel.id = Ek2.personelId " + 
            "WHERE Personel.id = (SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + sicil + "')";

            dgv_pdf.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
        }

        private void btn_pdfEkle_Click(object sender, EventArgs e)
        {
            String path;
            Byte[] bytes;
            SqlParameter prm;
            String sqlText;

            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.ShowDialog();

            path = this.openFileDialog1.FileName;
            
            bytes = System.IO.File.ReadAllBytes(path);

            sqlText = "INSERT INTO Ek2 (pdf, eklendiğiTarih, personelId) " + 
            "VALUES (@ParameterName, GETDATE(), (SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + sicil + "'))";
            prm = new SqlParameter("@ParameterName", SqlDbType.VarBinary);
            prm.Value = bytes;

            SqlOps.SetParam(sqlText, prm);            
        }

        private void dgv_pdf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String sqlText = "SELECT Ek2.id, Ek2.pdf, Ek2.eklendiğiTarih " + 
            "FROM Ek2 " + 
            "INNER JOIN Personel ON Personel.id = Ek2.personelId " +
            "WHERE Personel.id = (SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + sicil + "')";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);

            int index = SqlOps.GetDataGridViewRowIndex(dgv_pdf, "id");            
            Byte[] bytes = (Byte[])dt.Rows[index]["pdf"];
            System.IO.File.WriteAllBytes("temp.pdf", bytes);

            String mesaj = "PDF Açılsın mı?";
            String baslik = "";
            MessageBoxButtons butonlar = MessageBoxButtons.YesNo;
            DialogResult sonuc = MessageBox.Show(mesaj, baslik, butonlar);

            if (sonuc == DialogResult.Yes)
            {
                Process ps = Process.Start("temp.pdf");
                ps.WaitForExit();
                System.IO.File.Delete("temp.pdf");
            }
        }
    }
}
