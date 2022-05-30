using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTransporte
{
    public abstract class TransportePublico
    {
        public int asientosDisponibles{ get; set; }
        public int pasajeros { get; set; }

        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract string mostrarCantidadPasajeros();
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
