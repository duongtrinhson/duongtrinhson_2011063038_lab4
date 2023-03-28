﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace duongtrinhson_2011063038_lab4.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order=1)]
        public int CourseId { get; set; }
        public ApplicationUser Attendee { get; set; }
        [Key]
        [Column(Order=2)]
        public string AttendeeId { get; set; }
        
    }
}