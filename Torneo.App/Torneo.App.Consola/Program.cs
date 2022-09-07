using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.App.Dominio;
using Torneo.App.Persistencia.AppRepositorios;

namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT _repoDirectorTecnico = new RepositorioDT();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        private static IRepositorioPosicion _repoPosicion = new RepositorioPosicion();
        static void Main(string[] args)
        {

       
            Console.WriteLine("Selecione opcion a trabajar");
            //Console.WriteLine("1. Municipios");
            //Console.WriteLine("2. Director Tecnico");
            //Console.WriteLine("3. Equipos"); agregar y mostrar de            
            Console.WriteLine("1. Partido");
            Console.WriteLine("2. Posicion");
            Console.WriteLine("3. Jugador");
                //Console.ReadKey();
                int selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("1. Agregar Partido");
                    Console.WriteLine("2. Mostrar Partido");
                    selecionar = int.Parse(Console.ReadLine());

                    if (selecionar == 1)
                        Console.WriteLine("Agregar Partido");
                    //AddPartido();
                    if (selecionar ==2)
                    {
                        Console.WriteLine("Mostrar Partido");
                    //MostrarPartido();
                    }
                }

                if (selecionar == 2)
                {
                    Console.WriteLine("1. Agregar Posicion");
                    Console.WriteLine("2. Mostrar Posicion");
                    selecionar = int.Parse(Console.ReadLine());

                    if (selecionar == 1)
                        Console.WriteLine("Agregar Posición");
                    AddPosicion();
                    if (selecionar == 2)
                    {
                        Console.WriteLine("Mostrar Posición");
                        //MostrarPartido();
                    }
                }

                if (selecionar == 3)
                {
                    Console.WriteLine("1. Agregar Jugador");
                    Console.WriteLine("2. Mostrar Jugador");
                    selecionar = int.Parse(Console.ReadLine());

                    if (selecionar == 1)
                        Console.WriteLine("Agregar Jugador");
                    //AddPosicion();
                    if (selecionar == 2)
                    {
                        Console.WriteLine("Mostrar Jugador");
                        //MostrarPartido();
                    }
                }


                
                //AddMunicipio();
                //AddDirectorTecnico();
                //AddEquipo();
                //GetAllMunicipios();
                Console.Clear();
      



        }

        private static void AddPosicion()
        {

            Console.WriteLine("Selecione la posicion a agregar:"); 
            Console.WriteLine("1. PORTERO");
            Console.WriteLine("2. DEFENSA CENTRAL ");
            Console.WriteLine("3. DEFENSA LATERAL ");
            Console.WriteLine("4. MEDIOCENTRO/ CENTROCAMPISTA");
            Console.WriteLine("5. MEDIAPUNTA");
            Console.WriteLine("6. MEDIOCENTRO DEFENSIVO");
            Console.WriteLine("7. INTERIOR DERECHO O IZQUIERDO");
            Console.WriteLine("8. DELANTERO CENTRO");
            Console.WriteLine("9. SEGUNDA PUNTA");
            Console.WriteLine("10. EXTREMO");
            int num = int.Parse(Console.ReadLine());
            string prueba= "vacio";

            switch (num)
            {
                case 1:
                    prueba = "PORTERO";
                    break;
                case 2:
                    prueba = "DEFENSA CENTRAL";
                    break;
                case 3:
                    prueba = "DEFENSA LATERAL";
                    break;
                case 4:
                    prueba = "CENTROCAMPISTA";
                    break;
                case 5:
                    prueba = "MEDIAPUNTA";
                    break;
                case 6:
                    prueba = "MEDIOCENTRO DEFENSIVO";
                    break;
                case 7:
                    prueba = " INTERIOR DERECHO O IZQUIERDO";
                    break;
                case 8:
                    prueba = "DELANTERO CENTRO";
                    break;
                case 9:
                    prueba = "SEGUNDA PUNTA";
                    break;
                case 10:
                    prueba = "EXTREMO";
                    break;

                default:
                    break;
            }

            var posicion = new Posicion
            {
                Nombre = prueba,
            };
            _repoPosicion.AddPosicion(posicion);
        }

        //private static void AddPartido()
        //{
        //    var partido = new Partido
        //    {
        //        FechaHora = DateTime.Now,
        //        Local = ('Once Caldas', 1, 1),
        //        MarcadorLocal = 0,
        //        Visitante = new NewStruct("Medellin", '3', '3'),
        //        MarcadorVisitante = 5,
        //    };
        //    _repoPartido.AddPartido(partido);
        //}

        //private static void GetAllMunicipios()
        //{
        //    foreach (var municipio in _repoMunicipio.GetAllMunicipios())
        //        {
        //        Console.WriteLine(municipio.Id + " " + municipio.Nombre);
        //        }
        //}

        private static void AddEquipo()
        {
            var equipo = new Equipo
            {
                Nombre = "Once Caldas",
            };
            _repoEquipo.AddEquipo(equipo, 1, 1);
        }

        private static void AddDirectorTecnico()
        {
            var directorTecnico = new DirectorTecnico
            {
                Nombre = "Pedro Castro",
                Documento = "80226980",
                Telefono = "3004792213",   
            };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);            
        }

        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre = "Manizales",
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
    }
}

