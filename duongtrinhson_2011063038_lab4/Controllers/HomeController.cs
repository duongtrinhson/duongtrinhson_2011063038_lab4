﻿using duongtrinhson_2011063038_lab4.Models;
using duongtrinhson_2011063038_lab4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace duongtrinhson_2011063038_lab4.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
                _dbContext=new ApplicationDbContext();

            }
        public ActionResult Index()
        {
            var upcomingCourses = _dbContext.Course
               .Include(c =>c.Lecturer)
               .Include(c =>c.category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CoursesViewModels
            {
                UpcomingCourses = upcomingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel); ;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}