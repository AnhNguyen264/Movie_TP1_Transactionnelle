using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP2.Models;
using TP2.Models.Data;
using TP2.Utility;
using TP2.ViewModels;
namespace TP2.Controllers
{
    public class GestionEnfantController : Controller
    {

        //private BaseDonnees _baseDonnees { get; set; }

        //public GestionEnfantController(BaseDonnees donnees)
        //{
        //    _baseDonnees = donnees;
        //}
        private readonly TPDbContext _baseDonnees;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public GestionEnfantController(TPDbContext donnees, IWebHostEnvironment webHostEnvironment)
        {
            _baseDonnees = donnees;
            _webHostEnvironment = webHostEnvironment;

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
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: GestionEnfantController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Enfant enfant)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError(nameof(enfant), "Votre nouveau film est invalide.");
        //        return View();
        //    }
        //    if(_baseDonnees.Enfants.Any(p =>p.Id == enfant.Id))
        //    {
        //        ModelState.AddModelError(nameof(enfant.Id), "Ce film existe déjà");
        //        return View();

        //    }
        //    try

        //    {
        //        _baseDonnees.Enfants.Add(enfant);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        public async Task<IActionResult> Create()
        {
            EnfantVM enfantVM = new EnfantVM();
            enfantVM.Enfant = new Enfant();
            enfantVM.ParentSelectList = _baseDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(enfantVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EnfantVM enfantVM)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _webHostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, AppConstants.ImagePath);

                    var extenstion = Path.GetExtension(files[0].FileName);

                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }

                    enfantVM.Enfant.ImageURL = fileName + extenstion;
                }

                await _baseDonnees.Enfants.AddAsync(enfantVM.Enfant);
                await _baseDonnees.SaveChangesAsync();
                TempData[AppConstants.Success] = $"Film {enfantVM.Enfant.Nom} a été creé";

                return this.RedirectToAction("Recherche", "Enfant");
            }
            enfantVM.ParentSelectList = _baseDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(enfantVM);
        }




        // GET: GestionEnfantController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            EnfantVM enfantVM = new EnfantVM();
            enfantVM.Enfant = await _baseDonnees.Enfants.FindAsync(id);
            enfantVM.OldImage = enfantVM.Enfant.ImageURL;
            enfantVM.ParentSelectList = _baseDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(enfantVM);
        }

        // POST: GestionEnfantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EnfantVM enfantVM)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _webHostEnvironment.WebRootPath; 
                var files = HttpContext.Request.Form.Files; 

                if (files.Count > 0)
                {      
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, AppConstants.ImagePath);
                    var extenstion = Path.GetExtension(files[0].FileName);
                    if (enfantVM.OldImage != enfantVM.Enfant.ImageURL)
                    {
                        var PreviousImage = Path.Combine(webRootPath, AppConstants.ImagePath, enfantVM.OldImage.TrimStart('\\'));
                        if (System.IO.File.Exists(PreviousImage))
                        {
                            System.IO.File.Delete(PreviousImage);
                        }
                    }

                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    enfantVM.Enfant.ImageURL = fileName + extenstion;
                }


                _baseDonnees.Enfants.Update(enfantVM.Enfant);
                await _baseDonnees.SaveChangesAsync();
                TempData[AppConstants.Success] = $"Film {enfantVM.Enfant.Nom} a été modifié";

                return this.RedirectToAction("Recherche", "Enfant");

            }
            enfantVM.ParentSelectList = _baseDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);

            return View(enfantVM);
        }

        //GET: GestionEnfantController/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    //Enfant? enfant = _baseDonnees.Enfants.FirstOrDefault(z => z.Id == id);
        //    Enfant enfant = _baseDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();

        //    if (enfant == null)
        //    {
        //        return View("NonTrouve", "Le film demandé n'a pas été trouvé!");
        //    }

        //    return View(enfant);
        //}

        //// POST: GestionEnfantController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeletePost(int id)
        //{
        //    Enfant enfant = _baseDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();
        //    if (enfant == null)
        //    {
        //        return View("NonTrouve", "Le film demandé n'a pas été trouvé!");
        //    }
        //    enfant.Parent.Enfants.Remove(enfant);
        //    //_baseDonnees.SaveChanges();
        //    //TempData["Success"] = $"Film {enfant.Nom} a été supprimé";
        //    return RedirectToAction("Recherche", "Enfant");

        //}

        public async Task<IActionResult> Delete(int id)
        {
            Enfant? enfant = await _baseDonnees.Enfants.Include(z => z.Parent).FirstOrDefaultAsync(z => z.Id == id);
            if (enfant == null)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");
            }

            return View(enfant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int id)
        {
            Enfant? enfant = await _baseDonnees.Enfants.FindAsync(id);
            if (enfant == null)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");

            }

            _baseDonnees.Enfants.Remove(enfant);
            await _baseDonnees.SaveChangesAsync();
            TempData[AppConstants.Success] = $"Statut {enfant.Nom} a été supprimé";
            return RedirectToAction("Recherche", "Enfant");
        }

       
    }
}
