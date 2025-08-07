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
    public partial class confirmarEliminacionDePasajero : Form
    {
        ControllerPasajero oControllerPasajero = ControllerPasajero.GetInstanciaDeControllerdePasajero();
        private Models.Pasajero pasajeroParaEliminar;
        public confirmarEliminacionDePasajero(Models.Pasajero oPasaejero)
        {
            InitializeComponent();
            pasajeroParaEliminar = oPasaejero;
        }

        private void confirmarEliminacionDePasajero_Load(object sender, EventArgs e)
        {
            oControllerPasajero.eliminar(pasajeroParaEliminar.id);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
