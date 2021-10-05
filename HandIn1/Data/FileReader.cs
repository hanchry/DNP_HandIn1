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

        public IList<User> GetUsers()
        {
            return FileContext.Users;
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
            foreach (var x in GetAdults())
            {
                if (x.Id == adult.Id)
                {
                    x.JobTitle.JobTitle = "no job";
                    x.JobTitle.Salary = 0;
                }
            }
            FileContext.SaveChanges();
        }

        public void AddJob(Adult adult)
        {
            foreach (var x in GetAdults())
            {
                if (x.Id == adult.Id)
                {
                    x.JobTitle = adult.JobTitle;
                }
            }
            
        }
    }
}