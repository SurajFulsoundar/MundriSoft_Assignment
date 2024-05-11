using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Repositories
{
    public interface IUserRepository
    {
        int Register(User user);
        User Login(User user);
        int ForgetPassword(User user);

    }
}
