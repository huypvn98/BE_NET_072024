using BE072024.Common_NetFrameWork;
using BE072024.DataAccess_NetFrameWork.DO;
using BE072024.DataAccess_NetFrameWork.DO.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoChangeOrderOracle
{
    public partial class frmAddEmp : Form
    {
        public List<Employee> _employees;
        public frmAddEmp(List<Employee> employees)
        {
            InitializeComponent();
            _employees = employees;
           cbx_FACTOR.SelectedIndex = 0;
            cbx_POSITION.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {      

                if(string.IsNullOrEmpty(txb_EMP_CODE.Text))
                {
                    MessageBox.Show("Mã nhân viên là trường bắt buộc!");
                    return;
                }

                //Kiểm tra đã tồn tại mã nhân viên trong _employees
                foreach (var emp in _employees)
                {
                    if (emp.EmpCode == txb_EMP_CODE.Text)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txb_EMP_NAME.Text))
                {
                    MessageBox.Show("Tên nhân viên là trường bắt buộc!");
                    return;
                }
                //Ràng buộc ngày start date phải nhỏ hơn hoặc bằng ngày hiện tại
                if (START_DT.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày vào công ty phải nhỏ hơn hoặc bằng ngày hiện tại!");
                    return;
                }

                _employees.Add(new Employee(txb_EMP_CODE.Text, txb_EMP_NAME.Text, START_DT.Value, cbx_POSITION.Text, cbx_FACTOR.Text));
                MessageBox.Show("Add Employee Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cbx_POSITION_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cbPosition = (ComboBox)sender;
                cbx_FACTOR.SelectedIndex = cbPosition.SelectedIndex;            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
