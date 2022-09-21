using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Persistencia;
using Revisionvehiculo.app.Dominio;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //Dueño
        private readonly IRepositorioDuenio RepositorioDuenio;

        public IEnumerable<Duenio> Duenios { get; set; }

        public ListModel(IRepositorioDuenio RepositorioDuenio)
        {
            this.RepositorioDuenio = RepositorioDuenio;
        }
        public void OnGet()
        {
            Duenios = RepositorioDuenio.GetAll();
        }
    }
}
