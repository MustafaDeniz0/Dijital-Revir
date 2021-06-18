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
    public partial class ekran_PersonelIslemleri : Form
    {
        public ekran_PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void btn_PersonelEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_PersonelEkleme();
            form.ShowDialog();
        }

        private void btn_PersonelCikar_Click(object sender, EventArgs e)
        {
            Form form = new ekran_PersonelCikarma();
            form.ShowDialog();
        }
    }
}
