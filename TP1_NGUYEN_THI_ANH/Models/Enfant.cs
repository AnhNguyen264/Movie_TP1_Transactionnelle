using Humanizer;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TP2.Models
{
    public class Enfant
    {
        public int Id { get; set; }
        public int IdParent { get; set; }

     
        public Parent? Parent { get; set; }
        public string Nom { get; set; }
        public string ImageURL { get; set; }
        public string GenreDeFilm { get; set; }
        public int Date { get; set; }
        public int Vus { get; set; }

        public string Description { get; set; }

      //public List<ParentEnfant> ParentEnfants { get; set; }
        //public Enfant()
        //{
        //    ParentEnfants = new List<ParentEnfant>();
        //}

    }
}
