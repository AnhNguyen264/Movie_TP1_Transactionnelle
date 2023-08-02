using TP2.Models;

namespace TP2.ViewModels
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }
        public List<Enfant> Resultat { get; set; }

        public PageRechercheViewModel() 
        { 
        }
    }
}
