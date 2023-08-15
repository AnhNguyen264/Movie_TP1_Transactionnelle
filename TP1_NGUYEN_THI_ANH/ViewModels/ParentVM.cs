using TP2.Models;

namespace TP2.ViewModels
{
    public class ParentVM
    {

        public Parent parent { get; set; }
        public List<Enfant> EnfantList { get; set; } = new List<Enfant>();
        public int EnfantCount { get; set; }
       
    }
}
