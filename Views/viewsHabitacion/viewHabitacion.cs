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
        //Se llama a la CONTROLADORA de Habitacion (SINGLENTON)
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
       
        //ATRIBUTOS
        private Habitacion habitacionSeleccionada = null;
        private bool cargandoFormulario = true; //Cumple la funcion de "Bandera"
       
        //CONSTRUCTOR
        public viewHabitacion()
        {
            InitializeComponent();
        }

        //Se cargan los elementos de la ventana
        private void viewHabitacion_Load(object sender, EventArgs e)
        {
            //Se inhabilitan los botones y se configura el dataGrid
            buttonEliminarHabitacion.Enabled = false;
            buttonModificarHabitacion.Enabled = false;
            dataGridViewListaDeHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaDeHabitaciones.MultiSelect = false;
            dataGridViewListaDeHabitaciones.ReadOnly = true;

            //Se obtienen las habitaciones
            List<Habitacion> listaDeHabitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();

            //Se cargan las habitaciones al dataGrid
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
        
        //Se habilitan los botones de ELIMINAR y MODIFICAR cuando se selecciona alguna Habitacion de la lista
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

        //Detecta si hay alguna fila seleccionada y captura la Habitacion seleccionada y habilita los botones ELIMINAR y MODIFICAR si asi es
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




        // BOTONES //



        //VOLVER
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //AGREGAR HABITACION
        private void buttonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            viewCrearHabitacion ventana = new viewCrearHabitacion();
            ventana.ShowDialog();
        }

        //ELIMINAR
        private void buttonEliminarHabitacion_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada != null)
            {
                confirmacionEliminarHabitacion ventana = new confirmacionEliminarHabitacion(habitacionSeleccionada);
                ventana.ShowDialog();
            }
        }

        //Boton MODIFICAR
        private void buttonModificarHabitacion_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada != null)
            {
                viewModificarHabitacion ventana = new viewModificarHabitacion(habitacionSeleccionada);
                ventana.ShowDialog();
            }
        }

        //Boton BUSCAR
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

        //REFRESCAR
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            List<Habitacion> listaDeHabitaciones = oControllerHabitacion.buscarTodasLasHabitaciones();
            dataGridViewListaDeHabitaciones.DataSource = listaDeHabitaciones;
        }
    }
}

