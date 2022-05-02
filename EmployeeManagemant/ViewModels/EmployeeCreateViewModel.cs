using EmployeeManagemant.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagemant.ViewModels
{
    public class EmployeeCreateViewModel
    {
        
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
        public List <IFormFile> Photos { get; set; }
    }
}
