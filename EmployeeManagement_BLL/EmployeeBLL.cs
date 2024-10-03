using EmployeeManagement_BO;
using EmployeeManagement_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_BLL
{
    public class EmployeeBLL
    {
        private readonly IEMS_DAL _dal;

        public EmployeeBLL(IEMS_DAL dal)
        {
            _dal = dal;
        }

        public bool AddEmployee(string firstName, string lastName, string position, int sal, int deptId)
        {
            if (!(_dal.IsDepartmentExists(deptId)) || deptId == null)
            {
                throw new ArgumentException("InValid DeptID, Please Enter valid ID.");
            }

            if (sal <= 0)
            {
                throw new ArgumentException("Invalid Salary Entered.");
            }
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Please Fill the FirstName and LastName Fields.");
            }
            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Please Fill the Position Field.");
            }
            var departmentBudget = _dal.GetDepartmentBudget(deptId);
            var availableBudget = _dal.GetTotalSalaryByDepartment(deptId);

            if (sal > (int)departmentBudget)
            {
                throw new ArgumentException($"Entered Salary {sal} exceeds the Department Budget.");
            }

            if (sal > (int)availableBudget)
            {
                throw new ArgumentException($"Entered Salary {sal} exceeds the Available Budget of Department {deptId}.");
            }




            EmployeeBO emp = new EmployeeBO { FirstName = firstName, LastName = lastName, Position = position, Salary = sal, DepartmentID = deptId };
            _dal.AddEmployee(emp);

            return true;

        }
        //returns all emplyees with department details
        public DataTable GetAll()
        {
            return _dal.GetEmployees();
        }

        //returns deparment wise details
        public DataTable GetAllDepts()
        {

            return _dal.GetDepartmentWiseDetails(); 
        }

        public DataTable EmployeeSearch(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                var employees = _dal.GetEmployees();
                DataTable dt = employees.Clone();

                foreach (DataRow row in employees.Rows)
                {
                    // Check FirstName, Position, and DepartmentName for a match
                    if (row["FirstName"].ToString().ToLower() == query.ToLower() ||
                        row["Position"].ToString().ToLower() == query.ToLower() ||
                        row["DepartmentName"].ToString().ToLower() == query.ToLower())
                    {
                        dt.ImportRow(row);
                    }
                }

                return dt;
            }
            else
            {
                throw new ArgumentException("Please Enter a Valid Query");
            }
        }

        //This will updates the employee after checking if it exists or not
        public bool UpdateEmployee(int empid,string position,decimal sal,int deptid)
        // Import the matching row into the new DataTable
        {
            if (sal <= 0 || empid <= 0 || deptid <= 0)
            {
                throw new ArgumentException("Please Enter Valid Number.");
            }


            if (!_dal.IsDepartmentExists(deptid))
            {
                throw new ArgumentException($"Department with ID:{deptid} does not exist");
            }
            if(!_dal.IsEmployeeExists(empid))
            {
                throw new ArgumentException($"Employee with ID:{empid} does not exist.");
            }

            var departmentBudget = _dal.GetDepartmentBudget(deptid);
            var availableBudget = _dal.GetTotalSalaryByDepartment(deptid);

            if(sal > (int)departmentBudget)
            {
                throw new ArgumentException($"Entered Salary {sal} exceeds the Department Budget.");
            }

            if (sal > (int)availableBudget)
            {
                throw new ArgumentException($"Entered Salary {sal} exceeds the Available Budget of Department {deptid}.");
            }

            var employee = _dal.GetEmployeeById(empid);
            employee.Position = position;
            employee.Salary = sal;
            employee.DepartmentID = deptid;

            _dal.UpdateEmployee(employee);

            return true;
        }




        //Deletes the Employee based on the ID.
        public bool DeleteEmplyee(int id)
        {
            if (!(_dal.IsEmployeeExists(id)))
            {
                throw new ArgumentException("No Employee Exists with this ID.");
            }
            else
            {
                _dal.DeleteEmployee(id);
                return true;
            }

        }
    }
}
