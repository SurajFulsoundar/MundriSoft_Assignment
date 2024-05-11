using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Repositories
{
    public interface IEmployeeRepository
    {
        int AddEmployee(Employee employee);

        IEnumerable<Employee> GetAllEmployee();

        int DeleteEmployee(int id);

        Employee GetEmployeeById(int id);

        int UpdateEmployee(Employee employee);
    }
}
