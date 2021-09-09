using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Omnibus : TransportePublico
    {
        private int ramal;
        public int Linea
        {
            get
            {
                return this.ramal;
            }
            set
            {
                this.ramal = value;
            }
        }
        public Omnibus(int pasajeros, string nombreChofer, int ramal) : base(pasajeros, nombreChofer)
        {
            this.ramal = ramal;
        }
        public override string Avanzar()
        {
            var distanciaViaje = new Random().Next(0, 20);
            this.kilometrosRecorridos += distanciaViaje;
            return $"parada ubicada a {distanciaViaje} Kms alcanzada";
        }
        public override string ToString()
        {
            return base.ToString() + $"(Omnibus {(Ramales)this.ramal})";
        }
    }
}
