using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicatieBibliotheek.Pages
{
    public class VerwijderenModel : PageModel
    {
        [BindProperty]
        public int boekID { get; set; }
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
            controller.DeleteBoek(boekID);

            ModelState.Clear();
            return RedirectToPage("Overzicht");
        }
    }
}
