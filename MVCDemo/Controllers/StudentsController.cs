using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students

        public ActionResult Index()
        {
           var students= GetListOfStudents();

            return View(students);
        }

        // GET: Students/Details/5
        //? means nullable
        // without ? means non nullable
        public ActionResult Details(int id)
        {
            var student = GetListOfStudents().Where(x=>x.StudentId==id).FirstOrDefault();
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        public ActionResult Created(StudentsDTO student)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Students/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      [NonAction]
      //Mock the Data 
      //entity framework 
        public IEnumerable<StudentsDTO> GetListOfStudents()
        {

            List<StudentsDTO> studentsDTOs= new List<StudentsDTO>();

            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 1,
                Name = "John",
                Age = 25,
                City = "Melbournne"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 2,
                Name = "Abraham",
                Age = 35,
                City = "Sydney"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 3,
                Name = "Yuvi",
                Age = 36,
                City = "Jalandar"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 4,
                Name = "ABC",
                Age = 52,
                City = "California"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 5,
                Name = "BBC",
                Age = 25,
                City = "London"
            });
            return studentsDTOs;
        }
    }
}
