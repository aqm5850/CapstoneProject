using AutomatedRecruiter.Context;
using AutomatedRecruiter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AutomatedRecruiter.Controllers
{
    public class JobsController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        
        public JobsController (ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<String> jobTitles = new List<String>();
            List<String> jobDescriptions = new List<String>();
            List<Jobs> Jobs = new List<Jobs>();
            using (var context = _dbContext)
            {


                foreach (var job in context.Jobs)
                {
                    //jobTitles.Add(job.jobTitle);
                    //jobDescriptions.Add(job.jobDescription);
                    Jobs.Add(job);
                }
                ViewBag.Jobs = Jobs;
               
            }
            
            return View();
        }
        public IActionResult Details(int id) 
        {
            //write linq query here to return the job by ID from the database using dbcontext
            List<Jobs> Jobs = new List<Jobs>();
            Jobs job;
            using (var context = _dbContext) 
            {
              job = context.Jobs.FirstOrDefault(x => x.Id == id);
              Jobs.Add(job);
            }
            ViewBag.Jobs = Jobs; 
            ViewBag.Id = id;
            
            return View();
        }
    }
}
