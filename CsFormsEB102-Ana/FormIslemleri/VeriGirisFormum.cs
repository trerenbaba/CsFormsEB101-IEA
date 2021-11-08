using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFormsEB102_Ana.FormIslemleri
{
    public partial class VeriGirisFormum : Form
    {
        public VeriGirisFormum()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFiyati.Clear();
            txtUrunIsmı.Clear();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            VeriSonucFormum veri = new VeriSonucFormum();
            veri.txtUrunIsmi.Text = txtUrunIsmı.Text;
            veri.txtUrunFiyati.Text = txtFiyati.Text;
            double kdv = Convert.ToDouble(veri.txtUrunFiyati.Text) * 0.18;
            double toplam = Convert.ToDouble(veri.txtUrunFiyati.Text) * 1.18;
            veri.txtKdvFiyati.Text = kdv.ToString();
            veri.txtToplamFiyati.Text = toplam.ToString();
            veri.Show();



        }
    }
}
