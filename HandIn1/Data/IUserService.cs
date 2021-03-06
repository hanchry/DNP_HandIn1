
using Models;

namespace HandIn1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        bool IsUserRegistered(string userName,string password);
    }
}