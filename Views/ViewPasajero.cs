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
    public partial class ViewPasajero : Form
    {
        public ViewPasajero()
        {
            InitializeComponent();
        }
        private void ViewPasajero_Load(object sender, EventArgs e)
        {

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            labelIntCantidadDeDias.Text = $"{labelIntCantidadDeDias}";
        }
    }
}
