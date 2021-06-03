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
    public partial class ekran_IsKazasiListeleme : Form
    {
        public ekran_IsKazasiListeleme()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {

        }

        private void dgv_isKazaListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new ekran_IsKazasiGoruntuleme();
            form.ShowDialog();
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            Form form = new ekran_IsKazasıEkleme();
            form.ShowDialog();
        }
    }
}
