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

namespace Tito_s_Hotel.Views.viewsHabitacion
{

    public partial class confirmacionEliminarHabitacion : Form
    {
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        private Habitacion habitacionParaEliminar;

        public confirmacionEliminarHabitacion(Habitacion oHabitacion)
        {
            InitializeComponent();
            habitacionParaEliminar = oHabitacion;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            oControllerHabitacion.eliminar(habitacionParaEliminar.id);
            this.Close();
        }
    }
}
