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
using Tito_s_Hotel.Views.viewsExcepciones;
using Tito_s_Hotel.Views.viewsHabitacion;

namespace Tito_s_Hotel.Views
{
    public partial class viewHabitacion : Form
    {
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        private Habitacion habitacionSeleccionada = null;
        private bool cargandoFormulario = true;
        public viewHabitacion()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            viewCrearHabitacion ventana = new viewCrearHabitacion();
            ventana.ShowDialog();
        }
        private void buttonEliminarHabitacion_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada != null)
            {
                confirmacionEliminarHabitacion ventana = new confirmacionEliminarHabitacion(habitacionSeleccionada);
                ventana.ShowDialog();
            }
        }
        private void buttonModificarHabitacion_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada != null)
            {
                viewModificarHabitacion ventana = new viewModificarHabitacion(habitacionSeleccionada);
                ventana.ShowDialog();
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroHabitacion = int.Parse(textBoxBuscarPorNumero.Text);
                Habitacion habitacionEncontrada = (Habitacion)oControllerHabitacion.buscarPorNumero(numeroHabitacion);
                if (habitacionEncontrada != null)
                {
                    List<Habitacion> listaConHabitacionEncontrada = new List<Habitacion>();
                    listaConHabitacionEncontrada.Add(habitacionEncontrada);
                    dataGridViewListaDeHabitaciones.DataSource = null;
                    dataGridViewListaDeHabitaciones.DataSource = listaConHabitacionEncontrada;
                }
                else
                {
                    viewHabitacionNoEncontrada ventana = new viewHabitacionNoEncontrada();
                    ventana.ShowDialog();
                }
            }
            catch
            {
                excepcionIngresarNumeroDeHabitacion ventana = new excepcionIngresarNumeroDeHabitacion();
                ventana.ShowDialog();
            }



        }
        private void viewHabitacion_Load(object sender, EventArgs e)
        {
            //Se inhabilitan los botones y se configura el dataGrid
            buttonEliminarHabitacion.Enabled = false;
            buttonModificarHabitacion.Enabled = false;
            dataGridViewListaDeHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaDeHabitaciones.MultiSelect = false;
            dataGridViewListaDeHabitaciones.ReadOnly = true;

            //Se obtienen las habitaciones y se cargan al dataGrid
            List<Habitacion> listaDeHabitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();
            if (listaDeHabitaciones.Count > 0)
            {
                dataGridViewListaDeHabitaciones.DataSource = listaDeHabitaciones;
            }
            else
            {
                dataGridViewListaDeHabitaciones.DataSource = null;
            }

            dataGridViewListaDeHabitaciones.SelectionChanged += dataGridViewListaDeHabitaciones_SelectionChanged;

            cargandoFormulario = false;
        }
        private void dataGridViewListaDeHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListaDeHabitaciones.SelectedRows.Count > 0)
            {
                buttonEliminarHabitacion.Enabled = true;
                buttonModificarHabitacion.Enabled = true;
            }
            else
            {
                buttonEliminarHabitacion.Enabled = false;
                buttonModificarHabitacion.Enabled = false;
            }
        }
        private void dataGridViewListaDeHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
                if (cargandoFormulario) return;

                if (dataGridViewListaDeHabitaciones.CurrentRow != null)
                {
                    habitacionSeleccionada = (Habitacion)dataGridViewListaDeHabitaciones.CurrentRow.DataBoundItem;
                    buttonEliminarHabitacion.Enabled = true;
                    buttonModificarHabitacion.Enabled = true;
                }
                else
                {
                    habitacionSeleccionada = null;
                    buttonEliminarHabitacion.Enabled = false;
                    buttonModificarHabitacion.Enabled = false;
                }
        }
       
    }
}

