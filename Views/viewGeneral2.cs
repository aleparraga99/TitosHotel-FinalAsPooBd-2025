using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tito_s_Hotel.Views
{
    public partial class viewGeneral2 : Form
    {
        public viewGeneral2()
        {
            InitializeComponent();

        }

        private void buttonVerDisponibilidad2_Click(object sender, EventArgs e)
        {
            filtrarDisponibilidadCapacidadPeriodo ventana = new filtrarDisponibilidadCapacidadPeriodo();
            ventana.ShowDialog();
        }

        private void button1NuevaReserva2_Click(object sender, EventArgs e)
        {
            ViewPasajero ventana = new ViewPasajero();
            ventana.ShowDialog();
        }
    }
}
