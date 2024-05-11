using MundriSoft_Assignment.Models;

namespace MundriSoft_Assignment.Services
{
    public interface IUserServices
    {
        int Register(User user);
        User Login(User user);
        int ForgetPassword(User user);

    }
}
