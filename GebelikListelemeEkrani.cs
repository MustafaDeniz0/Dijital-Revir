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
    public partial class ekran_GebelikListeleme : Form
    {
        public ekran_GebelikListeleme()
        {
            InitializeComponent();
        }

        private void btn_AraButonu_Click(object sender, EventArgs e)
        {

        }

        private void dgv_gebelikListesi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new ekran_GebelikTakip();
            form.ShowDialog();
        }
    }
}
