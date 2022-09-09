using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{

    public interface IRepositorioDirectorTecnico
    {
        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
        public IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos();
    }
}
