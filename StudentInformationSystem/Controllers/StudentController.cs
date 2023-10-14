using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace StudentInformationSystem.Controllers
{
    public class StudentController : Controller
    {
        // /Student
        public IActionResult Index()
        {
            return View();
        }

        //public string Details()
        //{
        //    return "This Page Displays Student Details";
        //}

        // // /Student/Details
        //public string Details(int ID)
        //{
        //    if (ID > 0)
        //    {
        //        return HtmlEncoder.Default.Encode($"This page displays details of student with id = {ID} information");
        //    }
        //    return HtmlEncoder.Default.Encode($"This page displays details of all students");

        // }

        // /Student/Details/5?name=""
        public IActionResult Details(string name, int ID = 1)
        {
            ViewData["Message"] = name;
            ViewData["Id"] = ID;
            return View();
        }
    }
    }
