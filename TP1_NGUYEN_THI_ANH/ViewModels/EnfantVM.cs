using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;
using TP2.Models;

namespace TP2.ViewModels
{
    public class EnfantVM
    {
        public Enfant Enfant { get; set; }

        public IEnumerable<SelectListItem>? ParentSelectList { get; set; }

        [ValidateNever]
        public string? OldImage { get; set; } = "";

    }
}
