using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        [NotMapped]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [NotMapped]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [MaxLength(50,ErrorMessage="Full Name not exit 50 characters")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set { this.FullName = FirstName + " " + LastName; }
        }

        [Required(ErrorMessage = "Please set a UserName")]
        [MaxLength(10, ErrorMessage = "Maximum UserName Length {10}")]
        [Display(Name = "UserName")]
        [RegularExpression(@"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-z0-9._]+(?<![_.])$", ErrorMessage = "Username can hold only alphanumeric characters ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please set Password for the User")]
        [MaxLength(10, ErrorMessage = "Maximum Password Length {10}")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "New Password")]
        [DataType(DataType.Password)]
        [MaxLength(10, ErrorMessage = "Maximum Password Length {10}")]
        public string NewPassword { get; set; }

        [NotMapped]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        [MaxLength(10, ErrorMessage = "Maximum Password Length {10}")]
        public string ConfirmPassword { get; set; }

        [MaxLength(20, ErrorMessage = "Maximum Email Length {20}")]
        //[EmailAddress("Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        //[Phone("ContactNo")]
        [MaxLength(15)]
        //[RegularExpression(@"^\d{1,15}$", ErrorMessage = "Please enter up to 15 digits for a contact number")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Password Length {10}")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please set Designation for the UserName")]
        [MaxLength(20, ErrorMessage = "Maximum Designation Length {10}")]
        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Please set Role for the UserName")]
        [Range(0, 2)]
        [Display(Name = "Role")]
        public int Role { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<TimeSchedule> TimeSchedules { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

    }
}