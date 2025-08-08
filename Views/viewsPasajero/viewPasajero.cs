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
        private Models.Pasajero oPasajero;
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


        }
        private void viewPasajero_Load(object sender, EventArgs e)
        {
            buttonEliminarPasajero.Enabled = false;
            buttonModificarPasajero.Enabled = false;
            int listaDePasajeros = oControllerPasajero.buscarTodosLosPasajeros().Count;
            if (listaDePasajeros != 0)
            {
                dataGridViewListaDePasajeros.DataSource = oControllerPasajero.buscarTodosLosPasajeros();
            }
            else
            {
                dataGridViewListaDePasajeros.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
