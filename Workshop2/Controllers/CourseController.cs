using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepository CourseRepository;
        public CourseController(ICourseRepository CorseRepo)
        {
            this.CourseRepository = CorseRepo;
        }
        public IActionResult Index()
        {
            IEnumerable<Course> course = CourseRepository.GetAllcourses();

            return View(course);
        }

        public IActionResult Edit(int id)
        {
            Course Course = CourseRepository.SearchCourse(x => x.CourseID == id).FirstOrDefault();
            return View(Course);

        }

        [HttpPost]
        public IActionResult Edit(Course Course)
        {
            CourseRepository.updateCorse(Course);
            return RedirectToAction("Index");



        }

        public IActionResult Create()
        {
            return View();

        }
    }
}