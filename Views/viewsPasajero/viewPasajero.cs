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
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
        private Models.Pasajero pasajeroSeleccionado = null;
        private bool cargandoFormulario = true;
        public viewPasajero()
        {
            InitializeComponent();
        }
        private void buttonModificarPasajero_Click(object sender, EventArgs e)
        {


            //Capturar datos del dataGrid. Supongo que se tiene que mostrar la ventana para cargar los datos
            //oControllerPasajero.modificar();
        }
        private void buttonEliminarPasajero_Click(object sender, EventArgs e)
        {
            Models.Pasajero oPasajero = (Models.Pasajero)dataGridViewListaDePasajeros.SelectedRows[0].DataBoundItem;
            confirmarEliminacionDePasajero ventana = new confirmarEliminacionDePasajero(oPasajero);
            ventana.ShowDialog();

        }
        private void buttonAgregarPasajero_Click(object sender, EventArgs e)
        {
            viewCrearPasajero ventana = new viewCrearPasajero();
            ventana.ShowDialog();
        }
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
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

            cargandoFormulario = false;
        }
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

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            List<Models.Pasajero> listaDePasajeros = oControllerPasajero.buscarTodosLosPasajeros();
            dataGridViewListaDePasajeros.DataSource = listaDePasajeros;
        }
    }
}
