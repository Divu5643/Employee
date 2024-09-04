using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly EmployeeDbContext employeeContext;

        public PhoneService(EmployeeDbContext employeeContext)
        {

            this.employeeContext = employeeContext;
        }

        public Phone? getPhone(int empId)
        {
            var phone =  (from tempphone in employeeContext.Phones
                            where tempphone.EmployeeId == empId
                            select tempphone
                            ).FirstOrDefault();
            return phone;
        }
    }
}
