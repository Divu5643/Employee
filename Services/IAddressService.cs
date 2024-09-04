using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public interface IAddressService
    {
        public Address GetAddress(int empId);
    }
}
