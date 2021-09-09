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
    public partial class RecorridosForm : Form
    {
        List<TransportePublico> transportes;
        public RecorridosForm(List<TransportePublico> transportes)
        {
            this.transportes = transportes;
            foreach(TransportePublico item in transportes)
            {
                item.RealizarViajes();
            }

            InitializeComponent();
            resultadosTxt.DataSource = transportes;
            resultadosTxt.DisplayMember = "Resultado";
        }

        private void detalleBtn_Click(object sender, EventArgs e)
        {
            DetalleForm detalleForm = new DetalleForm((TransportePublico)this.resultadosTxt.SelectedItem);
            detalleForm.Show();
        }
    }
}
