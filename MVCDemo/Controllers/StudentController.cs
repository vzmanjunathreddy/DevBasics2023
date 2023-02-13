using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(string orders, string searchString)
        {
            List<string> passion = new List<string>() { "Dance", "Cricket", "Hockey" };
            ViewBag.Orders = new SelectList(passion);
                                
            IEnumerable<Student> students=GetListOfStudents();
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
        public IEnumerable<Student> GetListOfStudents()
        {
            List<Student> listofStudents = new List<Student>();

            try
            {
                listofStudents.Add(new Student() { StudentId = 1, Name = "Manju", City = "Bangalore", State = "KA", Country = "IN" });
                listofStudents.Add(new Student() { StudentId = 2, Name = "MS", City = "HYD", State = "KA", Country = "IN" });
                listofStudents.Add(new Student() { StudentId = 3, Name = "Jeeva", City = "PNB", State = "KA", Country = "IN" });
                listofStudents.Add(new Student() { StudentId = 4, Name = "Vijay", City = "Ngpr", State = "KA", Country = "IN" });
                listofStudents.Add(new Student() { StudentId = 5, Name = "Kaira", City = "HYd", State = "KA", Country = "IN" });
                listofStudents.Add(new Student() { StudentId = 6, Name = "Madhu", City = "Blr", State = "KA", Country = "IN" });


            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Student>();
            }

            return listofStudents;
        }
    }
}
