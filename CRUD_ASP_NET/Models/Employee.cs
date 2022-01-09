﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_ASP_NET.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Salary { get; set; }
    }
}
