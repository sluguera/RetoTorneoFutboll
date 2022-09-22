using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Frontend.Pages.DTs
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDT;
        public IEnumerable<DirectorTecnico> dts { get; set; }

        public IndexModel(IRepositorioDirectorTecnico repoDT)
        {
            _repoDT = repoDT;
        }

        public void OnGet()
        {
            dts = _repoDT.GetAllDTs();
        }
    }
}
