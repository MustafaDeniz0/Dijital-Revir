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
            
            sqlText = " select Ek2.id ,  Ek2.eklendiğiTarih  from Ek2 inner join Personel on Personel.id = Ek2.personelId where Personel.id = (select Personel.id from Personel where Personel.sicilNo = '" + sicil +"')";

            dgv_pdf.DataSource = SqlOps.CreateDataTableBySqlQuery(sqlText);
            

        }

        private void btn_pdfEkle_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.ShowDialog();

            String path = this.openFileDialog1.FileName;
            
            Byte[] bytes = System.IO.File.ReadAllBytes(path);

            String sqlText = "Insert into Ek2 (pdf, eklendiğiTarih, personelId) Values (@ParameterName,GETDATE(),(Select Personel.id From Personel Where Personel.sicilNo = '" + sicil + "')) ";
            SqlParameter prm = new SqlParameter("@ParameterName", SqlDbType.VarBinary);
            prm.Value = bytes;

            SqlOps.SetParam(sqlText, prm);
            
        }

        private void dgv_pdf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String sqlText = " select Ek2.id , Ek2.pdf , Ek2.eklendiğiTarih  from Ek2 inner join Personel on Personel.id = Ek2.personelId where Personel.id = (select Personel.id from Personel where Personel.sicilNo = '" + sicil + "')";
            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            int index = SqlOps.GetDataGridViewRowIndex(dgv_pdf, "id");            
            Byte[] bytes = (Byte[])dt.Rows[index]["pdf"];
            System.IO.File.WriteAllBytes("hello.pdf", bytes);
            //System.IO.File.OpenRead("hello.pdf");
            Process ps = Process.Start("hello.pdf");
            ps.WaitForExit();
             System.IO.File.Delete("hello.pdf"); 

            
            
            

        }
    }
}
