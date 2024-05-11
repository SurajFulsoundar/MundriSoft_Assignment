using Microsoft.EntityFrameworkCore;
using MundriSoft_Assignment.Data;
using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            db.employees.Add(employee);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var model = db.employees.Where(x => x.Emp_Id == id).FirstOrDefault();
            if (model != null)
            {
                db.employees.Remove(model);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return db.employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = db.employees.Where(x => x.Emp_Id == id).FirstOrDefault();
            return emp;
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;
            Employee emp = new Employee();
            emp = db.employees.Where(x => x.Emp_Id == employee.Emp_Id).FirstOrDefault();
            if (emp != null)
            {
                emp.Emp_Name = employee.Emp_Name;
                emp.Email = employee.Email;
                emp.City = employee.City;
                emp.Dept_Id = employee.Dept_Id; 
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
