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
    public partial class SearchEmpForm : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public SearchEmpForm(EmployeeBLL empBLL)
        {
            _employeeBLL = empBLL;
            InitializeComponent();
        }
        string query;
        private void GetEmpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = textQuery.Text;
                DataTable dataTable = _employeeBLL.EmployeeSearch(query);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    SearchEmployeesdataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No such Employee Exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
