using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppTransporte
{
    public class Omnibus : TransportePublico
    {
        public int Pasajeros { get; set; }

        public Omnibus(int pasajeros) : base(pasajeros)
        {
            if (pasajeros <= 40 && pasajeros>=1) Pasajeros = pasajeros;
            else Pasajeros = -10;
        }

        public override string Avanzar()
        {
            return "Avanzar omnibus.";
        }

        public override string Detenerse()
        {
            return "Avanzar omnibus.";
        }

        public override string mostrarCantidadPasajeros()
        {
            return $"Este Omnibus tiene {Pasajeros} pasajeros.";
        }
    }
}
