﻿using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace FileData
{
    public class FileReader:IFileReader
    {
        private FileContext FileContext;

        public FileReader()
        {
            FileContext = new FileContext();
        }
        
        public IList<Adult> GetAdults()
        {
            return FileContext.Adults;
        }
        public User GetUser(string userName)
        {
            return FileContext.Users.FirstOrDefault(user => user.UserName.Equals(userName));
        }

        public void UpdateAdult(Adult adult)
        {
            Adult adultToUpdate = GetAdults().First(t => t.Id == adult.Id);
            adultToUpdate = adult;
            FileContext.SaveChanges();
        }

        public IList<User> GetUsers()
        {
            return FileContext.Users;
        }
        public void AddUser(User user)
        {
            FileContext.Users.Add(user);
            FileContext.SaveChanges();
        }
        
        public void AddAdult(Adult adult)
        {
            FileContext.Adults.Add(adult);
            FileContext.SaveChanges();
        }

        public void RemoveAdult(Adult adult)
        {
            FileContext.Adults.Remove(adult);
            FileContext.SaveChanges();
        }

        public Adult GetAdult(int Id)
        {
            return FileContext.Adults.FirstOrDefault(adult => adult.Id==Id);
        }

        public void RemoveJob(Adult adult)
        {
            Adult toRemove = GetAdults().First(t => t.Id == adult.Id);
            toRemove.JobTitle.JobTitle = "no job";
            toRemove.JobTitle.Salary = 0;
            FileContext.SaveChanges();
        }

        public void AddJob(Adult adult)
        {
            Adult toAdd = GetAdults().First(t => t.Id == adult.Id);
            toAdd.JobTitle = adult.JobTitle;
            FileContext.SaveChanges();
        }

        
    }
}