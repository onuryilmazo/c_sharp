using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string messsage = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", messsage);
        }
        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Ahmet", LastName="Yilmaz", Age=19},  
                new Employee(){Id=2, FirstName="Onur", LastName="Yılmaz", Age=21},
                new Employee(){Id=3, FirstName="Cagla", LastName="Genel", Age=20},
            
            };
            
            return View("Index3", list);
        }
    }
}