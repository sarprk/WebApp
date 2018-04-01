using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPost]
        public void Save(Employee employee)
        {

        }

        public ActionResult Index()
        {
            return View("Save", new Employee());
        }
    }
}