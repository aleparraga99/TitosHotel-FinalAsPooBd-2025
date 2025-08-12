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
using Tito_s_Hotel.Views.viewsExcepciones;
using Tito_s_Hotel.Views.viewsPasajero;

namespace Tito_s_Hotel.Views.Pasajero
{
    public partial class viewPasajero : Form
    {
        //Se llama a la CONTROLADORA de Pasajero (SINGLENTON)
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();

        //ATRIBUTOS
        private Models.Pasajero pasajeroSeleccionado;
        private bool cargandoFormulario = true; //Cumple la funcion de "Bandera"

        //CONSTRUCTOR
        public viewPasajero()
        {
            InitializeComponent();
        }


        //Se cargan los elementos de la ventana
        private void viewPasajero_Load(object sender, EventArgs e)
        {
            //Se inhabilitan los botones y se configura el dataGrd
            buttonEliminarPasajero.Enabled = false;
            buttonModificarPasajero.Enabled = false;
            dataGridViewListaDePasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaDePasajeros.MultiSelect = false;
            dataGridViewListaDePasajeros.ReadOnly = true;

            //Se trae la lista de todos los pasajeros cargados
            List<Models.Pasajero> listaDePasajeros = oControllerPasajero.buscarTodosLosPasajeros();
            if (listaDePasajeros.Count > 0)
            {
                dataGridViewListaDePasajeros.DataSource = listaDePasajeros;
            }
            else
            {
                dataGridViewListaDePasajeros.DataSource = null;
            }

            dataGridViewListaDePasajeros.SelectionChanged += dataGridViewListaDePasajeros_SelectionChanged;

            cargandoFormulario = false;
        }

        //Se habilitan los botones de ELIMINAR y MODIFICAR cuando se selecciona alguna Pasajero de la lista
        private void dataGridViewListaDePasajeros_SelectionChanged(object sender, EventArgs e)
        {

            if (cargandoFormulario) return;

            if (dataGridViewListaDePasajeros.CurrentRow != null)
            {
                pasajeroSeleccionado = (Models.Pasajero)dataGridViewListaDePasajeros.CurrentRow.DataBoundItem;
                buttonEliminarPasajero.Enabled = true;
                buttonModificarPasajero.Enabled = true;
            }
            else
            {
                pasajeroSeleccionado = null;
                buttonEliminarPasajero.Enabled = false;
                buttonModificarPasajero.Enabled = false;
            }
        }

        //Detecta si hay alguna fila seleccionada y captura el Pasajero seleccionada y habilita los botones ELIMINAR y MODIFICAR si asi es
        private void dataGridViewListaDePasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dataGridViewListaDePasajeros.SelectedRows.Count > 0)
            {
                buttonEliminarPasajero.Enabled = true;
                buttonModificarPasajero.Enabled = true;
            }
            else
            {
                buttonEliminarPasajero.Enabled = false;
                buttonModificarPasajero.Enabled = false;
            }
        }



        // BOTONES //



        //MODIFICAR
        private void buttonModificarPasajero_Click(object sender, EventArgs e)
        {
            if (pasajeroSeleccionado != null)
            { 
              pasajeroSeleccionado = (Models.Pasajero)dataGridViewListaDePasajeros.CurrentRow.DataBoundItem;
                viewModificarPasajero ventana = new viewModificarPasajero(pasajeroSeleccionado);
                ventana.ShowDialog();
            }
        }

        //ELIMINAR
        private void buttonEliminarPasajero_Click(object sender, EventArgs e)
        {
            Models.Pasajero oPasajero = (Models.Pasajero)dataGridViewListaDePasajeros.SelectedRows[0].DataBoundItem;
            confirmarEliminacionDePasajero ventana = new confirmarEliminacionDePasajero(oPasajero);
            ventana.ShowDialog();

        }

        //AGREGAR PASAJERO
        private void buttonAgregarPasajero_Click(object sender, EventArgs e)
        {
            viewCrearPasajero ventana = new viewCrearPasajero();
            ventana.ShowDialog();
        }

        //BUSCAR
        private void buttonBuscarPasajeroPorDni_Click(object sender, EventArgs e)
        {
            try
            {
                int dniBuscado = int.Parse(textBoxDNIPasajero.Text);
                Models.Pasajero pasajeroEncontrado = oControllerPasajero.buscarPorDni(dniBuscado);
                if (pasajeroEncontrado != null)
                {
                    List<Models.Pasajero> listaConPasajeroEncontrado = new List<Models.Pasajero>();
                    dataGridViewListaDePasajeros.DataSource = null;
                    listaConPasajeroEncontrado.Add(pasajeroEncontrado);
                    dataGridViewListaDePasajeros.DataSource = listaConPasajeroEncontrado;
                }
                else
                {
                    viewPasajeroNoEncontrado ventana = new viewPasajeroNoEncontrado();
                    ventana.ShowDialog();
                }
            }
            catch
            {
                excepcionIngresarNumeroDNI ventana = new excepcionIngresarNumeroDNI();
                ventana.ShowDialog();
            }

            dataGridViewListaDePasajeros.SelectionChanged += dataGridViewListaDePasajeros_SelectionChanged;
            cargandoFormulario = false;

        }

        //VOLVER
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //REFRESCAR
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            List<Models.Pasajero> listaDePasajeros = oControllerPasajero.buscarTodosLosPasajeros();
            dataGridViewListaDePasajeros.DataSource = listaDePasajeros;
        }
    }
}
