using System;
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

        private Job job;
        
        protected override async Task OnInitializedAsync()
        {
            AdultToView = fileReader.GetAdult(Id);
            job = new Job();
        }

        public void DeleteJob()
        {
            fileReader.RemoveJob(AdultToView);
            job = new Job();
        }

        public void AddJob()
        {
            AdultToView.JobTitle = job;
            fileReader.AddJob(AdultToView);
        }
    }
}