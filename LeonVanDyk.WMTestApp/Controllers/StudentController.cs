using LeonVanDyk.WMTestApp.DAL;
using LeonVanDyk.WMTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeonVanDyk.WMTestApp.Controllers
{
    public class StudentController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Student
        public ActionResult Index()
        {
            var students = unitOfWork.StudentRepository.GetStudents();

            ViewBag.MayAddStudent = (User.Identity.IsAuthenticated && User.IsInRole("Admin"));

            return View(students.ToList());

        }

        //not used, functionality replaced by bootstrap Modal on Index form
        [Authorize(Roles ="Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]        
        public ContentResult Create([Bind(Include = "Salutation,FirstName,Surname,Age,Gender")] Student student)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.StudentRepository.InsertStudent(student);
                unitOfWork.Save();

                //return RedirectToAction("Index");
                var result = true;
                return Content(result ? "OK" : String.Empty);
            }

            //return View(student);
            return Content(String.Empty);
        }


        public JsonResult Get(Int32 id)
        {
            return Json(unitOfWork.StudentRepository.GetStudentByID(id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]        
        public ContentResult Update([Bind(Include = "StudentID,Salutation,FirstName,Surname,Age,Gender")] Student student)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.StudentRepository.UpdateStudent(student);
                unitOfWork.Save();

                var result = true;
                return Content(result ? "OK" : String.Empty);
            }

            //return View(student);
            return Content(String.Empty);
        }


    }
}