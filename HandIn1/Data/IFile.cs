using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileReader
    {
        IList<Adult> GetAdults();
        IList<User> GetUsers();
        void AddAdult(Adult adult);
    }
}