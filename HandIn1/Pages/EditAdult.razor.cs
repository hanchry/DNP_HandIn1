using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Components;
using Models;

namespace HandIn1.Pages
{
    public partial class EditAdult:ComponentBase 
    {
        [Parameter]
        public int Id { set; get; }

        public Adult AdultToEdit;
        
        protected override async Task OnInitializedAsync()
        {
            AdultToEdit = fileReader.GetAdult(Id);
        }

        private void Save()
        {
            fileReader.UpdateAdult(AdultToEdit);
            NavMgr.NavigateTo("/AdultList");
        }
    }
}