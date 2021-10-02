using System.Collections.Generic;
using Models;

namespace FileData
{
    public class AdultFile:IAdultFile
    {
        private FileContext FileContext;

        public AdultFile()
        {
            FileContext = new FileContext();
        }
        
        public IList<Adult> GetAdults()
        {
            return FileContext.Adults;
        }
    }
}