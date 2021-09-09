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
    public partial class DetalleForm : Form
    {
        public DetalleForm(TransportePublico detalleTransporte)
        {
            InitializeComponent();
            this.detalleTxt.Text = detalleTransporte.InformacionViaje;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
