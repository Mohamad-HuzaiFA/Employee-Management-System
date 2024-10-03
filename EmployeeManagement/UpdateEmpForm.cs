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
    public partial class UpdateEmpForm : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public UpdateEmpForm(EmployeeBLL empBLL)
        {
            _employeeBLL = empBLL;
            InitializeComponent();
        }

        string id;
        string position;
        string Salary;
        string deptID;
        int _id,_deptid;
        int sal;
        private void submitBtn_Click(object sender, EventArgs e)
        {
            id = empidtext.Text;
            position = positiontext.Text;
            Salary = salarytext.Text;
            deptID = deptidtext.Text;


            if (!int.TryParse(Salary, out sal))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            if (!int.TryParse(id, out _id))
            {
                MessageBox.Show("Please enter a valid EmployeeID.");
                return;
            }
            
            if (!int.TryParse(deptID, out _deptid))
            {
                MessageBox.Show("Please enter a valid DeptID.");
                return;
            }

            try
            {
                bool isEmpUpdated = _employeeBLL.UpdateEmployee(_id, position, sal, _deptid);

                if (isEmpUpdated)
                {
                    MessageBox.Show("Employee has Updated Successfully.");
                    this.Close(); // Close the form after successful addition after each update
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//In case of Exceptions
            }

        }
    }
}
