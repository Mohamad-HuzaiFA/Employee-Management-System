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
    public partial class DelEmpForm : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public DelEmpForm(EmployeeBLL empBLL)
        {
            _employeeBLL = empBLL;
            InitializeComponent();
        }

        string id;
        private void DelEmpBtn_Click(object sender, EventArgs e)
        {
            id = idHolder.Text;
            int _empId;

            if (!int.TryParse(id, out _empId))
            {
                MessageBox.Show("Invalid Employee ID. Please enter a valid number.");
                this.Close();  // Close the form if the input is invalid
                return;
            }

            try
            {
                if (_empId <= 0)
                {
                    MessageBox.Show("Invalid Employee ID. Please enter a valid number.");
                    this.Close();  // Close the form if the input is invalid
                    return;
                }
                else
                {
                    bool status = _employeeBLL.DeleteEmplyee(_empId);
                    if (status)
                    {
                        MessageBox.Show("Successfully Deleted");
                    }
                }
            }
            catch(Exception ex) {
             MessageBox.Show(ex.Message);
            }


        }
    }
}
