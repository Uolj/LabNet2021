using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Ramales
    {
        Ezeiza = 1,
        Olivos = 2,
        Costero = 3,
    }
    public enum Marcas
    {
        Chevrolet = 1,
        MercedesBenz = 2,
        Torino = 3
    }
    public abstract class TransportePublico
    {
        protected int pasajeros;
        protected string nombreChofer;
        protected decimal kilometrosRecorridos = 0;
        protected decimal valoracionTotal = 0;
        protected string informacionViaje;
        public int Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
            set
            {
                this.pasajeros = value;
            }
        }
        public string NombreChofer
        {
            get
            {
                return this.nombreChofer;
            }
            set
            {
                this.nombreChofer = value;
            }
        }
        public string Resultado
        {
            get
            {
                return $"{this.nombreChofer} -kilometros recorridos: {this.kilometrosRecorridos}-puntuacion final: {valoracionTotal}";
            }
        }
        public string InformacionViaje
        {
            get
            {
                return this.informacionViaje;
            }
        }
        public TransportePublico(int pasajeros, string nombreChofer)
        {
            this.pasajeros = pasajeros;
            this.nombreChofer = nombreChofer;
        }

        public abstract string Avanzar();

        public string Detenerse()
        {
            var valoracionCliente = new Random().Next(1, 5);
            this.valoracionTotal += valoracionCliente;
            return $"cliente llego exitosamente, su valoracion es de {valoracionCliente} sobre 5";
        }

        public void RealizarViajes()
        {
            //realizo los viajes y guardo los km, la valoracion y
            //la info del mismo.

            var sb = new StringBuilder("Comienza el viaje:\n");
            for (int i = 0; i < pasajeros; i++)
            {
                sb.AppendLine(this.Avanzar());
                sb.AppendLine(this.Detenerse());
            }
            this.informacionViaje = sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.nombreChofer}, {this.pasajeros} pasajeros";
        }
    }
}
