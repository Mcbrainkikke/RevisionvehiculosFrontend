using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioDuenio RepositorioDuenio;
        [BindProperty]

        public Duenio Duenio {get;set;}

        public EditModel(IRepositorioDuenio RepositorioDuenio)
        {
            this.RepositorioDuenio = RepositorioDuenio;
        }
        public IActionResult OnGet(int IdDuenio)
        {
            Duenio = RepositorioDuenio.GetDuenio(IdDuenio);
            if(Duenio == null)
            {
                return RedirectToPage("./NotFound"); 
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            Duenio = RepositorioDuenio.UpdateDuenio(Duenio);
            return Page();
        }
    }
}
