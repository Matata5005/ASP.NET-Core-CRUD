using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB1st.Models
{
    public enum SortOrder { Ascending=0,Descending=1}
    public class NewStudents
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Student Firstname")]
        [Required(ErrorMessage = "Enter student 1st name")]
        public string FirstName { get; set; }

        [Display(Name = "Student Lastname")]
        [Required(ErrorMessage = "Enter student last name")]
        public string LastName { get; set; }

        [Display(Name = "Student registration number")]
        [Required(ErrorMessage = "Enter student registration number")]
        public int Regno { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "email")]
        [Display(Name = "email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}


