using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsEB102_Ana.Entity;

namespace CsFormsEB102_Ana.FormIslemleri
{
    public partial class frmGonderCons : Form
    {
        public frmGonderCons()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            List<ModelKisi> eList = db.Employees.Select(x => new ModelKisi
            {
                Ad = x.FirstName,
                Soyad = x.LastName
            }).ToList();
            frmAlCons frm = new frmAlCons(eList);
            frm.Show();


        }
    }
}
