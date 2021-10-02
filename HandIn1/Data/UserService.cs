using System;
using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace HandIn1.Data
{
    public class UserService : IUserService
    {
        private IList<User> users;
        private IFileReader FileReader; 

        public UserService()
        {
            FileReader = new FileReader();
            users = FileReader.GetUsers();
        }

        public User ValidateUser(string userName, string password)
        {
            User checkUser = users.FirstOrDefault(user => user.UserName.Equals(userName));

            if (checkUser == null)
            {
                throw new Exception("User not found");
            }

            if (!checkUser.Password.Equals(password))
            {
                throw new Exception("Wrong password");
            }

            return checkUser;
        }
    }
}