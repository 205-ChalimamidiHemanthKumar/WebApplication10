using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> departments = new List<Department>();
            departments.Add(new Department() { DeptId = 205, DeptName = "IT Department", DeptLocation = "Bangalore" });
            departments.Add(new Department() { DeptId = 205, DeptName = "Marketing", DeptLocation = "Madanapalle" });
            departments.Add(new Department() { DeptId = 205, DeptName = "Developing", DeptLocation = "Chennai" });

            ViewData["departments"] = departments;
            return View();
        }
    }
}
