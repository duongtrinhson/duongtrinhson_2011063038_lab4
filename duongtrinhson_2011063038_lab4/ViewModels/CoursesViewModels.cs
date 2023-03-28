using duongtrinhson_2011063038_lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace duongtrinhson_2011063038_lab4.ViewModels
{
    public class CoursesViewModels
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}