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

namespace Tito_s_Hotel.Views.viewsPasajero
{
    public partial class viewModificarPasajero : Form
    {
        //Se llama a la CONTROLADORA de Pasajero
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
        private Models.Pasajero pasajeroParaModificar;
        public viewModificarPasajero(Models.Pasajero pasajeroSeleccionado)
        {
            InitializeComponent();
            pasajeroParaModificar = pasajeroSeleccionado;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            //Se capturan los datos
            string nombre = textBoxStringNombre.Text;
            string apellido = textBoxStringApellido.Text;
            string dni = textBoxStringDni.Text;
            string telefono = textBoxStringTelefono.Text;
            string correo = textBoxStringCorreo.Text;

            //Se construye y crea el objeto Pasajero
            Models.Pasajero oPasajero = new Models.Pasajero()
            {
                id = pasajeroParaModificar.id,
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                telefono = telefono,
                correo = correo,
            };

            oControllerPasajero.modificar(oPasajero);

            viewPasajeroModificado ventana = new viewPasajeroModificado();
            ventana.ShowDialog();

            this.Close();

        }
    }
}
