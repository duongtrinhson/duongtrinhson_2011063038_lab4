﻿using duongtrinhson_2011063038_lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace duongtrinhson_2011063038_lab4.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public String Place { get; set; }
        [Required]
        public String Date{ get; set; }
        [Required]
        public String Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("{0}{1}",Date,Time));
        }

    }
}