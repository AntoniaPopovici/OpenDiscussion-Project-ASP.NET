using Microsoft.AspNetCore.Mvc;

namespace OpenDiscussion.Controllers
{
    public class ResponseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
