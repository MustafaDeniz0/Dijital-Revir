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
    public partial class ekran_PoliklinikEklemeEkranı : Form
    {
        public ekran_PoliklinikEklemeEkranı()
        {
            InitializeComponent();
        }

        

        private void PoliklinikEklemeEkranı_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {
            String sqlText = "Insert into Poliklinik (sıraNo,personelId,tanıGrubu,tanı,tarih,acıklama,sonuc) Values ("+tbx_siraNo.Text+", (Select Personel.id From Personel Where Personel.sicilNo = '"+tbx_sicilNo.Text+"'),'"+tbx_tanıGrubu.Text+"','"+tbx_Tanı.Text+"',getdate(),'"+tbx_Acıklama.Text+"','"+tbx_sonuc.Text+"')";
            SqlOps.SqlExecute(sqlText, null, SqlOps.GetSqlConnection());
            MessageBox.Show("Ekleme işlemi Başarılı.");
            this.Close();

        }
    }
}
