using BE072024.DataAccess_NetFrameWork.DO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BE_07.WindowsForm
{
    public partial class frmEmployeeManagement : Form
    {
        public List<Employee> _employees;
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee;
                if(rdoFulltime.Checked)
                {


                    employee = new FulltimeEmployee(txbEmpName.Text, txbEmpCode.Text, double.Parse(txbSalary.Text), double.Parse(txbAllowance.Text));
                }
                else
                {
                    employee = new ParttimeEmployee(txbName.Text, txbID.Text, double.Parse(txbSalary.Text), int.Parse(txbAllowance.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void rdoFulltime_Click(object sender, EventArgs e)
        {
            try 
            {
                txbAllowance.Clear();
                lblSalary.Text = "Lương cơ bản";
                lblAllowance.Text = "Phụ cấp";

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void rdoParttime_Click(object sender, EventArgs e)
        {
            try
            {
                txbAllowance.Clear();
                lblSalary.Text = "Lương theo giờ";
                lblAllowance.Text = "Số giờ làm";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
