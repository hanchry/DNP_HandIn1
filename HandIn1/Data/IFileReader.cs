using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileReader
    {
        IList<Adult> GetAdults();
        IList<User> GetUsers();
        void AddAdult(Adult adult);
        void RemoveAdult(Adult adult);
        Adult GetAdult(int Id);
        void RemoveJob(Adult adult);
        void AddJob(Adult adult);
        void AddUser(User user);
        User GetUser(string userName);
        void UpdateAdult(Adult adult);

    }
}