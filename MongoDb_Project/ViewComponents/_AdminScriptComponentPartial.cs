using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Project.ViewComponents
{
    public class _AdminScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
