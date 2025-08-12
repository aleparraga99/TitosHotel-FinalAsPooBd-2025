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
        //Se llaman a las instancias de las CONTROLLERS (SINGLENTON)
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
        ControllerReserva oContollerReserva = ControllerReserva.GetInstanciaControllerReserva();

        //ATRIBUTOS
        private bool cargandoFormulario = true; //Cumple la funcion de "Bandera"
        private List<Reserva> listaDeReservasEnDataGridView = new List<Reserva>();
        private Reserva reservaSeleccionada; 

        //CONSTRUCTOR
        public viewGeneral()
        {
            InitializeComponent();
        }



        //Se cargan los elemenetos al abrirse la ventana
        private void viewGeneral_Load(object sender, EventArgs e)
        {
            //Se inhabilitan los botones y se configura el dataGrid
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            dataGridViewListaDeReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaDeReservas.MultiSelect = false;
            dataGridViewListaDeReservas.ReadOnly = true;

            //Se buscan las Reservas y se cargan a una lista 
            List<Reserva> todasLasReservas = oContollerReserva.buscarTodasLasReservas();

            //Se carga la lista de Reservas al dataGridView
            if (todasLasReservas != null)
            {
                dataGridViewListaDeReservas.DataSource = todasLasReservas;
            }
            else
            {
                dataGridViewListaDeReservas.DataSource = null;
            }

            //Se registra si se selecciona una fila
            dataGridViewListaDeReservas.SelectionChanged += dataGridViewListaDeReservas_SelectionChanged;

            cargandoFormulario = false;
        }

        //Detecta si hay alguna fila seleccionada y captura la Reserva seleccionada y habilita los botones ELIMINAR y MODIFICAR si asi es
        private void dataGridViewListaDeReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            
            if (dataGridViewListaDeReservas.CurrentRow != null)
            {
                reservaSeleccionada = (Reserva)dataGridViewListaDeReservas.CurrentRow.DataBoundItem;
                buttonEliminar.Enabled = true;
                buttonModificar.Enabled = true;
            }
            else
            {
                reservaSeleccionada = null;
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }

        //Se habilitan los botones de ELIMINAR y MODIFICAR cuando se selecciona alguna Reserva de la lista
        private void dataGridViewListaDeReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListaDeReservas.SelectedRows.Count > 0)
            {
                buttonEliminar.Enabled = true;
                buttonModificar.Enabled = true;
            }
            else
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }



        //  BOTONES //



        //HABITACIONES
        private void buttonHabitaciones_Click(object sender, EventArgs e)
        {
            viewHabitacion ventana = new viewHabitacion();
            ventana.ShowDialog();
        }

        //PASAJEROS
        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            viewPasajero ventana = new viewPasajero();
            ventana.ShowDialog();
        }

        //NUEVA RESERVA
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

        //VER DISPONIBILIDAD : Abre la ventana para filtrar Habitaciones
        private void buttonVerDisponibilidad_Click(object sender, EventArgs e)
        {
            filtrarDisponibilidadCapacidadPeriodo ventana = new filtrarDisponibilidadCapacidadPeriodo();
            ventana.ShowDialog();
        }

        //REFRESCAR
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            List<Reserva> todasLasReservas = oContollerReserva.buscarTodasLasReservas();
            dataGridViewListaDeReservas.DataSource = todasLasReservas;
        }

        //ELIMINAR
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (reservaSeleccionada != null)
            {
                confirmarEliminacionDeReserva ventana = new confirmarEliminacionDeReserva(reservaSeleccionada);
                ventana.ShowDialog();
            }
        }

        //MODIFICAR
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (reservaSeleccionada != null) 
            {
                Reserva reservaSeleccionada = (Reserva)dataGridViewListaDeReservas.CurrentRow.DataBoundItem;
                viewModificarReserva ventana = new viewModificarReserva(reservaSeleccionada);
                ventana.ShowDialog();
            }
            
        }
    }
}

