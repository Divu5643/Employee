using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public class StateService : IStateService
    {
        private readonly EmployeeDbContext employeeContext;

        public StateService(EmployeeDbContext employeeContext)
        {

            this.employeeContext = employeeContext;
        }

        public List<State> GetAllStates()
        {
            List<State> stateList = (from state in employeeContext.States
                                         select state
                             ).ToList();
            return stateList;
        }
    }
}
