using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bibliotheek.business;
using Bibliotheek.persistence;

namespace WebApplicatieBibliotheek.Pages
{
    public class OverzichtModel : PageModel
    {
        public List<Boek> boeken { get; set; }
        public void OnGet()
        {
            var mapper = new BoekMapper();
            boeken = mapper.GetBoeken();
        }
    }
}
