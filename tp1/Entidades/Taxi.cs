using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taxi : TransportePublico
    {
        private int marca;
        public int Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }
        
        public Taxi(int pasajeros, string nombreChofer, int marca) : base(pasajeros, nombreChofer)
        {
            this.marca = marca;
        }
        public override string Avanzar()
        {
            var distanciaViaje = new Random().Next(20, 100) ;
            this.kilometrosRecorridos += ((decimal)distanciaViaje)/10;
            return $"viaje de {distanciaViaje} Kms realizado";
        }
        public override string ToString()
        {
            return base.ToString() + $"(Taxi {(Marcas)this.marca})";
        }
    }
}
