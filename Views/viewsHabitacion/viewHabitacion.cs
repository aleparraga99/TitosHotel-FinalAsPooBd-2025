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
            Habitacion oHabitacion = new Habitacion();
            oHabitacion = (Habitacion)dataGridViewListaDeHabitaciones.DataSource;
            confirmacionEliminarHabitacion ventana = new confirmacionEliminarHabitacion(oHabitacion);
            ventana.ShowDialog();
        }
        private void buttonModificarHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion oHabitacion = (Habitacion)dataGridViewListaDeHabitaciones.DataSource;
            viewModificarHabitacion ventana = new viewModificarHabitacion(oHabitacion);
            ventana.ShowDialog();
        }
        private void viewHabitacion_Load(object sender, EventArgs e)
        {
            buttonEliminarHabitacion.Enabled = false;
            buttonModificarHabitacion.Enabled = false;

            int listaDeHabitaciones = oControllerHabitacion.buscarTodasLasHabitaciones().Count;
            if (listaDeHabitaciones != 0)
            {
                dataGridViewListaDeHabitaciones.DataSource = oControllerHabitacion.buscarTodasLasHabitaciones();
            }
            else
            {
                dataGridViewListaDeHabitaciones.DataSource = null;
            }

            dataGridViewListaDeHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaDeHabitaciones.MultiSelect = false;
            dataGridViewListaDeHabitaciones.ReadOnly = true;
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroBuscado = int.Parse(textBoxBuscarPorNumero.Text);
                Habitacion habitacionEncontrada = oControllerHabitacion.buscarPorNumero(numeroBuscado);
                if (habitacionEncontrada != null)
                {
                    List<Habitacion> listaConHabitacionEncontrada = new List<Habitacion>();
                    dataGridViewListaDeHabitaciones.DataSource = null;
                    listaConHabitacionEncontrada.Add(habitacionEncontrada);
                    dataGridViewListaDeHabitaciones.DataSource = listaConHabitacionEncontrada;
                }
                else
                {
                    viewHabitacionNoEncontrada ventana = new viewHabitacionNoEncontrada();
                    ventana.ShowDialog();
                }
            }

            catch {
                excepcionIngresarNumeroDeHabitacion ventana = new excepcionIngresarNumeroDeHabitacion();
                ventana.ShowDialog();
            }
            
            
        }
        }
    }

