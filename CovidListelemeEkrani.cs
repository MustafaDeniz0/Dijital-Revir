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
        String sicil = "";
        DataTable dt = new DataTable();

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

        private void dgv_covidListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = SqlOps.GetDataGridViewRowIndex(dgv_covidListesi, "sicilNo");
            sicil = dt.Rows[index]["sicilNo"].ToString();

            Form form = new ekran_CovidTakipEkrani(sicil);
            form.ShowDialog();
        }
    }
}
