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
    public partial class viewHabitacion : Form
    {
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

        private void dataGridViewListaDeHabitaciones(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEliminarHabitacion_Click(object sender, EventArgs e)
        {

        }
    }
}
