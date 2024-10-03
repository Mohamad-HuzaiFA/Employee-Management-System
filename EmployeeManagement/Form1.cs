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
    public partial class Main : Form
    {
        private readonly EmployeeBLL employeeBLL;
        public Main(EmployeeBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmpForm emp = new AddEmpForm(employeeBLL);
            this.Hide();//It will hide the menu form as AddEmployee btn is clicked
            emp.ShowDialog();
            this.Show();//This will show the menu form again
 

        }

        private void GetEmployees_Click(object sender, EventArgs e)
        {
            GetEmpForm emp = new GetEmpForm(employeeBLL);
            this.Hide();//It will hide the menu form as AddEmployee btn is clicked
            emp.ShowDialog();
            this.Show();//This will show the menu form again

        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmpForm emp = new UpdateEmpForm(employeeBLL);
            this.Hide();//It will hide the menu form as AddEmployee btn is clicked
            emp.ShowDialog();
            this.Show();//This will show the menu form again
        }

        private void DeleteById_Click(object sender, EventArgs e)
        {
            DelEmpForm emp = new DelEmpForm(employeeBLL);
            this.Hide();//It will hide the menu form as AddEmployee btn is clicked
            emp.ShowDialog();
            this.Show();//This will show the menu form again
        }

        private void ListAllDepts_Click(object sender, EventArgs e)
        {
            AllDeptForm emp = new AllDeptForm(employeeBLL);
            this.Hide();//It will hide the menu form as AddEmployee btn is clicked
            emp.ShowDialog();
            this.Show();//This will show the menu form again
        }
        private void SearchEmp_Click(object sender, EventArgs e)
        {
            SearchEmpForm emp = new SearchEmpForm(employeeBLL);
            this.Hide();//It will hide the menu form as AddEmployee btn is clicked
            emp.ShowDialog();
            this.Show();//This will show the menu form again
        }
    }
}
