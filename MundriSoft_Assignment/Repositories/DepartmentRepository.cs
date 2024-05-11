using MundriSoft_Assignment.Data;
using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ApplicationDbContext db;
        public DepartmentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddDepartment(Department dept)
        {
            db.departments.Add(dept);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteDepartment(int id)
        {
            int result = 0;
            var model = db.departments.Where(x => x.Dept_Id == id).FirstOrDefault();
            if (model != null)
            {
                db.departments.Remove(model);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return db.departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            var dept = db.departments.Where(x => x.Dept_Id == id).FirstOrDefault();
            return dept;
        }

        public int UpdateDepartment(Department dept)
        {
            int res = 0;
            Department d = new Department();
            d = db.departments.Where(x => x.Dept_Id == dept.Dept_Id).FirstOrDefault();
            if (d != null)
            {
                d.Dept_Name = dept.Dept_Name;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
