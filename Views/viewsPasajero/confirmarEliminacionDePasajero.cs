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
        public confirmarEliminacionDePasajero(Models.Pasajero oPasaejero)
        {
            InitializeComponent();
        }

        private void confirmarEliminacionDePasajero_Load(object sender, EventArgs e)
        {

        }
    }
}
