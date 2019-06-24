using System;
using System.Collections.Generic;

namespace JWTAuthentication.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public double Hours { get; set; }
    }
}
