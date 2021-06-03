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
    public partial class ekran_CovidListeleme : Form
    {
        public ekran_CovidListeleme()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_covidListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new ekran_CovidTakipEkrani();
            form.ShowDialog();
        }

        private void dgv_covidListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new ekran_CovidTakipEkrani();
            form.ShowDialog();
        }
    }
}
