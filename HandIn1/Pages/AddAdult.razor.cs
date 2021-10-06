using Microsoft.AspNetCore.Components;
using Models;

namespace HandIn1.Pages
{
    public partial class AddAdult:ComponentBase
    {
        private Adult AdultToAdd = new Adult();
        private Job AdultsJob = new Job();
        private void AddNewAdult()
        {

            AdultToAdd.JobTitle = AdultsJob;
            AdultToAdd.Id = getNewId();
            FileReader.AddAdult(AdultToAdd); 
            NavigationManager.NavigateTo("/AdultList");
        }

        private int getNewId()
        {
            int result = 0;
            foreach (Adult x in FileReader.GetAdults())
            {
                result = x.Id + 1;
            }
            return result;
        }
    }
}