using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TP2.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public List<Enfant> Enfants { get; set; }
        public string Nom { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        //public List<ParentEnfant> ParentEnfant { get; set; }
        public Parent()
        {
            Enfants = new List<Enfant>();
        }

        //[ValidateNever]
        //public List<Enfant>? Enfant { get; set; }

    }
}
