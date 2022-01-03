using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is default action";
        }
        public string GetStudentName()
        {
            return "Hemanth Kumar";
        }
    }
}
