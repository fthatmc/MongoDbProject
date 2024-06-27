using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Project.ViewComponents
{
    public class _AdminFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
