using CsFormsEB102_Ana.FormIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsEB102_Ana.OgrenciIsleri;

namespace CsFormsEB102_Ana
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        #region PnlUst Paneli
        private void button1_Click(object sender, EventArgs e)
        {
            gbSol.Text = button1.Text;
            Paneller();
            pnl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSol.Text = btnOgr.Text;
            Paneller();
            pnl2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSol.Text = button3.Text;
            Paneller();
            pnl3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbSol.Text = button4.Text;
            Paneller();
            pnl4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbSol.Text = button5.Text;
            Paneller();
            pnl5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gbSol.Text = button6.Text;
            Paneller();
            pnl6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gbSol.Text = button7.Text;
            Paneller();
            pnl7.Visible = true;
        }
        void Paneller()
        {
            gbSol.Visible = true;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Form Islemleri
        private void btnGonderProp_Click(object sender, EventArgs e)
        {
            FrmGonderProp frm = new FrmGonderProp();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnGonderCons_Click(object sender, EventArgs e)
        {
            frmGonderCons frm = new frmGonderCons();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btnCollaps_Click(object sender, EventArgs e)
        {
            if (gbSol.Visible == true)
            {
                gbSol.Visible = false;
                btnCollaps.Text = "GÖSTER";
            }
            else if (gbSol.Visible == false)
            {
                gbSol.Visible = true;
                btnCollaps.Text = "GİZLE";
            }
        }


        #endregion

        private void btnUrunFiyat_Click(object sender, EventArgs e)
        {
            VeriGirisFormum veri = new VeriGirisFormum();
            veri.MdiParent = Form.ActiveForm;
            veri.WindowState = FormWindowState.Maximized;
            veri.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            frmBolumGiris frm = new frmBolumGiris();
            frm.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmOgrenciGiris frm = new frmOgrenciGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
