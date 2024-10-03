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
    public partial class AddEmpForm : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public AddEmpForm(EmployeeBLL empBLL)
        {
            _employeeBLL = empBLL;
            InitializeComponent();
        }

        string FName;
        string LastName;
        string position;
        string Salary;
        string deptID;
        int sal,id;
        private void submitBtn_Click(object sender, EventArgs e)
        {
            FName = textfName.Text;
            LastName = textLName.Text;
            position = textposition.Text;    
            Salary = textsalary.Text;
            deptID = textdeptid.Text;

            
            if (!int.TryParse(Salary, out sal))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            try
            {
                sal = Convert.ToInt32(Salary);
                id = Convert.ToInt32(deptID);
                bool isEmpAdded = _employeeBLL.AddEmployee(FName,LastName,position,sal,id);

                if (isEmpAdded)
                {
                    MessageBox.Show("Employee has Added Successfully.");
                    this.Close(); // Close the form after successful addition after each emp adds
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//In case of Exceptions
            }

        }
    }
}
