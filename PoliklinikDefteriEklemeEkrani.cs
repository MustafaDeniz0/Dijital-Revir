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
    public partial class ekran_PoliklinikEkleme : Form
    {
        public ekran_PoliklinikEkleme()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            String sqlText = "INSERT INTO Poliklinik (sıraNo, personelId, tanıGrubu, tanı, tarih, acıklama, sonuc) " + 
            "VALUES (" + 
            tbx_siraNo.Text + ", " +
            "SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + tbx_sicilNo.Text + "', '" +
            tbx_tanıGrubu.Text + "', '" +
            tbx_Tanı.Text + "', " +
            "getdate(), '" + 
            tbx_Acıklama.Text + "', '" +
            tbx_sonuc.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            
            MessageBox.Show("Ekleme işlemi Başarılı.");
            this.Close();
        }
    }
}
