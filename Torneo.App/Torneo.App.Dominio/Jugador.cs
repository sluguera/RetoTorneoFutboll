using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneo.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }
    }
}