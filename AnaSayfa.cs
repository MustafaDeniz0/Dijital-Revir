using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Dijital_Revir
{
	public partial class ekran_AnaSayfa : Form
	{
		public ekran_AnaSayfa()
		{
			InitializeComponent();
		}

		private void btn_personelArama_Click(object sender, EventArgs e)
		{
			String targetText = tbx_AramaCubugu.Text;
			Form form = new ekran_PersonelListeleme(targetText);
			form.ShowDialog();

			tbx_AramaCubugu.Text = getDefaultTextOfAramaCubugu();
		}

		private String getDefaultTextOfAramaCubugu()
        {
			return "Sicil No ya da İsim Giriniz";
		}

		private void btn_PoliklinikDefteri_Click(object sender, EventArgs e)
        {
			Form form = new ekran_PoliklinikDefteriListeleme();
			form.ShowDialog();
		}

        private void btn_Covid_Click(object sender, EventArgs e)
        {
			Form form = new ekran_CovidListeleme();
			form.ShowDialog();
		}

        private void btn_IsKazasi_Click(object sender, EventArgs e)
        {
			Form form = new ekran_IsKazasiListeleme();
			form.ShowDialog();
		}

        private void btn_Gebelik_Click(object sender, EventArgs e)
        {
			Form form = new ekran_GebelikListeleme();
			form.ShowDialog();
			TakipServisleri.gebelikUpdate();
		}

        private void tbx_AramaCubugu_MouseClick(object sender, MouseEventArgs e)
        {
			this.tbx_AramaCubugu.Clear();
		}

        private void btn_personelIslemleri_Click(object sender, EventArgs e)
        {
			Form form = new ekran_PersonelIslemleri();
			form.ShowDialog();
		}

        private void ekran_AnaSayfa_Load(object sender, EventArgs e)
        {
			TakipServisleri.gebelikUpdate();
			TakipServisleri.gebelikTakip(lbx_Bildirimler);
			TakipServisleri.periyodikMuayeneTakip(lbx_Bildirimler);
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
			if (ModifierKeys.HasFlag(Keys.Control))
			{
				Form form = new ekran_Admin();
				form.ShowDialog();
			}
		}
    }
}
