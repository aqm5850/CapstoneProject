using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AutomatedRecruiter.Models
{
    public class JobCandidate
    {
        [Key]
        public int Id { get; set; }
        public int JobId { get; set; }
        public string CandidateName { get; set; }
        public string CandidateSkills { get; set; }
        public string CandidateEducation { get; set; }
        public string CandidateExperience { get; set; }
        public string CandidateState { get; set; }
        public string CandidateCity { get; set; }
        public string CandidateStreetAddress { get; set; }
       
    }

}
