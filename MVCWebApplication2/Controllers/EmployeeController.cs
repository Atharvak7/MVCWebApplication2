using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApplication2.Models;

namespace MVCWebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee emp = new Employee()
            {
                EmployeeId = 7,
                name = "abc",
                gender = "Male",
                city = "Mumbai"
            };
            return View(emp);
        }
    }
}