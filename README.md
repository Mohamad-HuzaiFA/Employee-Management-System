Objective:
The objective of this homework is to help students implement an application using 
N- Tier architecture in .NET, while making use of Dependency Injection (DI) to promote 
loose coupling between layers.
Case Study: Employee Management System
Develop a simple Employee Management System that allows users to manage employee 
records. The system should provide functionality to create, update, delete, and search for 
employee details. The application must follow the N- Tier architecture with:
1. Presentation Layer (Console Application): Responsible for user interaction, displaying 
results, and collecting input.
2. Business Logic Layer (BLL): Manages business rules, validation logic, and controls the 
data flow between the presentation and data access layers.
3. Data Access Layer (DAL): Handles interaction with the database for CRUD (Create, 
Read, Update, Delete) operations.
Tasks:
1. Database Setup:
 Create a SQL Server database named EmployeeDB with the following tables:
a) Employee:
o EmployeeID (Primary Key)
o FirstName
o LastName
o Position
o Salary
o DepartmentName
b) Department:
o DepartmentID (Primary Key)
o DepartmentName
o Budget
 Include SQL scripts to populate the tables with sample data (optional).
2. Data Access Layer (DAL):
 Create a class library project named EmployeeManagementDAL.
 Define methods for CRUD operations on Employee and Department tables.
 Include methods to:
o Retrieve all employees with their respective department details.
o Retrieve department-wise employee count and total salary.
3. Business Logic Layer (BLL):
 Create a class library project named EmployeeManagementBLL.
 This layer should interact with the DAL and implement complex business logic, 
including:
a) Employee Creation:
o Validate if the department exists before assigning it to an employee.
o Ensure that the salary is within a valid range.
b) Employee Updates:
o Validate that the employee exists before updating their details.
o Ensure that salary updates are within valid limits for the employee's 
department.
o Reassigning an employee's department should check if the 
department has available budget.
c) Employee Deletion:
o Validate if the employee exists before deletion.
d) Department-wise Employee Analysis:
o Calculate the total salary spent in each department.
o Implement logic to ensure departments do not exceed their budget 
when hiring new employees.
e) Employee Search:
o Implement search functionality by employee name, department, or 
position.
4. Presentation Layer (Console Application):
 Create a console application project named EmployeeManagement.
 Develop a user-friendly menu that allows users to:
o List all employees (with department details).
o Add a new employee (with department and salary validation).
o Update an employee’s details (change department, position, or salary).
o Delete an employee by ID.
o List all departments with total employees and total salary.
o Search for employees by name, department, or position.
