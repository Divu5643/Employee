
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EmpolyeeManagement.Services;

namespace EmpolyeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;
    

        public HomeController(ILogger<HomeController> logger , IEmployeeService employeeService)
        {
            _logger = logger;
            
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employeeList = _employeeService.GetAllEmployess();
            
            ViewBag.Employess = employeeList;
            


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
