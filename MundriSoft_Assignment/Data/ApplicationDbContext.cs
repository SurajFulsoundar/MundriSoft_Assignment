using Microsoft.EntityFrameworkCore;
using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<User> users { get; set; }

       // public DbSet<User_Role> roles { get; set; }


    }
}
