using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Web.Pages
{
    public class MunicipioModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Municipio> municipios { get; set; }
        public MunicipioModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }

        public void OnGet()
        {
            municipios = _repoMunicipio.GetAllMunicipios();
        }
    }
}
