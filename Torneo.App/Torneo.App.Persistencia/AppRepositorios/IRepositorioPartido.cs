using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPartido
    {
        public Partido AddPartido(Partido partido, int idEquipoLocal, int idEquipoVisitante);
        public IEnumerable<Partido> GetAllPartido();
        public Partido GetPartido(int idPartido);
        public Partido UpdatePartido(Partido partido, int idEquipoLocal, int idEquipoVisitante);
    }
}
