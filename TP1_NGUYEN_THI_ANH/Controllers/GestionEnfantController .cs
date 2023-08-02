using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP2.Models;
using TP2.ViewModels;
namespace TP2.Controllers
{
    public class GestionEnfantController : Controller
    {

        private BaseDonnees _baseDonnees { get; set; }

        public GestionEnfantController(BaseDonnees donnees)
        {
            _baseDonnees = donnees;
        }

        // GET: GestionEnfantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GestionEnfantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionEnfantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionEnfantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Enfant enfant)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError(nameof(enfant), "Votre nouveau film est invalide.");
                return View();
            }
            if(_baseDonnees.Enfants.Any(p =>p.Id == enfant.Id))
            {
                ModelState.AddModelError(nameof(enfant.Id), "Ce film existe déjà");
                return View();

            }
            try

            {
                _baseDonnees.Enfants.Add(enfant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionEnfantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionEnfantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET: GestionEnfantController/Delete/5



        public ActionResult Delete(int id)
        {
            //Enfant? enfant = _baseDonnees.Enfants.FirstOrDefault(z => z.Id == id);
            Enfant enfant = _baseDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();

            if (enfant == null)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");
            }

            return View(enfant);
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            Enfant enfant = _baseDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();
            if (enfant == null)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");
            }
            enfant.Parent.Enfants.Remove(enfant);
            //_baseDonnees.SaveChanges();
            //TempData["Success"] = $"Film {enfant.Nom} a été supprimé";
            return RedirectToAction("Index", "Home");
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
