using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Project.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
