using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEquipo
    {
        public Equipo AddEquipo(Equipo equipo, int idMunicipio, int idDT);
        public IEnumerable<Equipo> GetAllEquipos();
        public Equipo GetEquipo(int idEquipo);
        public Equipo UpdateEquipo(Equipo equipo, int idMunicipio, int idDT);
        public IEnumerable<Equipo> GetEquiposMunicipio(int idMunicipio);
        public IEnumerable<Equipo> SearchEquipos(string nombre);
    }
}
