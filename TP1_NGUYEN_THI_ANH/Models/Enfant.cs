using Humanizer;
using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Razor.Hosting;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace TP2.Models
{
    public class Enfant
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom de statut")]
        [ForeignKey("Parent")]
        public int IdParent { get; set; }

        [Display(Name = "Nom de film")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Le champ {0} demande un minimum de {1} et maximum de {2}.")]
        public string Nom { get; set; }

        [Display(Name = "Image")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public string ImageURL { get; set; }


        [Display(Name = "Genre de film")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public string GenreDeFilm { get; set; }


        [Display(Name = "Date de sortie du film")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public int Date { get; set; }

        [Display(Name = "Les vues")] 
        public int Vus { get; set; }

        [Display(Name = "Description")]
        [StringLength(1000)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public string Description { get; set; }



        [ValidateNever]
        public virtual Parent? Parent { get; set; }
        //public List<ParentEnfant> ParentEnfants { get; set; }
        //public Enfant()
        //{
        //    ParentEnfants = new List<ParentEnfant>();
        //}

    }
}
