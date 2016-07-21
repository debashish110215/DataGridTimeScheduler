using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Please set a Department Tile")]
        [MaxLength(20, ErrorMessage = "Max length of Department Title {20}"), MinLength(3)]
        [Display(Name = "Department Title")]
        public string DepartmentTitle { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}