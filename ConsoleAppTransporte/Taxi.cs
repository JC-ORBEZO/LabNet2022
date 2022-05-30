using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTransporte
{
    public class Taxi : TransportePublico
    {
        public int Pasajeros { get; set; }

        public Taxi(int pasajeros) : base(pasajeros)
        {
            if (pasajeros <= 5 && pasajeros>=1) Pasajeros = pasajeros;
            else Pasajeros = -10;
        }

        public override string Avanzar()
        {
            return "Avanzar taxi.";
        }

        public override string Detenerse()
        {
            return "Detener taxi.";
        }

        public override string mostrarCantidadPasajeros()
        {
            return $"Este taxi tiene {Pasajeros} pasajeros.";
        }
    }
}
