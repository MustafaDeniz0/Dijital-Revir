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
    public partial class ekran_GebelikTakip : Form
    {
        String sicil;
        public ekran_GebelikTakip(String sicil)
        {
            this.sicil = sicil;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Gebelik_Ekrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_degerEkle_Click(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikDegerleriEkleme();
            form.ShowDialog();
        }

        private void btn_degerEkle_Click_1(object sender, EventArgs e)
        {
            Form form = new ekran_GebelikDegerleriEkleme();
            form.ShowDialog();
        }
    }
}
