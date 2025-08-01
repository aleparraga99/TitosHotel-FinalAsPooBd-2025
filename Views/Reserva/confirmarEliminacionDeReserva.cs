using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel
{
    public partial class confirmarEliminacionDeReserva : Form
    {
        private DaoReserva oDaoReserva;
        private Reserva reservaParaEliminar;
        public confirmarEliminacionDeReserva(Reserva oReserva)
        {
            InitializeComponent();
            reservaParaEliminar = oReserva;
        }

        private void buttonCancelarEliminacionDeReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void buttonConfirmarEliminarDeReserva_Click(object sender, EventArgs e)
        {
            oDaoReserva.eliminar(reservaParaEliminar);
            this.Close();
            reservaEliminada ventana = new reservaEliminada();
            ventana.ShowDialog();
        }
    }
}
