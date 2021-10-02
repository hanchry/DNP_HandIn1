using System.Collections.Generic;
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
    }
}