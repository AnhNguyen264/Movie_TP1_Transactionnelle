using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP2.Models;
using TP2.Models.Data;
using TP2.Utility;
using TP2.ViewModels;

namespace TP2.Controllers
{
    public class ParentsController : Controller
    {

        private TPDbContext _baseDonnees { get; set; }
        public ParentsController(TPDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }
        // GET: ParentsControllers
        public  ActionResult Index()
        {
            List<Parent> parentsList =  _baseDonnees.Parents.ToList();

            return View(parentsList);
        }

        // GET: ParentsControllers/Details/5
        public ActionResult Details(int id)
        {
            var parentsDetails = _baseDonnees.Enfants.Where(x => x.IdParent == id);    
            ParentVM parentVM = new()
            {
                parent = new(),
                EnfantList = parentsDetails.ToList(),
                EnfantCount = parentsDetails.Count()
            };

            parentVM.parent = _baseDonnees.Parents.FirstOrDefault(z => z.Id == id);
                return View(parentVM);
        }

        // GET: ParentsControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentsControllers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ParentsControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParentsControllers/Edit/5
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

        // GET: ParentsControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParentsControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
