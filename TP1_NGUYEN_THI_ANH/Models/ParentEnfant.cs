namespace TP2.Models
{
    public class ParentEnfant
    {
        public int ParentId { get; set; }
        public int EnfantId { get; set; }
        public Parent Parent { get; set; }
        public Enfant Enfant { get; set; }
      
    }
}
