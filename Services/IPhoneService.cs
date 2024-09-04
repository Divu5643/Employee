using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public interface IPhoneService
    {
        public Phone? getPhone(int empId);
    }
}
