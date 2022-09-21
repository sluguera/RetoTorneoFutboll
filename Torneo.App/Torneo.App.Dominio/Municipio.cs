using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Torneo.App.Dominio;
public class Municipio
{
    public int Id {get; set;}
    public string? Nombre {get; set;}
    public List<Equipo>? Equipos { get; set; }



}
