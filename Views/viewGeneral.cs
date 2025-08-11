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
using Tito_s_Hotel.Views.viewsExcepciones;
using Tito_s_Hotel.Views.viewsReserva;

namespace Tito_s_Hotel
{
    public partial class viewGeneral : Form
    {
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
        ControllerReserva oContollerReserva = ControllerReserva.GetInstanciaControllerReserva();
        private DaoReserva oDaoReserva = DaoReserva.GetDaoReserva();
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
            dataGridViewListaDeReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaDeReservas.MultiSelect = false;
            dataGridViewListaDeReservas.ReadOnly = true;

            List<Reserva> todasLasReservas = oContollerReserva.buscarTodasLasReservas();
            if (todasLasReservas != null)
            {
                dataGridViewListaDeReservas.DataSource = todasLasReservas;
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
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Reserva reservaSeleccionada = (Reserva)dataGridViewListaDeReservas.SelectedRows[0].DataBoundItem;
            oDaoReserva.modificar(reservaSeleccionada);

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
        private void buttonNuevaReserva_Click(object sender, EventArgs e)
        {
            List<Habitacion> habitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();
            List<Models.Pasajero> pasajeros = oControllerPasajero.buscarTodosLosPasajeros();
            if (habitaciones.Count > 0 && pasajeros.Count > 0)
            {
                viewCrearReserva ventana = new viewCrearReserva();
                ventana.ShowDialog();
            }
            else
            {
                excepcionPasajerosHabitacionesNecesarios ventana = new excepcionPasajerosHabitacionesNecesarios();
                ventana.ShowDialog();
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            List<Reserva> todasLasReservas = oContollerReserva.buscarTodasLasReservas();
            dataGridViewListaDeReservas.DataSource = todasLasReservas;
        }
    }
}
