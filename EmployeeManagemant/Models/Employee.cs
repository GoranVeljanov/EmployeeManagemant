﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagemant.Models
{
    public class Employee { 

        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Name cannot exceed 10 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}