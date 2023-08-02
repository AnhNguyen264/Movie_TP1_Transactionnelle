using Microsoft.AspNetCore.Mvc;
using TP2.Models;

namespace TP2.Controllers
{
    public class HomeController : Controller
    {

        private BaseDonnees _baseDonnees { get; set; }

        public HomeController(BaseDonnees donnees)
        {
            _baseDonnees = donnees;
        }

        [Route("")]
        [Route("home/index")]
        [Route("index")]

        public IActionResult Index()
        {
            //ViewData["titre"] = "Acceuil";
            return View(_baseDonnees.Parents.ToList());
        }

       

        public IActionResult Consulter(int id)
        {


            //ViewData["titre"] = "Acceuil";
            var parentRecherche = _baseDonnees.Parents.Where(p => p.Id == id).Select(x=>x).SingleOrDefault();
                
            if (parentRecherche == null)
            {
                return View("NonTrouvé", "La liste de film n'a pas été trouvé!");
            }
            else
            {
                return View(parentRecherche);
            }
        }
    }
}
