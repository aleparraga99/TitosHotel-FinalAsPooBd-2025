using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.Views
{
    public partial class modificarReservaView : Form
    {
        DaoReserva oDaoReserva = DaoReserva.GetDaoReserva();
        public modificarReservaView()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {

            string nombre = textBoxStringNombre.Text;
            string apellido = textBoxStringApellido.Text;
            int dni = int.Parse(textBoxIntDni.Text);
            int telefono = int.Parse(textBoxIntTelefono.Text);
            string correo = textBoxStringCorreo.Text;

            int numeroDeHabitacion = int.Parse(textBoxHabitacion.Text);
            DateTime checkIn = dateTimePickerChekIn.Value;
            DateTime checkOut = dateTimePickerCheckOut.Value;
            int adelanto = int.Parse(textBoxIntAdelanto.Text);

            private Reserva reservaModificada() { 
                
        }
            
    }
}
