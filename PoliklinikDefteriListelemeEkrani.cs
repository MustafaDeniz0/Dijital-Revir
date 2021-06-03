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
    public partial class ekran_PoliklinikDefteriListeleme : Form
    {
        public ekran_PoliklinikDefteriListeleme()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_PoliklinikEklemeEkranı();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new ekran_PoliklinikDefteriGoruntuleme();
            form.ShowDialog();
        }
    }
}
