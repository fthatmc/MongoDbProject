using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Project.ViewComponents
{
    public class _AdminNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
