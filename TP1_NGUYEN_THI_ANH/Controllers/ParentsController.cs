using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
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
        public async Task<  IActionResult> Index()
        {
            List<Parent> parentsList = await _baseDonnees.Parents.ToListAsync();

            return View(parentsList);
        }

        // GET: ParentsControllers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var parentsDetails =  _baseDonnees.Enfants.Where(x => x.IdParent == id);    
            ParentVM parentVM = new()
            {
                parent = new(),
                EnfantList = parentsDetails.ToList(),
                EnfantCount = parentsDetails.Count()
            };

            parentVM.parent =await _baseDonnees.Parents.FirstOrDefaultAsync(z => z.Id == id);
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
        public async Task<IActionResult> Create(Parent parent)
        {
            if(ModelState.IsValid)
            {
               await _baseDonnees.Parents.AddAsync(parent);
               await _baseDonnees.SaveChangesAsync();

                TempData[AppConstants.Success] = $"{parent.Nom} le statut a été ajouté";
                return this.RedirectToAction("Index");

            }
            return this.View(parent);
            //try
            //{
            //    if(parent.Id == 0) { 
            //        parent.Id = _baseDonnees.Parents.Max(a => a.Id) + 1;
            //        parent.Nom = parent.Nom;
            //        parent.Description = parent.Description;
            //        _baseDonnees.Parents.Add(parent);
            //    _baseDonnees.SaveChanges();

            //    TempData[AppConstants.Success] = $"{parent.Nom} le statut a été ajouté";
            //        return this.RedirectToAction("Index");

            //}
            //}
            //catch
            //{
            //    return View();

            //}



        }

        // GET: ParentsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Parent parent = await _baseDonnees.Parents.FindAsync(id);
            return View(parent);
        }

        // POST: ParentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Parent parent)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Parents.Update(parent);
               await  _baseDonnees.SaveChangesAsync();
                TempData[AppConstants.Success] = $"Statut {parent.Nom} a été modifié";
                return this.RedirectToAction("Index", "parents");
            }
            return View(parent);
          
        }

        // GET: ParentsControllers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Parent? parent = await _baseDonnees.Parents.FindAsync(id);
            if(parent == null)
            {
                return View("NonTrouve", "Le statut demandé n'a pas été trouvé!");

            }
            return View(parent);
        }

        // POST: ParentsControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int id)
        {
            Parent? parent = await _baseDonnees.Parents.FindAsync(id);
            if(parent == null)
            {
                return View("NonTrouve", "Le statut demandé n'a pas été trouvé!");

            }
            _baseDonnees.Parents.Remove(parent);
            await _baseDonnees.SaveChangesAsync();
            TempData[AppConstants.Success] = $"Statut {parent.Nom} a été suprrimé";
            return RedirectToAction("Index");

        }
    }
}
