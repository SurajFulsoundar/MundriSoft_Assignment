using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Services
{
    public interface IEmployeeServices
    {
        int AddEmployee(Employee employee);

        IEnumerable<Employee> GetAllEmployee();

        int DeleteEmployee(int id);

        Employee GetEmployeeById(int id);

        int UpdateEmployee(Employee employee);
    }
}
