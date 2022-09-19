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
        public IActionResult OnGet(int? IdDuenio)
        {
            if(IdDuenio.HasValue)
            {
            Duenio = RepositorioDuenio.GetDuenio(IdDuenio.Value);
            }
            else 
            {            
                Duenio = new Duenio();
            }

            if(Duenio == null)
            {
                return RedirectToPage("./NotFound"); 
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            if(Duenio.Id > 0 )
            {
                Duenio = RepositorioDuenio.UpdateDuenio(Duenio);
            }
            else
            {
                RepositorioDuenio.AddDuenio(Duenio);
            }
            return Page();
        }
    }
}
