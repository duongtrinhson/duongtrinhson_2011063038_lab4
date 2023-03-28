using duongtrinhson_2011063038_lab4.Models;
using duongtrinhson_2011063038_lab4.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace duongtrinhson_2011063038_lab4.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Category> Categories { get; private set; }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel=new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
             };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Create( CourseViewModel viewModel)
                
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }

            var course = new Course
            {
                LecturerID = User.Identity.GetUserId(),
            DateTime = viewModel.GetDateTime(),
                CategoryID=viewModel.Category,
                Place=viewModel.Place


            };
            _dbContext.Course.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        [Authorize]
        public ActionResult Attending()
        {
            var userId=User.Identity.GetUserId();
            var courses = _dbContext.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Course)
                .Include(l => l.category)
                .ToList();
            var viewModel = new CoursesViewModels
            {
                UpcomingCourses = courses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);

        }

    }
}