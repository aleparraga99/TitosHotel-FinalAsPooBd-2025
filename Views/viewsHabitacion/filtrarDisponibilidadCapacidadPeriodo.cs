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

namespace Tito_s_Hotel
{
    public partial class filtrarDisponibilidadCapacidadPeriodo : Form
    {
        private DaoHabitacion oDaoHabitacion;
        private ControllerHabitacion oControllerHabitacion;
        public filtrarDisponibilidadCapacidadPeriodo()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e) //En teoria a esto lo puedo encapsular a nivel de metodo
        {
            try
            {
                List<Habitacion> habitaciones = oDaoHabitacion.buscarTodasLashabitaciones();

                int capacidadRequerida;
                if (!int.TryParse(textBox1.Text, out capacidadRequerida)) //Captura la capacidad
                {
                    if (0 >= capacidadRequerida || capacidadRequerida > 5) //Valida que sea una capacidad permitida en el modelo de negocio (violacion del OCP)
                    {
                        MessageBox.Show("Capacidad inválida. Ingresá un número.");
                        return;
                    }
                }

                //Se capturan las fechas
                DateTime chekInRequerido = dateTimePicker1.Value;
                DateTime checkOutRequerido = dateTimePicker2.Value;


                //Se filtran las habitaciones solicitadas y se muestran el el dataGridView
                oControllerHabitacion.filtrarPorCapacidad(capacidadRequerida);
                oControllerHabitacion.filtrarHabitacionesPorDisponibilidad(chekInRequerido, checkOutRequerido);
                dataGridViewListaDeHabitacionesDisponibles.DataSource = oControllerHabitacion.verDisponibilidad;
            }
            catch (Exception ex)
            {
                excepcionNoHayHabitaciones ventana = new excepcionNoHayHabitaciones();
                ventana.Show();
            } 
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
