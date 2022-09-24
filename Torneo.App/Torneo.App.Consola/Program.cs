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
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        private static IRepositorioPosicion _repoPosicion = new RepositorioPosicion();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();

        static void Main(string[] args)
        {
            #region Menu Inicio
            Console.WriteLine("Selecione opcion a trabajar");             
            Console.WriteLine("1. Partido");
            Console.WriteLine("2. Posicion");
            Console.WriteLine("3. Jugador");
            Console.WriteLine("4. Municipios");
            Console.WriteLine("5. Director Tecnico");
            Console.WriteLine("6. Equipos");
            //Console.ReadKey();
            int selecionar = int.Parse(Console.ReadLine());
            #endregion

            if (selecionar == 1)
            {
                Console.WriteLine("1. Agregar Partido");
                Console.WriteLine("2. Mostrar Partido");
                selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("Agregar Partido");
                    AddPartido();
                }
                if (selecionar == 2)
                {
                    Console.WriteLine("Mostrar Partido \n");
                    MostrarPartido();
                }
            }

            if (selecionar == 2)
            {
                Console.WriteLine("1. Agregar Posicion");
                Console.WriteLine("2. Mostrar Posicion");
                int selecionar2 = int.Parse(Console.ReadLine());

                if (selecionar2 == 1)
                {
                    Console.WriteLine("Agregar Posición");
                    AddPosicion();
                }
                if (selecionar2 == 2)
                {
                    Console.WriteLine("Mostrar Posición");
                    GetAllPosiciones();
                    Console.ReadKey();

                }
            }

            if (selecionar == 3)
            {
                Console.WriteLine("1. Agregar Jugador");
                Console.WriteLine("2. Mostrar Jugador");
                selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("Agregar Jugador");
                    AddJugador();
                }

                if (selecionar == 2)
                {
                    Console.WriteLine("Mostrar Jugador");
                    GetAllJugadores();
                    Console.ReadKey();
                }
            }
            if (selecionar == 4)
            {
                Console.WriteLine("1. Agregar Municipios");
                Console.WriteLine("2. Mostrar Municipios");
                selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("Agregar Municipios");
                    AddMunicipio();
                }

                if (selecionar == 2)
                {
                    Console.WriteLine("Mostrar Municipios");
                    GetAllMunicipios();
                    Console.ReadKey();
                }

            }
            if (selecionar == 5)
            {
                Console.WriteLine("1. Agregar Director Tecnico");
                Console.WriteLine("2. Mostrar Director Tecnico");
                selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("Director Tecnico");
                    AddDirectorTecnico();
                }

                if (selecionar == 2)
                {
                    Console.WriteLine("Director Tecnico");
                    GetAllDirectorTecnico();
                    Console.ReadKey();
                }

            }
            if (selecionar == 6)
            {
                Console.WriteLine("1. Agregar Equipos");
                Console.WriteLine("2. Mostrar Equipos");
                selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("Agregar Equipos");
                    AddEquipo();
                }

                if (selecionar == 2)
                {
                    Console.WriteLine("Mostrar Equipos");
                    GetAllEquipo();
                    Console.ReadKey();
                }

            }
        }

        private static void GetAllEquipo()
        {
            foreach (var equipo in _repoEquipo.GetAllEquipos())
            {
                Console.WriteLine(equipo.Id + " " + equipo.Nombre + "\t\t" + equipo.Municipio.Nombre + "\t" + equipo.DirectorTecnico.Nombre);
                //Console.WriteLine("\n");
            }
        }

        private static void GetAllDirectorTecnico()
        {

            foreach (var directorTecnico in _repoDirectorTecnico.GetAllDTs())
            {
                Console.WriteLine(directorTecnico.Id + "\t" + directorTecnico.Nombre + "\t" + directorTecnico.Documento + "\t" + directorTecnico.Telefono);
                
            }
        }

        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                Console.WriteLine(municipio.Id + " " + municipio.Nombre);
            }
        }

        private static void MostrarPartido()
        {
            foreach (var partido in _repoPartido.GetAllPartido())
            {
                Console.WriteLine(partido.Id + "\t" + partido.FechaHora + "\t\t" + partido.Local.Nombre + "\t\t" + partido.MarcadorLocal + "\t\t" + partido.Visitante.Nombre + "\t\t" + partido.MarcadorVisitante);
            }
        }

        private static void AddPartido()
        {

            int equipoLocal;
            Console.WriteLine("Introducir el ID equipo local");
            equipoLocal = int.Parse(Console.ReadLine());

            int equipoVisitante;
            Console.WriteLine("Introduzca el ID Equipo visitante");
            equipoVisitante = int.Parse(Console.ReadLine());

            int marcadorLocal;
            Console.WriteLine("Introduzca el marcador del equipo local");
            marcadorLocal = int.Parse(Console.ReadLine());

            int marcadorVisitante;
            Console.WriteLine("Introduzca el marcador del equipo local");
            marcadorVisitante = int.Parse(Console.ReadLine());

            var partido = new Partido
            {
                FechaHora = DateTime.Now,
                MarcadorLocal = marcadorLocal,
                MarcadorVisitante = marcadorVisitante,

            };
            _repoPartido.AddPartido(partido, equipoLocal, equipoVisitante);
        }

        private static void GetAllJugadores()
        {
            foreach (var jugador in _repoJugador.GetAllJugador())
            {
                Console.WriteLine(jugador.Id + "\t" + jugador.Nombre + "\t\t" + jugador.Numero + "\t\t" + jugador.Equipo.Nombre + "\t\t" + jugador.Posicion.Nombre);
            }
        }

        private static void AddJugador()
        {
            string nombre;
            Console.WriteLine("Introducir el Nombre del Jugador");
            nombre = Console.ReadLine();

            int numero;
            Console.WriteLine("Introducir el Numero del Jugador");
            numero = int.Parse(Console.ReadLine());

            int equipoId;
            Console.WriteLine("Introduzca el Id del Equipo");
            equipoId = int.Parse(Console.ReadLine());

            int posicionId;
            Console.WriteLine("Introduzca el Id de la posicion");
            posicionId = int.Parse(Console.ReadLine());

            var jugador = new Jugador
            {
                Nombre = nombre,
                Numero = numero,
            };
            _repoJugador.AddJugador(jugador, equipoId, posicionId);

        }

        private static void GetAllPosiciones()
        {
            foreach (var posicion in _repoPosicion.GetAllPosiciones())
            {
                Console.WriteLine(posicion.Id + " " + posicion.Nombre);
            }
        }

        private static void GetPosicion()
        {
            foreach (var posicion in _repoPosicion.GetAllPosiciones())
            {
                Console.WriteLine(posicion.Id + " " + posicion.Nombre);
            }
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
            string prueba = "vacio";

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
            string nombreEquipo;
            Console.WriteLine("Introduzca el nombre del equipo");
            nombreEquipo = Console.ReadLine();

            int municipio;
            Console.WriteLine("Introduzca el Id del Municipio");
            municipio = int.Parse(Console.ReadLine());

            int directorTecnico;
            Console.WriteLine("Introduzca el Id del Director Tecnico");
            directorTecnico = int.Parse(Console.ReadLine());

            var equipo = new Equipo
            {
                Nombre = nombreEquipo,
            };
            _repoEquipo.AddEquipo(equipo, municipio, directorTecnico);
        }

        private static void AddDirectorTecnico()
        {
            string nombre;
            Console.WriteLine("Introduzca el nombre del tecnico");
            nombre = Console.ReadLine();

            string documento;
            Console.WriteLine("Introduzca el documento");
            documento = Console.ReadLine();

            string telefono;
            Console.WriteLine("Introduzca el telefono");
            telefono = Console.ReadLine();

            var directorTecnico = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
            };
            _repoDirectorTecnico.AddDT(directorTecnico);
        }

        private static void AddMunicipio()
        {
            string nombre;
            Console.WriteLine("Introducir el Municipio");
            nombre = Console.ReadLine();


            var municipio = new Municipio
            {
                Nombre = nombre,
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
    }
}

