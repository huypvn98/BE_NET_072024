using BE072024.DataAccess_NetFrameWork.DO;
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
    public partial class frmEmpLst : Form
    {
        public List<Employee> _employees;
        public frmEmpLst(List<Employee> employees)
        {
            InitializeComponent();
            _employees = employees;
        }

        private void frmEmpLst_Load(object sender, EventArgs e)
        {
            foreach(var emp in _employees)
            {
                // Tạo một đối tượng ListViewItem mới
                ListViewItem item = new ListViewItem(emp.EmpCode);
                // Thêm các giá trị cho các cột tiếp theo bằng cách sử dụng SubItems.Add()
                item.SubItems.Add(emp.EmpName);
                item.SubItems.Add(emp.EmpStartDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                item.SubItems.Add(emp.EmpPosition);
                item.SubItems.Add(emp.EmpFactor);
                // Thêm đối tượng ListViewItem vào ListView
                listView1.Items.Add(item);
            }   
        }
    }
}
