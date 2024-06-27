using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Project.ViewComponents
{
    public class _AdminHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
