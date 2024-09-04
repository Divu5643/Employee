using EmpolyeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpolyeeManagement.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly EmployeeDbContext employeeContext;

        public EmployeeService(EmployeeDbContext employeeContext) {
        
            this.employeeContext = employeeContext;
        }
        public void CreateEmployee(Employee emp) {
            employeeContext.Add(emp);
            employeeContext.SaveChanges();


        }

        public List<Employee> GetAllEmployess()
        {
            List<Employee> employeeList = (from emp in employeeContext.Employees
                                           where emp.IsDeleted == false
                                           select emp).ToList();

             return employeeList;
                                           
        }
        public Employee GetEmployee(int id) {
        Employee emp =  employeeContext.Employees.Find(id);
            return emp;
        }
        
        public void DeleteEmployee(int empId) {
            Employee tempEmployee = new Employee()
            { 
            EmployeeId = empId,
            IsDeleted = true
            };
            employeeContext.Remove(tempEmployee);
            employeeContext.SaveChanges();
        }
    }
}
