using Humanizer;
using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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

        [ForeignKey("Parent")]
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
