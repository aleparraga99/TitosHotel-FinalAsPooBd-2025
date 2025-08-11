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
using Tito_s_Hotel.Views.viewsPasajero;
using static System.Net.Mime.MediaTypeNames;

namespace Tito_s_Hotel.Views
{
    public partial class viewCrearPasajero : Form
    {
        //Se llama a la CONTROLADORA de Pasajero (SINGLENTON)
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
       
        //CONSTRUCTOR
        public viewCrearPasajero()
        {
            InitializeComponent();
        }



        // BOTONES // 



        // CANCELAR
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //GUARDAR
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Se capturan los datos
            string nombre = textBoxStringNombre.Text;
            string apellido = textBoxStringApellido.Text;
            string dni = textBoxStringDni.Text;
            string telefono = textBoxStringTelefono.Text;
            string correo = textBoxStringCorreo.Text;

            //Se construye y crea el objeto Pasajero
            Models.Pasajero oPasajero = new Models.Pasajero(nombre, apellido, telefono, dni, correo);
            oControllerPasajero.crear(oPasajero.nombre, oPasajero.apellido, oPasajero.telefono, oPasajero.dni, oPasajero.correo);

            //Se abre una ventana para informar que se guardo el pasajero
            confirmacionDePasajeroGuardado ventana = new confirmacionDePasajeroGuardado();
            ventana.ShowDialog();

            this.Close();
        }
    }
}
