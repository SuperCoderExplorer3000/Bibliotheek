using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bibliotheek.business;
using Bibliotheek.persistence;

namespace WebApplicatieBibliotheek.Pages
{
    public class ToevoegenModel : PageModel
    {
        [BindProperty]
        public int ISBN { get; set; }

        [BindProperty]
        public int paginas { get; set; } 

        [BindProperty]
        public string titel { get; set; }

        [BindProperty]
        public int genreID { get; set; } 

        [BindProperty]
        public string uitgever { get; set; }

        [BindProperty]
        public string auteur { get; set; }

        [BindProperty]

        public string taal { get; set; }

        [BindProperty]

        public int graad { get; set; }  

        public string Bericht { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Bibliotheek.business.Controller controller = new Bibliotheek.business.Controller();
            controller.AddBoek(ISBN, paginas, titel, genreID, uitgever, auteur, taal, graad);

            Bericht = "boek is toegevoegd!";
            ModelState.Clear(); 

            return Page();
        }
    }
}
