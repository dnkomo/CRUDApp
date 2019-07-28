using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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

        [HttpPost]
        public ActionResult Create(student tbl)
        {
            ObjectParameter para = new ObjectParameter("idout", typeof(int));
            int result = db.sp_insertupdate_student(tbl.id, tbl.firstName, tbl.lastName, tbl.homeAddress, tbl.phoneNumber, para);
            this.db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            sp_viewStudentById_Result obj = new sp_viewStudentById_Result();
            obj = db.sp_viewStudentById(id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(student tbl)
        {
            ObjectParameter para = new ObjectParameter("idout", typeof(int));
            int result = db.sp_insertupdate_student(tbl.id, tbl.firstName, tbl.lastName, tbl.homeAddress, tbl.phoneNumber, para);
            this.db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            sp_viewStudentById_Result obj = new sp_viewStudentById_Result();
            obj = db.sp_viewStudentById(id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            int result = db.sp_deleteStudentByID(id);
            this.db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}