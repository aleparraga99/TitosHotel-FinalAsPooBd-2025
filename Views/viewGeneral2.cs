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
using Tito_s_Hotel.Views.viewsExcepciones;
using Tito_s_Hotel.Views.viewsReserva;

namespace Tito_s_Hotel.Views
{
    public partial class viewGeneral2 : Form
    {
        ControllerHabitacion oControllerHabitacion = new ControllerHabitacion(); 
        ControllerPasajero oControllerPasajero = new ControllerPasajero();
        public viewGeneral2()
        {
            InitializeComponent();

        }
        private void buttonVerDisponibilidad2_Click(object sender, EventArgs e)
        {
            filtrarDisponibilidadCapacidadPeriodo ventana = new filtrarDisponibilidadCapacidadPeriodo();
            ventana.ShowDialog();
        }
        private void button1NuevaReserva2_Click(object sender, EventArgs e)
        {
            List<Habitacion> habitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();
            List<Models.Pasajero> pasajeros = oControllerPasajero.buscarTodosLosPasajeros();
            if (habitaciones.Count == 0 && pasajeros.Count == 0)
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
        private void buttonAgregarPasajero_Click(object sender, EventArgs e)
        {
            viewCrearPasajero ventana = new viewCrearPasajero();
            ventana.ShowDialog();
        }

        private void buttonAgregarHabitacion_Click_1(object sender, EventArgs e)
        {
            viewCrearHabitacion ventana = new viewCrearHabitacion();
            ventana.ShowDialog();
        }
    }
}
