using AutomatedRecruiter.Models;
using Microsoft.EntityFrameworkCore;


namespace AutomatedRecruiter.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }
    }
}
