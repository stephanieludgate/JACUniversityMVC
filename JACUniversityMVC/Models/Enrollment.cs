﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JACUniversityMVC.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade Grade { get; set; } // see below for Enum 

        public Course Course { get; set; }
        public Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, E, F
    }
}
