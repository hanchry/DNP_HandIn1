using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Components;
using Models;

namespace HandIn1.Pages
{
    public partial class AdultList:ComponentBase
    {
        private IList<Adult> allAdults;
        
        protected override async Task OnInitializedAsync()
        {
            allAdults = adultFile.GetAdults();
        }
    }
}