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
using Tito_s_Hotel.Views.viewsHabitacion;

namespace Tito_s_Hotel
{
    public partial class filtrarDisponibilidadCapacidadPeriodo : Form
    {
        //Se llaman a las CONTROLADORAS de Reserva y Habitacion (SINGLENTON)
        private ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        private ControllerReserva oControllerReserva = ControllerReserva.GetInstanciaControllerReserva();

        //CONSTRUCTOR
        public filtrarDisponibilidadCapacidadPeriodo()
        {
            InitializeComponent();
        }



        // BOTONES // 


        //BUSCAR
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Se generan las listas de Reservas y Habitaciones
            List<Habitacion> habitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();
            List<Reserva> reservas = oControllerReserva.buscarTodasLasReservas();

            int capacidadRequerida = int.Parse(textBoxCapacidad.Text); //Se captura la capacidad requerida

            if (0 < capacidadRequerida && capacidadRequerida <= 5) //Valida que sea una capacidad permitida en el modelo de negocio (violacion del OCP)
            {
                List<Habitacion> habitacionesConCapacidadRequerida = oControllerHabitacion.filtrarPorCapacidad(capacidadRequerida);
                if (reservas.Count == 0)
                {
                    dataGridViewListaDeHabitacionesDisponibles.DataSource = habitacionesConCapacidadRequerida;
                }
                else
                {

                    //Se capturan las fechas
                    DateTime chekInRequerido = dateTimePickerIn.Value;
                    DateTime checkOutRequerido = dateTimePickerOut.Value;

                    //Se filtran las habitaciones solicitadas y se muestran en el dataGridView
                    List<Habitacion> lista1 = oControllerHabitacion.filtrarPorCapacidad(capacidadRequerida);
                    List<Habitacion> lista2 = oControllerHabitacion.filtrarHabitacionesPorDisponibilidad(chekInRequerido, checkOutRequerido);
                    List<Habitacion> listaDeDisponibilidad = (List<Habitacion>)oControllerHabitacion.verDisponibilidad(lista1, lista2);
                    dataGridViewListaDeHabitacionesDisponibles.DataSource = listaDeDisponibilidad;
                }
            }

            else
            {
                viewCapacidadNoValida ventana = new viewCapacidadNoValida();
                ventana.ShowDialog();
            }
        }

        //VOLVER
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
