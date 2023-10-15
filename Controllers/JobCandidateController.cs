using Microsoft.AspNetCore.Mvc;

namespace AutomatedRecruiter.Controllers
{
    public class JobCandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
