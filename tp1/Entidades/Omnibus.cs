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
        public int Ramal
        {
            get; private set;
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
        public override string Detenerse()
        {
            var valoracionCliente = new Random().Next(0, 2);
            valoracionCliente += ComodidadPorRamal(this.ramal);
            this.valoracionTotal += valoracionCliente;
            return $"cliente llego exitosamente, su valoracion es de {valoracionCliente} sobre 5";

        }
        private int ComodidadPorRamal(int ramal)
        {
            if (ramal == 1)
            {
                return 1;
            }
            else if (ramal == 2)
            {
                return 2;
            }
            else if (ramal == 3)
            {
                return 3;
            }
            else
            {
                return -100;//flag
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"(Omnibus {(Ramales)this.ramal})";
        }
    }
}
