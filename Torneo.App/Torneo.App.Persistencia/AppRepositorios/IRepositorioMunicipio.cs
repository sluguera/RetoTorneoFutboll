using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMunicipio
    {
        public Municipio AddMunicipio(Municipio municipio);
        public IEnumerable<Municipio> GetAllMunicipios();
        public Municipio GetMunicipio(int idMunicipio);
        public Municipio UpdateMunicipio(Municipio municipio);
        public Municipio DeleteMunicipio(int idMunicipio);
    }
}
