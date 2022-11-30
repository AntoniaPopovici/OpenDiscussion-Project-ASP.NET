using Microsoft.AspNetCore.Mvc;

namespace OpenDiscussion.Controllers
{
    public class Discussion : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
