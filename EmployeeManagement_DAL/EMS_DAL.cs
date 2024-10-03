using EmployeeManagement_BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;


namespace EmployeeManagement_DAL
{
    public class EMS_DAL : IEMS_DAL
    {
        private readonly string conStr;

        public EMS_DAL(string connectionString)
        {
            conStr = connectionString;
        }


        // Insert into Employee table
        public void AddEmployee(EmployeeBO employee)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "INSERT INTO Employee (FirstName, LastName, Position, Salary, DepartmentID) " +
                                  "VALUES (@FirstName, @LastName, @Position, @Salary, @DepartmentID);";
                connection.Execute(sqlQuery, employee);
            }
        }

        // Retrieve all employees with their respective department details
        public DataTable GetEmployees()
        {
            // string query = "select * from employee e join department d on e.departmentid = d.departmentid";
            string query = "SELECT e.EmployeeID, e.firstName,e.lastname, e.Position,e.DepartmentID, d.DepartmentName FROM employee e JOIN department d ON e.DepartmentID = d.DepartmentID";

            var dataTable = new DataTable();
            using (var adapter = new SqlDataAdapter(query, conStr))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }


        // Get employee by ID, first check if emp exists or not.

        public EmployeeBO GetEmployeeById(int employeeId)
        {
            if (IsEmployeeExists(employeeId))
            {
                using (var connection = new SqlConnection(conStr))
                {
                    string sqlQuery = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID;";

                    return connection.QueryFirstOrDefault<EmployeeBO>(sqlQuery, new { EmployeeID = employeeId });
                }
            }
            else
            {
                return null;
            }
        }

        // Update
        public void UpdateEmployee(EmployeeBO employee)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "UPDATE Employee " +
                                  "SET FirstName = @FirstName, LastName = @LastName, Position = @Position, " +
                                  "Salary = @Salary, DepartmentID = @DepartmentID " +
                                  "WHERE EmployeeID = @EmployeeID;";
                connection.Execute(sqlQuery, employee);
            }
        }

        // Delete 
        public void DeleteEmployee(int employeeId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID;";
                connection.Execute(sqlQuery, new { EmployeeID = employeeId });
            }
        }
        //Helper Function
        public bool IsEmployeeExists(int employeeId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "SELECT COUNT(1) FROM Employee WHERE EmployeeID = @EmployeeID";
                int count = connection.ExecuteScalar<int>(sqlQuery, new { EmployeeID = employeeId });

                return count > 0;
            }
        }


        //////////////////////////////////////////////
        ///Department Functions


        // Insertertion
        public void AddDepartment(DepartmentBO department)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "INSERT INTO Department (DepartmentName, Budget) " +
                                  "VALUES (@DepartmentName, @Budget);";
                connection.Execute(sqlQuery, department);
            }
        }

        // Get all departments
        public List<DepartmentBO> GetDepartments()
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "SELECT * FROM Department;";
                return connection.Query<DepartmentBO>(sqlQuery).ToList();
            }
        }



        //Get department by ID
        public DepartmentBO GetDepartmentById(int departmentId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "SELECT * FROM Department WHERE DepartmentID = @DepartmentID;";
                return connection.QueryFirstOrDefault<DepartmentBO>(sqlQuery, new { DepartmentID = departmentId });
            }
        }

        // Update
        public void UpdateDepartment(DepartmentBO department)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "UPDATE Department " +
                                  "SET DepartmentName = @DepartmentName, Budget = @Budget " +
                                  "WHERE DepartmentID = @DepartmentID;";
                connection.Execute(sqlQuery, department);
            }
        }

        // Delete
        public void DeleteDepartment(int departmentId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "DELETE FROM Department WHERE DepartmentID = @DepartmentID;";
                connection.Execute(sqlQuery, new { DepartmentID = departmentId });
            }
        }

        //check weather dept exists or not
        public bool IsDepartmentExists(int departmentId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string sqlQuery = "select COUNT(1) FROM Department WHERE DepartmentID = @DepartmentID";
                int count = connection.ExecuteScalar<int>(sqlQuery, new { DepartmentID = departmentId });

                return count > 0;
            }
        }

        //Retrieve department-wise employee count and total salary.
        public DataTable GetDepartmentWiseDetails()
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(conStr))
            {
                string query = @"select d.DepartmentID,d.DepartmentName,COUNT(e.EmployeeID) AS TotalEmployees, SUM(e.Salary) AS TotalSalary from department d left join employee e on d.DepartmentID = e.DepartmentID
                               group by d.DepartmentID, d.DepartmentName";

                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }



        //GETting Budget of department
        public decimal GetDepartmentBudget(int departmentId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                string query = "select Budget from department where departmentID = @departmentId";
                var result =  connection.QueryFirstOrDefault<decimal>(query, new { DepartmentID = departmentId });

                return result;
            }
        }

        //Get total salary that has given to the emplyees in a department.
        public decimal GetTotalSalaryByDepartment(int departmentId)
        {
            using (var connection = new SqlConnection(conStr))
            {
                // SQL query to sum salaries of employees in the specified department
                string query = @"select SUM(Salary) from employee where DepartmentID = @departmentId";

                // Execute the query and return the total salary
                var result =  connection.QueryFirstOrDefault<decimal>(query, new { DepartmentID = departmentId });
                return result;
            }
        }


    }

}
