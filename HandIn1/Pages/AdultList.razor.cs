using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Models;

namespace HandIn1.Pages
{
    public partial class AdultList:ComponentBase
    {
        
        private IList<Adult> allAdults;
        private IList<Adult> toShow;

        private AdultView AdultView;

        private string? firstName;
        protected override async Task OnInitializedAsync()
        {
            allAdults = fileReader.GetAdults();
            toShow = allAdults;
            AdultView = new AdultView();
        }
        
        public void FindByName(ChangeEventArgs changeEventArgs)
        {
            firstName = null;
            try
            {
                firstName = changeEventArgs.Value.ToString();
            }
            catch (Exception e)
            {
            }
            ExecuteFilter();
        }

        public void ExecuteFilter()
        {
            toShow = allAdults.Where(adult => (adult.FirstName.Contains(firstName))).ToList();
        }

        public void DeleteAdult(Adult adult)
        {
            fileReader.RemoveAdult(adult);
        }

        public void NavigateToAdultView(int id)
        {
            NavMgr.NavigateTo($"AdultView/{id}");
        }
        
        
    }
}