using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundriSoft_Assignment.Models
{
    public enum Role { Admin = 2, Customer };
    [Table("Users")]
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password")]
        [NotMapped]
        [Required(ErrorMessage = "Password Once Again")]
        [DataType(DataType.Password)]
        public string? Confirm_Password { get; set; }

        [Required]
        public int Role_Id { get; set; }
    }
}
