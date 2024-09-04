using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public class CountryService : ICountryService
    {
        private readonly EmployeeDbContext employeeContext;

        public CountryService(EmployeeDbContext employeeContext)
        {

            this.employeeContext = employeeContext;
        }
        public List<Country> GetAllCountries()
        {
            List<Country> countryList = (from country in employeeContext.Countries
                             select country
                             ).ToList();
            return countryList;


        }
    }
}
