using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace tp1
{
    public partial class MainForm : Form
    {
        private List<TransportePublico> transportes = new List<TransportePublico>();
        public MainForm()
        {
            InitializeComponent();
            this.marcaBox.DataSource = Enum.GetValues(typeof(Marcas));
            this.ramalBox.DataSource = Enum.GetValues(typeof(Ramales));
        }

        private void taxiBtn_Click(object sender, EventArgs e)
        {
            int cantidadPasajeros;
            int.TryParse(this.pasajerosTaxiTxt.Text, out cantidadPasajeros);
            if (cantidadPasajeros > 0 && cantidadPasajeros < 5)
            {
                if (comprobacionNombre(this.nombreTaxiTxt.Text.Trim()))
                {
                    var nuevoTransporte = new Taxi(cantidadPasajeros, this.nombreTaxiTxt.Text.Trim(), (int)this.marcaBox.SelectedItem);
                    agregarTransporte(nuevoTransporte);
                }
                else
                {
                    MessageBox.Show("El nombre ya ha sido elegido");
                }
            }
            else
            {
                this.pasajerosTaxiTxt.Text = "";
                MessageBox.Show("Ingrese un numero valido de pasajeros (de 1 a 4)");
            }
        }

        private void omnibusBtn_Click(object sender, EventArgs e)
        {
            int cantidadPasajeros;
            int.TryParse(this.pasajerosOmnibusTxt.Text, out cantidadPasajeros);
            if (cantidadPasajeros > 0 && cantidadPasajeros < 51)
            {
                if (comprobacionNombre(this.nombreOmnibusTxt.Text.Trim()))
                {
                var nuevoTransporte = new Omnibus(cantidadPasajeros, this.nombreOmnibusTxt.Text.Trim(), (int)this.ramalBox.SelectedItem);
                agregarTransporte(nuevoTransporte);
                }
                else
                {
                    MessageBox.Show("El nombre ya ha sido elegido");
                }
            }
            else
            {
                this.pasajerosOmnibusTxt.Text = "";
                MessageBox.Show("Ingrese un numero valido de pasajeros (de 1 a 50)");
            }
        }
        private void agregarTransporte(TransportePublico transporte)
        {
            this.transportes.Add(transporte);

            var sb = new StringBuilder("Transportes añadidos\n");
            foreach (TransportePublico item in transportes)
            {
                sb.AppendLine(item.ToString());
            }
            this.transportesTxt.Text = sb.ToString();
        }
        private bool comprobacionNombre(string nombre)
        {
            foreach (TransportePublico item in transportes)
            {
                if (item.NombreChofer == nombre)
                {
                    return false;
                }
            }
            return true;
        }

        private void comenzarBtn_Click(object sender, EventArgs e)
        {
            RecorridosForm recorridosForm = new RecorridosForm(transportes);
            recorridosForm.Show();
        }
    }
}
