using System.ComponentModel.DataAnnotations.Schema;

namespace MundriSoft_Assignment.Models
{
    public class EmployeeWithDepartment
    {
        public int Emp_Id { get; set; }

        public string? Emp_Name { get; set; }

        public string? Email { get; set; }

        public string? City { get; set; }

        public int Dept_Id { get; set; }

        public string? Department { get; set; }
    }
}
