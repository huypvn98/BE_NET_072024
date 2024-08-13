using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BE_07.WindowsForm
{
    public partial class frmMain7 : Form
    {
        public frmMain7()
        {
            InitializeComponent();
        }

        private void btnGeometryOptions_Click(object sender, EventArgs e)
        {
            frmGeometryManagement frm = new frmGeometryManagement();
            frm.ShowDialog();
        }
    }
}
