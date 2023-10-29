using System.ComponentModel.DataAnnotations;

namespace AutomatedRecruiter.Models
{
    public class Jobs
    {
        [Key]
       public int Id { get; set; }
       public string jobTitle { get; set; }
       public string jobDescription { get; set; }
       public string jobSkills { get; set; }
       public string jobLocation { get; set; }
       public string jobCompany { get; set; }
       public string compensation { get; set; }

    }
}
