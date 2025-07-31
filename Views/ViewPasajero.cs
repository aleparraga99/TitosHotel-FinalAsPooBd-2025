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
using static System.Net.Mime.MediaTypeNames;

namespace Tito_s_Hotel.Views
{
    public partial class ViewPasajero : Form
    {

        DaoPasajero oDaoPasajero = DaoPasajero.GetDaoPasajero();
        DaoHabitacion oDaoHabitacion = DaoHabitacion.GetDaoHabitacion();
        DaoReserva oDaoReserva = DaoReserva.GetDaoReserva();
        public ViewPasajero()
        {
            InitializeComponent();
        }
        private void ViewPasajero_Load(object sender, EventArgs e)
        {

        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
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

           
            
            Pasajero nuevoPasajero = new Pasajero()
            {
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                telefono = telefono,
                correo = correo,
            };

            oDaoPasajero.crear(nuevoPasajero);

            //Se le envia el numero de habitacion al DAO para que la busque
            Habitacion habitacionEncontrada = oDaoHabitacion.buscarHabitacionPorNumero(numeroDeHabitacion);

            Reserva nuevaReserva = new Reserva()
            {
                checkIn = checkIn,
                checkOut = checkOut,
                oPasajero = nuevoPasajero,
                oHabitacion = habitacionEncontrada,
                adelanto = adelanto,
            };
            oDaoReserva.crear(nuevaReserva);

            this.Close();
        }
    }
}
