using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        StudentDB st = new StudentDB();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            List<StudentResult> str = st.StudentResults.ToList();
            return PartialView("_Student",str);
        }
        public PartialViewResult Pass()
        {
            List<StudentResult> str = st.StudentResults.Where(s => s.remarks.Equals("P")).ToList();
            return PartialView("_Student", str);
        }
        public PartialViewResult fail()
        {
            List<StudentResult> str = st.StudentResults.Where(s => s.remarks.Equals("F")).ToList();
            return PartialView("_Student", str);
        }
    }
}