namespace TP2.ViewModels
{
    public class CritereRechercheViewModel
    {

        
        public string search_byword { get; set; }
        public int? selectAnnee { get; set; } 
        public bool statut1 { get; set; } // nouveau
        public bool statut2 { get; set; } // a venir
        public bool statut3 { get; set; } // les plus vus
        public int? vus_min { get; set; }
        public int? vus_max { get; set; }
        public CritereRechercheViewModel() 
        { 
        
        
        }
    }
}
