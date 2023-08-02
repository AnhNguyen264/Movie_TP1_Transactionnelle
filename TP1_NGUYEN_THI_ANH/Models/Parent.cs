using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace TP2.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }

        public List<Enfant> Enfants { get; set; }

        [Display(Name = "Nom de statut")]
        [Required(AllowEmptyStrings =false, ErrorMessage = "{0} doit être rempli.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Le champ {0} demande un minimum de {1} et maximum de {2}.")]
        public string Nom { get; set; }


        public string ImageURL { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        //public List<ParentEnfant> ParentEnfant { get; set; }
        public Parent()
        {
            Enfants = new List<Enfant>();
        }

        //[ValidateNever]
        //public virtual List<Enfant>? Enfant { get; set; }

    }
}
