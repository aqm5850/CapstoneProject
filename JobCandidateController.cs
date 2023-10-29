using AutomatedRecruiter.Context;
using AutomatedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomatedRecruiter.Controllers
{
    public class JobCandidateController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public JobCandidateController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(JobCandidate candidate)
        {
            string name = candidate.CandidateName;
            string email = candidate.CandidateEmail;
            string phone = candidate.CandidatePhoneNumber;
            string address = candidate.CandidateStreetAddress;
            string education = candidate.CandidateEducation;
            string experience = candidate.CandidateExperience;
            string city = candidate.CandidateCity;
            string state = candidate.CandidateState;
            using (var context = _dbContext)
            {
                context.JobCandidates.AddRange(new JobCandidate
                {
                    CandidateEmail = email,
                    CandidatePhoneNumber = phone,
                    CandidateEducation = education,
                    CandidateSkills = experience,
                    CandidateName = name,
                    CandidateCity= city,
                    CandidateState= state,
                    CandidateExperience= experience,
                    CandidateStreetAddress = address

                });
                context.SaveChanges();  
            }

                return View();
        }
    }
}
