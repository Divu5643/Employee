using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public interface IEmployeeService
    {
        public void CreateEmployee(Employee emp);
        List<Employee> GetAllEmployess();

        public void DeleteEmployee(int empId);
        public Employee GetEmployee(int id);
    }
}
