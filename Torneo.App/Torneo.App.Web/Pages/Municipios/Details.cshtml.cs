using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Web.Pages.Municipios
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Municipio municipio { get; set; }
        public DetailsModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }

        public IActionResult OnGet(int id)
        {
            municipio = _repoMunicipio.GetMunicipio(id);
            if (municipio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
