using Demo_ASP_MVC_01.Data;
using Demo_ASP_MVC_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_01.Controllers
{
    public class PersonnageController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Personnage> personnages = FakeDB.GetPersonnages();
            string email = "della.duck@gmail.com";

            //ViewBag.Email = email;
            ViewData["Email"] = email;

            return View(personnages);
        }
    }
}
