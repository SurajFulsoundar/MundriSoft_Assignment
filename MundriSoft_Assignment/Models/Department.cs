using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundriSoft_Assignment.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }

        [Required(ErrorMessage = "Department Name is Required")]
        public string? Dept_Name { get; set; }
    }
}
