using MundriSoft_Assignment.Models;
using MundriSoft_Assignment.Repositories;

namespace MundriSoft_Assignment.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepository repo;

        public DepartmentServices(IDepartmentRepository repo)
        {
            this.repo = repo;
        }
        public int AddDepartment(Department dept)
        {
            return repo.AddDepartment(dept);
        }

        public int DeleteDepartment(int id)
        {
            return repo.DeleteDepartment(id);
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return repo.GetAllDepartment();
        }

        public Department GetDepartmentById(int id)
        {
            return repo.GetDepartmentById(id);
        }

        public int UpdateDepartment(Department dept)
        {
           return repo.UpdateDepartment(dept);
        }
    }
}
