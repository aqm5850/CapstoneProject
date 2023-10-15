using Microsoft.EntityFrameworkCore;
using AutomatedRecruiter.Models;
namespace AutomatedRecruiter.Context
{
    public static class DbInitializer
    {
        public static void seed(IServiceProvider provider) {
            using (var context = new ApplicationDBContext(provider.GetRequiredService<DbContextOptions<ApplicationDBContext>>()))
            {
                context.Database.EnsureCreated();
                //seed the jobs database here with test data
                
                if (context.Jobs.Any())
                {
                    return;
                }
                context.Jobs.AddRange(new Jobs
                {
                    
                    jobTitle = "Lead .Net Developer",
                    jobDescription = "A lead . net developer is an individual who oversees a team of software developers working on projects using Microsoft's . NET framework. They are responsible for designing, coding, and testing software applications and ensuring that they meet project requirements. ",
                    jobSkills = ".Net, SQL, Git, Visual Studio 2019, SQL Server Management Studio",
                    jobLocation = "Remote",
                    jobCompany = "Microsoft",
                    compensation = "145,000 - 210,000"
                },
                new Jobs 
                { 
                
                  jobTitle = "Lead Architect",
                  jobDescription = "Responsible for overall client satisfaction, design quality and profitability of all projects undertaken that contribute to the firm's strategic priorities. Promote and foster collaboration and engagement with all team members. Manage, direct and mentor Project Managers, Architects, and junior staff.",
                  jobSkills = ".NET, Azure DevOps, TFS, Visual Studio 2019, Azure Boards, PowerShell, SQL Server, SQL Server Management ",
                  jobLocation = "Remote",
                  jobCompany = "Microsoft",
                  compensation = "250,000 - 300,000"
                });
                context.SaveChanges();
 
            }
        }

    }
}
