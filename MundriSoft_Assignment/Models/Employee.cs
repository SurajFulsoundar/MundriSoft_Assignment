using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundriSoft_Assignment.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        [Required(ErrorMessage = "Employee Name is Required")]
        public string? Emp_Name { get; set;}

        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set;}

        [Required(ErrorMessage = "City is Required")]
        public string? City { get; set;}

        [ForeignKey("Dept_Id")]
        public int  Dept_Id { get; set;}

        [NotMapped]            
        public string? Department { get; set;}
    }
}
