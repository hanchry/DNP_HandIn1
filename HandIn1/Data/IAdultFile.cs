using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IAdultFile
    {
        IList<Adult> GetAdults();
    }
}