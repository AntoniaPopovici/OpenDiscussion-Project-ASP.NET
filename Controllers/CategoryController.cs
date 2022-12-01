using Microsoft.AspNetCore.Mvc;

namespace OpenDiscussion.Controllers
{
    public class CategoryController : Controller
    {
        // GET: vizualizarea tuturor categoriilor
        public IActionResult Index()
        {
            return View();
        }

        /// GET :vizualizarea unei categorii
         
        public IActionResult Show(int id)
        {
            return View();
        }

        // GET : editarea unei categorii
        public IActionResult Edit(int ID)
        {
            return View();
        }


        // POST: se trimit modificarile la server si se stocheaza
        [HttpPost]
        public IActionResult Edit(Student ID)
        {
            // cod modificare date categorie
            // se redirectioneaza browser-ul catre categorie editat
            return Redirect("/Students/Edit" + ID);
            //return RedirectToRoute("students_show", new { id = ID
        });
 }
}
}
