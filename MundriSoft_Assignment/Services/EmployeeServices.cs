using MundriSoft_Assignment.Models;
using MundriSoft_Assignment.Repositories;

namespace MundriSoft_Assignment.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository repo;
        public EmployeeServices(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return repo.GetAllEmployee();
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee employee)
        {
           return repo.UpdateEmployee(employee);
        }
    }
}
