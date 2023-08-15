using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Models;


namespace TP2.Models.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            builder.Entity<Enfant>().HasData(
            new Enfant { Id = 1, IdParent = 1, Nom = "Spider Man", ImageURL = "/Image/MOVIES_nouveau1.png", GenreDeFilm = "Action", Date = 2023, Vus = 1000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 2, IdParent = 1, Nom = "About my father", ImageURL = "/Image/MOVIES_nouveau2.png", GenreDeFilm = "Action", Date = 2023, Vus = 2000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 3, IdParent = 1, Nom = "Blue Reette", ImageURL = "/Image/MOVIES_nouveau3.png", GenreDeFilm = "Action", Date = 2023, Vus = 3000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 4, IdParent = 1, Nom = "Annihilation", ImageURL = "/Image/MOVIES_nouveau4.png", GenreDeFilm = "Action", Date = 2023, Vus = 4000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 5, IdParent = 2, Nom = "World Collide", ImageURL = "/Image/MOVIES_avenir1.png", GenreDeFilm = "Action", Date = 2022, Vus = 5000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 6, IdParent = 2, Nom = "World Collide 2", ImageURL = "/Image/MOVIES_avenir2.png", GenreDeFilm = "Action", Date = 2022, Vus = 6000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 7, IdParent = 2, Nom = "Mutant Mayhem", ImageURL = "/Image/MOVIES_avenir3.png", GenreDeFilm = "Action", Date = 2022, Vus = 7000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 8, IdParent = 2, Nom = "Titanic", ImageURL = "/Image/MOVIES_avenir4.png", GenreDeFilm = "Action", Date = 2022, Vus = 8000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 9, IdParent = 3, Nom = "Inception", ImageURL = "/Image/MOVIES_lesplusvus1.png", GenreDeFilm = "Action", Date = 2021, Vus = 9000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 10, IdParent = 3, Nom = "Batman Begins", ImageURL = "/Image/MOVIES_lesplusvus2.png", GenreDeFilm = "Action", Date = 2021, Vus = 10000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 11, IdParent = 3, Nom = "Die hard", ImageURL = "/Image/MOVIES_lesplusvus3.png", GenreDeFilm = "Action", Date = 2021, Vus = 11000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." },
            new Enfant { Id = 12, IdParent = 3, Nom = "Cold Souls", ImageURL = "/Image/MOVIES_lesplusvus4.png", GenreDeFilm = "Action", Date = 2021, Vus = 12000, Description = "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum." }

                );

            builder.Entity<Parent>().HasData(

            new Parent { Id = 1, Nom = "NOUVEAUX", ImageURL = "/Image/parent top.jpeg", Description = "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page." },
            new Parent { Id = 2, Nom = "À VENIR", ImageURL = "/Image/parent-is comming.jpeg", Description = "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page." },
            new Parent { Id = 3, Nom = "LES PLUS VUS", ImageURL = "/Image/parent plus vus.jpeg", Description = "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page." }

                );

        }

    }
}
