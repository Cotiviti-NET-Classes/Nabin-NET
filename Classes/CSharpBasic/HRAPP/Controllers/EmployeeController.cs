using System.Collections.Generic;
using HRAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRAPP.Controllers
{
    public class EmployeeController: Controller
    {
        public IActionResult Home()
       {
           Employee employees=new Employee()
           {
            ID=1, name="Dinesh Tamang", contactNo="0987654321", JoiningDate=System.DateTime.Now, Gender=Enum.Gender.Male
           };
           return View(employees);
        }
       public IActionResult Add()
       {
           return View();
       }
       public IActionResult Update()
       {
           return View();
       }
        public IActionResult Delete()
       {
           return View();
       }
    }
}