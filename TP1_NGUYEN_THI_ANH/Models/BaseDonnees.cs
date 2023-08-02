using NuGet.Packaging;
using System;

namespace TP2.Models
{
    public class BaseDonnees
    {
        //public List<ParentEnfant> ParentEnfants = new List<ParentEnfant>();
        public List<Enfant> Enfants { get; set; }
        public List<Parent> Parents { get; set; }
        public BaseDonnees() {
            //Initialiser des listes vides
            Enfants = new List<Enfant>();
            Parents = new List<Parent>();
            //ParentEnfants = new List<ParentEnfant>();

            //Remplir la liste des Parents
            Parents.Add(new Parent() { Id=1, Nom= "NOUVEAUX", ImageURL = "/Image/parent top.jpeg",          Description= "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page." });
            Parents.Add(new Parent() { Id=2, Nom= "À VENIR", ImageURL = "/Image/parent-is comming.jpeg",   Description= "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page." });
            Parents.Add(new Parent() { Id=3, Nom= "LES PLUS VUS", ImageURL = "/Image/parent plus vus.jpeg", Description= "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page." });

            //Remplir la liste des Enfants
            Enfants.Add(new Enfant() { Id = 1, IdParent = 1, Nom = "Spider Man", ImageURL = "/Image/MOVIES_nouveau1.png",GenreDeFilm="Action", Date = 2023,Vus =1000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 2, IdParent = 1, Nom = "About my father", ImageURL = "/Image/MOVIES_nouveau2.png", GenreDeFilm="Action", Date = 2023, Vus = 2000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 3, IdParent = 1, Nom = "Blue Reette", ImageURL = "/Image/MOVIES_nouveau3.png", GenreDeFilm="Action", Date = 2023, Vus = 3000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 4, IdParent = 1, Nom = "Annihilation", ImageURL = "/Image/MOVIES_nouveau4.png", GenreDeFilm="Action", Date = 2023, Vus = 4000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 5, IdParent = 2, Nom = "World Collide", ImageURL = "/Image/MOVIES_avenir1.png", GenreDeFilm="Action", Date = 2022, Vus = 5000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 6, IdParent = 2, Nom = "World Collide 2", ImageURL = "/Image/MOVIES_avenir2.png", GenreDeFilm="Action", Date = 2022, Vus = 6000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 7, IdParent = 2, Nom = "Mutant Mayhem", ImageURL = "/Image/MOVIES_avenir3.png", GenreDeFilm="Action", Date = 2022, Vus = 7000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 8, IdParent = 2, Nom = "Titanic", ImageURL = "/Image/MOVIES_avenir4.png", GenreDeFilm="Action", Date = 2022, Vus = 8000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 9, IdParent = 3, Nom = "Inception", ImageURL = "/Image/MOVIES_lesplusvus1.png", GenreDeFilm="Action", Date = 2021, Vus = 9000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 10, IdParent = 3, Nom = "Batman Begins", ImageURL = "/Image/MOVIES_lesplusvus2.png", GenreDeFilm="Action", Date = 2021, Vus = 10000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 11, IdParent = 3, Nom = "Die hard", ImageURL = "/Image/MOVIES_lesplusvus3.png", GenreDeFilm="Action", Date = 2021, Vus = 11000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });
            Enfants.Add(new Enfant() { Id = 12, IdParent = 3, Nom = "Cold Souls", ImageURL = "/Image/MOVIES_lesplusvus4.png", GenreDeFilm="Action", Date = 2021, Vus = 12000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." });

            //ParentEnfants.Add(new ParentEnfant() { ParentId = 1, EnfantId = 1 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 1, EnfantId = 2 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 1, EnfantId = 3 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 1, EnfantId = 4 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 2, EnfantId = 1 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 2, EnfantId = 2 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 2, EnfantId = 3 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 2, EnfantId = 4 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 3, EnfantId = 1 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 3, EnfantId = 2 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 3, EnfantId = 3 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 3, EnfantId = 4 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 4, EnfantId = 1 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 4, EnfantId = 2 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 4, EnfantId = 3 });
            //ParentEnfants.Add(new ParentEnfant() { ParentId = 4, EnfantId = 4 });
            //Lier les objets enfants aux differents parents
            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.IdParent == p.Id));
            }
            foreach (var e in Enfants)
            {
                e.Parent = Parents.Where(p => p.Id == e.IdParent).Single();
            }

            //foreach (var element in ParentEnfants)
            //{
           
            //    element.Parent = Parents.Where(p => p.Id == element.ParentId).Single();
            //    element.Enfant = Enfants.Where(e => e.Id == element.EnfantId).Single();
            //    element.Parent.ParentEnfant.Add(element);
            //    element.Enfant.ParentEnfants.Add(element);
            //}
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
