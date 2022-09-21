using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Revisionvehiculo.app.Dominio;
using Revisionvehiculo.app.Persistencia;

namespace Revisionvehiculo.app.Frontend.Pages
{
    public class ListMecanicosModel : PageModel
    {
//Mecanico
        private readonly IRepositorioMecanico RepositorioMecanico;

        public IEnumerable<Mecanico> Mecanicos { get; set; }

        public ListMecanicosModel(IRepositorioMecanico RepositorioMecanico)
        {
            this.RepositorioMecanico = RepositorioMecanico;
        }
        public void OnGet()
        {
            Mecanicos = RepositorioMecanico.GetAllMecanicos();
        }
    }
}
