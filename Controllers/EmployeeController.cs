using EmpolyeeManagement.Models;
using EmpolyeeManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpolyeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ICountryService _countryService;
        private readonly IStateService _stateService;
        private readonly IAddressService _addressService;
        private readonly IPhoneService _phoneService;



        public EmployeeController(IEmployeeService employeeService,
            ICountryService countryService, IStateService stateService, IAddressService addressService, IPhoneService phoneService) {
            _countryService = countryService;
            _employeeService = employeeService;
            _stateService = stateService;
            _addressService = addressService;
            _phoneService = phoneService;
        }
        public IActionResult Create() {
            var countryList = _countryService.GetAllCountries();
            ViewBag.Countries = countryList;
            var stateList = _stateService.GetAllStates();
            ViewBag.States = stateList;

            return View();
        }

        [HttpPost]
        public IActionResult Addemployee(Employee emp) {

            _employeeService.CreateEmployee(emp);

            return RedirectToAction("index", "Home");
        }
        //Details Route
        [HttpGet("Employee/Details/{empId:int}")]
        public IActionResult Details(int empId)
        {
            Employee emp = _employeeService.GetEmployee(empId);
            ViewBag.Employee = emp;
            Address address = _addressService.GetAddress(empId);
            ViewBag.Address = address;
            Phone phone = _phoneService.getPhone(empId);
            ViewBag.phone = phone;

            return View();
        }
        //Delete Route
        [HttpGet("Employee/Delete/{empId:int}")]
        public IActionResult Delete(int empId) {
            _employeeService.DeleteEmployee(empId);
            return RedirectToAction("index", "Home");
        }
        //Edit Route

        [HttpGet("Employee/Edit/{empId:int}")]
        public IActionResult Edit(int empId) {
            ViewBag.EmpId = empId;
            var countryList = _countryService.GetAllCountries();
            ViewBag.Countries = countryList;
            var stateList = _stateService.GetAllStates();
            ViewBag.States = stateList;

            return View();
        }

        [HttpPost]
        public void EditEmployee(int id, string FirstName, string LastName) {

            System.Diagnostics.Debug.WriteLine("Hello:" + FirstName + " " + LastName+id);
        
        }
        [HttpPost]
        public void EditPhone(int id, string FirstName, string LastName)
        {

            System.Diagnostics.Debug.WriteLine("Hello:" + FirstName + " " + LastName + id);

        }
    }
}
