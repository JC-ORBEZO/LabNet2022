using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int transportesDisponibles = 10;
            int salirDeMenu = 39;
            int ingresoIncorrecto = 40;
            int option = 0;
            List<TransportePublico> TransportesPublicos = new List<TransportePublico>();
            while (option==0)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---               TRANSPORTE              ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.Write("---");
                Console.Write($"       TRANSPORTES DISPONIBLES: {transportesDisponibles- TransportesPublicos.Count}      ");
                Console.WriteLine("---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---     Pasajeros en ómnibus: 1 - 40      ---");
                Console.WriteLine("---        Pasajeros en taxi: 1 - 5       ---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.Write("---");
                Console.Write("      1.- Cargar Pasajeros Ómnibus     ");
                Console.WriteLine("---");
                Console.Write("---");
                Console.Write("      2.- Cargar Pasajeros Taxi        ");
                Console.WriteLine("---");
                Console.Write("---");
                Console.Write("      3.- Listar Transportes           ");
                Console.WriteLine("---");
                Console.Write("---");
                Console.Write("      0.- Salir                        ");
                Console.WriteLine("---");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.Write("---");
                Console.Write("  Ingresar Opción:            ");
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    option = ingresoIncorrecto;
                }                
                //Console.WriteLine("--");
                //Console.WriteLine("---------------------------------------------");
                //Console.WriteLine("---------------------------------------------");                
                switch (option)
                {
                    case 1: Console.WriteLine("Opción 1");
                        Console.Write("Cantidad de pasajeros en ómnibus: ");
                        try
                        {
                            int cantiA = Int32.Parse(Console.ReadLine());
                            var omnibus = new Omnibus(cantiA);
                            if (omnibus.Pasajeros > 0)
                            {
                                Console.WriteLine("La cantidad de pasajeros fue registrada.");
                                TransportesPublicos.Add(omnibus);
                            }
                            else
                            {
                                Console.WriteLine("El ómnibus acepta de 0 a 40 pasajeros");
                                Console.WriteLine("Vuelva a intentarlo.");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ingreso Incorrecto");
                            Console.WriteLine("Vuelva a intentarlo.");
                            option = 0;
                        }                                        
                        Console.ReadKey();
                        Console.Clear();
                        option = 0;
                        break;
                    case 2: Console.WriteLine("Opción 2");
                        Console.Write("Cantidad de pasajeros en taxi: ");
                        try
                        {
                            int cantiB = Int32.Parse(Console.ReadLine());
                            var taxi = new Taxi(cantiB);
                            if (taxi.Pasajeros > 0)
                            {
                                Console.WriteLine("La cantidad de pasajeros fue registrada.");
                                TransportesPublicos.Add(taxi);
                            }
                            else
                            {
                                Console.WriteLine("El taxi acepta de 0 a 5 pasajeros");
                                Console.WriteLine("Vuelva a intentarlo.");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ingreso Incorrecto");
                            Console.WriteLine("Vuelva a intentarlo.");
                            option = 0;
                        }
                        
                        Console.ReadKey();
                        Console.Clear();
                        option = 0;
                        break;
                    case 3:
                        if (TransportesPublicos.Count!=0)
                        {
                            foreach (var item in TransportesPublicos)
                            {
                                Console.WriteLine(item.mostrarCantidadPasajeros());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aún no fue agregado ningún transporte.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        option = 0;
                        break;
                    case 0:
                        Console.Clear();
                        option = salirDeMenu;                        
                        break;
                    default: Console.WriteLine("Ingreso Incorrecto");
                        option = 0;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }                
            }
        }
    }
}
