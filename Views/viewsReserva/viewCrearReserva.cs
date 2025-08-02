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
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.Views.viewsReserva
{
    public partial class viewCrearReserva : Form
    {
        ControllerReserva oControllerReserva;
        ControllerHabitacion oControllerHabitacion;
        ControllerPasajero oControllerPasajero;
        public viewCrearReserva()
        {
            InitializeComponent();
        }
        private void buttonGuardarReserva_Click(object sender, EventArgs e)
        {
            //Se capturan los datos
            int numeroReserva = int.Parse(textBoxNumeroReserva.Text);
            int numeroHabitacion = int.Parse(textBoxNumeroDeHabitacion.Text);
            int DNI = int.Parse(textBoxDNIDelPasajero.Text);
            float adelanto = float.Parse(textBoxAdelanto.Text);
            DateTime checkIn = dateTimePickerCheckIn.Value;
            DateTime checkOut = dateTimePickerCheckOut.Value;

            Habitacion oHabitacion = oControllerHabitacion.encontrarHabitacionPorNumero(numeroHabitacion);
            Models.Pasajero oPasajero = oControllerPasajero.buscarPorDni(DNI);
           
           oControllerReserva.crear(numeroReserva, checkIn, checkOut, oPasajero, oHabitacion, adelanto);
            
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
