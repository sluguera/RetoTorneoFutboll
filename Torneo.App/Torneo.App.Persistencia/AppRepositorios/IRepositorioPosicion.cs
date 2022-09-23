using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPosicion
    {
        public Posicion AddPosicion(Posicion posicion);
        public IEnumerable<Posicion> GetAllPosiciones();
        public Posicion GetPosicion(int idPosicion);
    }

}
