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
    public partial class frmAlCons : Form
    {
        public frmAlCons()
        {
            InitializeComponent();
        }
        public frmAlCons(List<ModelKisi> elist)
        {
            InitializeComponent();
            dataGridView1.DataSource = elist;
        }

        private void frmAlCons_Load(object sender, EventArgs e)
        {

        }
    }
}
