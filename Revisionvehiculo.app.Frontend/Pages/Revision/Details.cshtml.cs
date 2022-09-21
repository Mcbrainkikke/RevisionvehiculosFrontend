using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Persistencia;
using Revisionvehiculo.app.Dominio;


namespace Revisionvehiculo.app.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        //Dueño
        private readonly IRepositorioDuenio RepositorioDuenio;

        public Duenio Duenio {get;set;}

        public DetailsModel(IRepositorioDuenio RepositorioDuenio)
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


    }
}
