using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP2.Models;
using TP2.Models.Data;
using TP2.Utility;
using TP2.ViewModels;

namespace TP2.Controllers
{
    public class EnfantController : Controller
    {
        private readonly TPDbContext _baseDonnees;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public EnfantController(TPDbContext donnees, IWebHostEnvironment webHostEnvironment)
        {
            _baseDonnees = donnees;
            _webHostEnvironment = webHostEnvironment;

        }


        [Route("Enfant/Recherche")]
        [Route("Recherche")]
        public IActionResult Recherche()
        {
            //var donnees = _baseDonnees.Enfants.ToList();
            //return View(donnees);
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.statut1 = true;
            model.Criteres.statut2 = true;
            model.Criteres.statut3 = true;
            model.Resultat = _baseDonnees.Enfants.ToList();
            return View(model);


        }


        [Route("Enfant/Recherche")]
        [HttpPost()]
        public IActionResult Recherche(CritereRechercheViewModel pCriteres)
        {
            var filtrer = new PageRechercheViewModel();
            filtrer.Criteres = pCriteres;
            filtrer.Resultat = _baseDonnees.Enfants.ToList();

            //statut
            if (!pCriteres.statut1)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Parent.Id != 1).ToList();

            }
            if (!pCriteres.statut2)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Parent.Id != 2).ToList();

            }
            if (!pCriteres.statut3)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Parent.Id != 3).ToList();

            }




            //motscle
            if (pCriteres.search_byword != null)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Nom.ToUpper().Contains(pCriteres.search_byword.ToUpper())).ToList();
            }

            //min - max
            if (pCriteres.vus_min.HasValue)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Vus >= pCriteres.vus_min).ToList();
            }

            if (pCriteres.vus_max.HasValue)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Vus <= pCriteres.vus_max).ToList();
            }

            //annee
            //if (filtrer.Criteres.selectAnnee == 2023)
            //{
            //    filtrer.Resultat = filtrer.Resultat.Where(x => x.Date == 2023).ToList();
            //}
            //else if (filtrer.Criteres.selectAnnee == 2022)
            //{
            //    filtrer.Resultat = filtrer.Resultat.Where(x => x.Date == 2022).ToList();
            //}
            //else if (filtrer.Criteres.selectAnnee == 2021)
            //{
            //    filtrer.Resultat = filtrer.Resultat.Where(x => x.Date == 2021).ToList();
            //}

            if (pCriteres.selectAnnee != null)
            {
                filtrer.Resultat = filtrer.Resultat.Where(x => x.Date == pCriteres.selectAnnee).ToList();
            }

            //message
            if (filtrer.Resultat.Count == 0)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");
            }


            return View(filtrer);
        }







        [Route("enfant/detail/{id:int}")]
        [Route("enfant/{id:int}")]
        [Route("e/{id:int}")]
        public IActionResult Detail(int id)
        {
            var filmRecherche = _baseDonnees.Enfants.Where(e => e.Id == id).SingleOrDefault();

            if (filmRecherche == null)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");

            }
            else
            {
                return View(filmRecherche);
            }
        }


        [Route("enfant/detail/{nom}")]
        [Route("enfant/{nom}")]
        //[Route("/{nom}")]
        public IActionResult Detail(string nom)

        {
            //var filmRecherche = _baseDonnees.Enfants.Where(p=> p.Id == id).SingleOrDefault();
            var filmRecherche = _baseDonnees.Enfants.Where(e => e.Nom.ToUpper() == nom.ToUpper()).SingleOrDefault();

            if (filmRecherche == null)
            {
                return View("NonTrouve", "Le film demandé n'a pas été trouvé!");

            }
            else
            {
                return View(filmRecherche);
            }
            //ViewData["titre"] = filmRecherche.Nom;


        }



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

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(EnfantVM enfantVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string webRootPath = _webHostEnvironment.WebRootPath; 
        //        var files = HttpContext.Request.Form.Files; 

        //        if (files.Count > 0)
        //        {    
        //            string fileName = Guid.NewGuid().ToString();
        //            var uploads = Path.Combine(webRootPath, AppConstants.ImagePath);
                  
        //            var extenstion = Path.GetExtension(files[0].FileName);
                 
        //            using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
        //            {
        //                files[0].CopyTo(filesStreams);
        //            }

        //            enfantVM.Enfant.ImageURL = fileName + extenstion;
        //        }

        //        await _baseDonnees.Enfants.AddAsync(enfantVM.Enfant);
        //        await _baseDonnees.SaveChangesAsync();
        //        TempData[AppConstants.Success] = $"Film {enfantVM.Enfant.Nom} a été creé";

        //        return this.RedirectToAction("Index");
        //    }
        //    enfantVM.ParentSelectList = _baseDonnees.Parents.Select(t => new SelectListItem
        //    {
        //        Text = t.Nom,
        //        Value = t.Id.ToString()
        //    }).OrderBy(t => t.Text);

        //    return View(enfantVM);
        //}
        


    }
}