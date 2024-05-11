using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Services
{
    public interface IDepartmentServices
    {
        int AddDepartment(Department dept);

        IEnumerable<Department> GetAllDepartment();

        int DeleteDepartment(int id);

        Department GetDepartmentById(int id);

        int UpdateDepartment(Department dept);
    }
}
