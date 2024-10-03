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
    public partial class GetEmpForm : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public GetEmpForm(EmployeeBLL empBLL)
        {
            _employeeBLL = empBLL;
            InitializeComponent();
        }

        private void GetEmpBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = _employeeBLL.GetAll();
            EmployeesdataGridView.DataSource = dataTable;
        }
    }
}
