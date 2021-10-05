using System.Dynamic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Models;

namespace HandIn1.Pages
{
    public partial class AdultView:ComponentBase
    {
        [Parameter]
        public int Id { set; get; }
        
        public Adult AdultToView { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            AdultToView = fileReader.GetAdult(Id);
        }

        public void DeleteJob()
        {
            fileReader.RemoveJob(AdultToView);
        }

        public void AddJob()
        {
            fileReader.AddJob(AdultToView);
        }
    }
}