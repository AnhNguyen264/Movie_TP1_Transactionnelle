using Microsoft.AspNetCore.Mvc;
using TP2.Models;

namespace TP2.Controllers
{
    public class FavorisController : Controller
    {

        private BaseDonnees _baseDonnees { get; set; }

        public FavorisController(BaseDonnees donnees)
        {
            _baseDonnees = donnees;
        }
        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfants");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }
            var enfantDeLaBD = _baseDonnees.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();
            return View(enfantDeLaBD);
        }

        //public IActionResult AjoutUnEnfant()
        //{
        //    List<Enfant> enfants = HttpContext.Session.Get<List<Enfant>>("enfants");
        //    return View(enfants);
        //}

        //[HttpPost]
        
        public IActionResult AjoutUnEnfant(int id)
        {

            List<int> enfants = HttpContext.Session.Get<List<int>>("enfants");
            if (enfants == null)
            {
                enfants = new List<int>();
            }
            if (!enfants.Contains(id))
            {
                enfants.Add(id);
            }

                HttpContext.Session.Set<List<int>>("enfants", enfants);
                return RedirectToAction("Index", "Favoris");
            
          
        }


        public IActionResult SuprrimeUnEnfant()
        {
            List<int> enfants = HttpContext.Session.Get<List<int>>("enfants");
            return View(enfants);
        }

        [HttpPost]

        public IActionResult SuprrimeUnEnfant(int id)
        {
            List<int> enfants = HttpContext.Session.Get<List<int>>("enfants");
            if (enfants == null)
            {
                enfants = new List<int>();
            }
          
                //enfants.Remove(_baseDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault());
                enfants.Remove(id);

                HttpContext.Session.Set<List<int>>("enfants", enfants);
                return RedirectToAction("Index");
        }
            
}

    }

