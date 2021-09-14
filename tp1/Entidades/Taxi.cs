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
            get; private set;
        }

        public Taxi(int pasajeros, string nombreChofer, int marca) : base(pasajeros, nombreChofer)
        {
            this.marca = marca;
        }
        public override string Avanzar()
        {
            var distanciaViaje = new Random().Next(20, 100);
            distanciaViaje += DistanciaPorMarca(this.marca);
            this.kilometrosRecorridos += ((decimal)distanciaViaje) / 10;
            return $"viaje de {distanciaViaje} Kms realizado";
        }
        public override string Detenerse()
        {
            var valoracionCliente = new Random().Next(1, 5);
            this.valoracionTotal += valoracionCliente;
            return $"bajo un pasajero, su valoracion es de {valoracionCliente} sobre 5";
        }
        private int DistanciaPorMarca(int marca)
        {
            if (marca == 1)
            {
                return 20;
            }else if (marca == 2)
            {
                return 30;
            }
            else if (marca == 3)
            {
                return 40;
            }
            else
            {
                return -100;//flag
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"(Taxi {(Marcas)this.marca})";
        }
    }
}
