using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tito_s_Hotel.Controllers;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel
{
    public partial class confirmarEliminacionDeReserva : Form
    {
        ControllerReserva oControllerReserva = ControllerReserva.GetInstanciaControllerReserva();
        public confirmarEliminacionDeReserva(Reserva reservaSeleccionada)
        {
            InitializeComponent();
        }
        private void buttonCancelarEliminacionDeReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmarEliminarDeReserva_Click(object sender, EventArgs e)
        {
            //oControllerReserva.eliminar();
            this.Close();
        }
    }
}
