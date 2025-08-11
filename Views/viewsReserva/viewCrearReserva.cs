﻿using System;
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
using Tito_s_Hotel.Views.viewsHabitacion;
using Tito_s_Hotel.Views.viewsPasajero;

namespace Tito_s_Hotel.Views.viewsReserva
{
    public partial class viewCrearReserva : Form
    {
        ControllerReserva oControllerReserva = ControllerReserva.GetInstanciaControllerReserva();
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
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
            if (string.IsNullOrEmpty(textBoxNumeroReserva.Text) || string.IsNullOrEmpty(textBoxNumeroDeHabitacion.Text) || string.IsNullOrEmpty(textBoxDNIDelPasajero.Text) || string.IsNullOrEmpty(textBoxAdelanto.Text)){
                viewCompletarCampos ventanaCampos = new viewCompletarCampos();
                ventanaCampos.ShowDialog();
            }

            Habitacion oHabitacion = (Habitacion)oControllerHabitacion.encontrarHabitacionPorNumero(numeroHabitacion);
            Models.Pasajero oPasajero = (Models.Pasajero)oControllerPasajero.buscarPorDni(DNI);

            oControllerReserva.crear(numeroReserva, checkIn, checkOut, oPasajero, oHabitacion, adelanto);

            confirmacionDeReservaGuardadaView ventana = new confirmacionDeReservaGuardadaView();
            ventana.ShowDialog();

            this.Close();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
