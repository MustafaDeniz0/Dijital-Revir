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
        String sicilNo;
        String sikayet;

        public ekran_PoliklinikEkleme()
        {
            InitializeComponent();
        }

        public ekran_PoliklinikEkleme(String sicilNo, String sikayet)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
            this.sikayet = sikayet;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            String sqlText = "INSERT INTO Poliklinik (personelId, tanıGrubu, tanı, tarih, acıklama, sonuc) " + 
            "VALUES ( " +
            "(SELECT Personel.id FROM Personel WHERE Personel.sicilNo = '" + tbx_sicilNo.Text + "'), '" +
            tbx_tanıGrubu.Text + "', '" +
            tbx_Tanı.Text + "', " +
            "getdate(), '" + 
            tbx_Acıklama.Text + "', '" +
            tbx_sonuc.Text + "')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            
            MessageBox.Show("Ekleme işlemi Başarılı.");
            this.Close();
        }

        private void ekran_PoliklinikEkleme_Load(object sender, EventArgs e)
        {
            tbx_Tanı.Text = sikayet;
            tbx_sicilNo.Text = sicilNo;
        }
    }
}
