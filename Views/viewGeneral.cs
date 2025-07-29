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

namespace Tito_s_Hotel
{
    public partial class viewGeneral : Form
    {
        private DaoReserva oDaoReserva;

        public viewGeneral()
        {
            InitializeComponent();
        }
        private void viewGeneral_Load(object sender, EventArgs e)
        {
            dataGridViewListaDeReservas.DataSource = oDaoReserva.BuscarTodasLasReservas();
        }

        private void buttonVerDisponibilidad_Click(object sender, EventArgs e)
        {
            filtrarDisponibilidadCapacidadPeriodo ventana = new filtrarDisponibilidadCapacidadPeriodo();
            ventana.ShowDialog();
        }
    }
}
