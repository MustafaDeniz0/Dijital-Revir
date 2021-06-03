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
    public partial class ekran_IsbMuayeneEkleme : Form
    {
        public ekran_IsbMuayeneEkleme()
        {
            InitializeComponent();
        }

        private void btn_Muayene_Click_1(object sender, EventArgs e)
        {
            Form form = new ekran_MuayeneEkleme();
            form.ShowDialog();
        }
    }
}
