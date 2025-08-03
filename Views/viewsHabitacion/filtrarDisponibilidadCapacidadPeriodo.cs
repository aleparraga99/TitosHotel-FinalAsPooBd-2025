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
        private ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        public filtrarDisponibilidadCapacidadPeriodo()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e) 
        {
            List<Habitacion> habitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();

            int capacidadRequerida = int.Parse(textBoxCapacidad.Text); //Se captura la capacidad requerida

            if (0 < capacidadRequerida && capacidadRequerida <= 5) //Valida que sea una capacidad permitida en el modelo de negocio (violacion del OCP)
            {
                //Se capturan las fechas
                DateTime chekInRequerido = dateTimePickerIn.Value;
                DateTime checkOutRequerido = dateTimePickerOut.Value;

                //Se filtran las habitaciones solicitadas y se muestran el el dataGridView
               List<Habitacion> lista1 = oControllerHabitacion.filtrarPorCapacidad(capacidadRequerida);
               List<Habitacion> lista2 = oControllerHabitacion.filtrarHabitacionesPorDisponibilidad(chekInRequerido, checkOutRequerido);
                dataGridViewListaDeHabitacionesDisponibles.DataSource = oControllerHabitacion.verDisponibilidad(lista1, lista2);
            }

            else
            {
                viewCapacidadNoValida ventana = new viewCapacidadNoValida();
                ventana.ShowDialog();
            }
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
