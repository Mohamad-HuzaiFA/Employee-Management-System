using EmployeeManagement_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AllDeptForm : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public AllDeptForm(EmployeeBLL empBLL)
        {
            _employeeBLL = empBLL;
            InitializeComponent();
        }

        
        private void GetDeptBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = _employeeBLL.GetAllDepts();
            DepartmentsdataGridView.DataSource = dt;
        }
    }
}
