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
using Tito_s_Hotel.Views;
using Tito_s_Hotel.Views.Pasajero;

namespace Tito_s_Hotel
{
    public partial class viewGeneral : Form
    {
        private DaoReserva oDaoReserva;
        private viewCrearPasajero oViewPasajero;
        private List<Reserva> listaDeReservasEnDataGridView = new List<Reserva>();

        public viewGeneral()
        {
            InitializeComponent();
        }
        private void viewGeneral_Load(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            listaDeReservasEnDataGridView = oDaoReserva.BuscarTodasLasReservas();
            if (listaDeReservasEnDataGridView != null && listaDeReservasEnDataGridView.Any())
            {
                dataGridViewListaDeReservas.DataSource = oDaoReserva.BuscarTodasLasReservas();
            }
            else
            {
                dataGridViewListaDeReservas.DataSource = null;
            }
        }

        private void seleccionDeFilaDataGridViewListaDeReservas(object sender, EventArgs e)
        {
            if (dataGridViewListaDeReservas.SelectedRows.Count > 0)
            {
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
            else
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }
        private void buttonVerDisponibilidad_Click(object sender, EventArgs e)
        {
            filtrarDisponibilidadCapacidadPeriodo ventana = new filtrarDisponibilidadCapacidadPeriodo();
            ventana.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaDeReservas.SelectedRows.Count > 0)
            {
                Reserva reservaSeleccionada = (Reserva)dataGridViewListaDeReservas.SelectedRows[0].DataBoundItem;
                confirmarEliminacionDeReserva ventana = new confirmarEliminacionDeReserva(reservaSeleccionada);
                ventana.ShowDialog();
            }
        }



        public Reserva reservaModidicada { get; private set; }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Reserva reservaSeleccionada = (Reserva)dataGridViewListaDeReservas.SelectedRows[0].DataBoundItem;
            oDaoReserva.modificar(reservaSeleccionada);
            modificarReservaView ventana = new modificarReservaView();
            ventana.ShowDialog();
        }

        private void buttonHabitaciones_Click(object sender, EventArgs e)
        {
            viewHabitacion ventana = new viewHabitacion();
            ventana.ShowDialog();
        }

        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            viewPasajero ventana = new viewPasajero();
            ventana.ShowDialog();
        }
    }
}
