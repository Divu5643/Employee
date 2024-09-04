using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public class AddressService : IAddressService
    {
        private readonly EmployeeDbContext employeeContext;

        public AddressService(EmployeeDbContext employeeContext)
        {

            this.employeeContext = employeeContext;
        }

        public Address? GetAddress(int empId)
        {
            var address = (from Address in employeeContext.Addresses
                               where Address.EmployeeId == empId
                               select Address
                               ).FirstOrDefault();

            return address;
        }
    }
}
