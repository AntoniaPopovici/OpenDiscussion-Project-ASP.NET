using Microsoft.AspNetCore.Mvc;

namespace OpenDiscussion.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
