using MundriSoft_Assignment.Data;
using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Repositories
{
    public class UserRepository : IUserRepository
    {
        ApplicationDbContext db;            
        public UserRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int ForgetPassword(User user)
        {
            int res = 0;
            var u = db.users.Where(x => x.User_Id == user.User_Id).FirstOrDefault();
            if (u != null)
            {
                u.Password = user.Password;
                res = db.SaveChanges();
            }
            return res;
        }

        public User Login(User user)
        {
            User u = new User();
            u = db.users.Where(x => x.Email == user.Email).FirstOrDefault();
            return u;
        }

        public int Register(User user)
        {
            user.Role_Id = 2;
            db.users.Add(user);
            int result = db.SaveChanges();
            return result;
        }
    }
}
