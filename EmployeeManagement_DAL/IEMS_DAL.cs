using EmployeeManagement_BO;
using System.Collections.Generic;
using System.Data;

namespace EmployeeManagement_DAL
{
    public interface IEMS_DAL
    {
        void AddDepartment(DepartmentBO department);
        void AddEmployee(EmployeeBO employee);
        void DeleteDepartment(int departmentId);
        void DeleteEmployee(int employeeId);
        DepartmentBO GetDepartmentById(int departmentId);
        List<DepartmentBO> GetDepartments();
        DataTable GetDepartmentWiseDetails();
        EmployeeBO GetEmployeeById(int employeeId);
        DataTable GetEmployees();
        decimal GetDepartmentBudget(int departmentId);
        decimal GetTotalSalaryByDepartment(int departmentId);
        bool IsDepartmentExists(int departmentId);
        bool IsEmployeeExists(int employeeId);
        void UpdateDepartment(DepartmentBO department);
        void UpdateEmployee(EmployeeBO employee);
    }
}