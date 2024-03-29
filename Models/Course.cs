﻿using System.ComponentModel.DataAnnotations;

namespace Architecture.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        // data annotation example: [Required] (not nullable)
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

    }
}
