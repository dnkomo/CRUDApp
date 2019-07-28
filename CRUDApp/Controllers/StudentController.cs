using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDApp.Models;

namespace CRUDApp.Controllers
{
    public class StudentController : Controller
    {
        StudentEntities db = new StudentEntities();

        // GET: Student
        public ActionResult Index()
        {
            List<sp_ViewAllStudent_Result> result = new List<sp_ViewAllStudent_Result>();
            result = db.sp_ViewAllStudent().ToList();
            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(student tbl)
        //{

        //}
    }
}