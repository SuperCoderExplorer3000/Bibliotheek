using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bibliotheek.business;
using Bibliotheek.persistence;

namespace WebApplicatieBibliotheek.Pages
{
    public class UpdatenModel : PageModel
    {
        [BindProperty]
        public int boekid { get; set; }

        [BindProperty]
        public int? isbn { get; set; }

        [BindProperty]
        public int? paginas { get; set; }

        [BindProperty]
        public string? titel { get; set; }

        [BindProperty]
        public int? genreid { get; set; }

        [BindProperty]
        public string? uitgever { get; set; }

        [BindProperty]
        public string? auteur { get; set; }

        [BindProperty]
        public string? taal { get; set; }

        [BindProperty]
        public int? graad { get; set; }

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

            var controller = new Bibliotheek.business.Controller();

            // Haal het bestaande boek op
            var bestaandBoek = controller.GetBoekById(boekid);
            if (bestaandBoek == null)
            {
                Bericht = "Boek niet gevonden!";
                return Page();
            }

            // Alleen ingevulde velden bijwerken
            if (isbn.HasValue)
                bestaandBoek.Isbn = isbn.Value;
            if (paginas.HasValue)
                bestaandBoek.Paginas = paginas.Value;
            if (!string.IsNullOrWhiteSpace(titel))
                bestaandBoek.Titel = titel;
            if (genreid.HasValue)
                bestaandBoek.Genreid = genreid.Value;
            if (!string.IsNullOrWhiteSpace(uitgever))
                bestaandBoek.Uitgever = uitgever;
            if (!string.IsNullOrWhiteSpace(auteur))
                bestaandBoek.Auteur = auteur;
            if (!string.IsNullOrWhiteSpace(taal))
                bestaandBoek.Taal = taal;
            if (graad.HasValue)
                bestaandBoek.Graad = graad.Value;

            controller.UpdateBoek(bestaandBoek);

            Bericht = "Boek is aangepast!";
            ModelState.Clear();
            return RedirectToPage("Overzicht");
        }
    }
}
