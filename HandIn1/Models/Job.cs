using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        [Required]
        public string JobTitle { get; set; }
        [Range(100, int.MaxValue,ErrorMessage = "Have to earn minimum wage")]
        public int Salary { get; set; }
    }
}