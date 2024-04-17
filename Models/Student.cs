using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace TestDotNetWebApplication.Models
{
    public class Student
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(15,70)]
        public int Age { get; set; }
        [Required]
        [MinLength(5)]
        public string Country { get; set; }
    }
}
