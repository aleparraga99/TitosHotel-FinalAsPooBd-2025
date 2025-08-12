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
    public partial class viewModificarHabitacion : Form
    {
        //Se llama a la CONTROLADORA de Habitacion (SINGLENTON)
        ControllerHabitacion oControllerHabitacion = ControllerHabitacion.GetInstanciaDeControllerDeHabitacion();
        
        //ATRIBUTOS
        private Habitacion habitacionParaModificar;

        //CONSTRUCTOR
        public viewModificarHabitacion(Habitacion habitacionSeleccionada)
        {
            InitializeComponent();
            habitacionParaModificar = habitacionSeleccionada;
        }



        // BOTONES //



        //CANCELAR
        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //GUARDAR
        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            //Tags que identifican numericamente las opciones de camas single
            radioButtonCamasSingle0.Tag = 0;
            radioButtonCamasSingle1.Tag = 1;
            radioButtonCamasSingle2.Tag = 2;
            radioButtonCamasSingle3.Tag = 3;

            //Tags que identifican numericamente las opciones de cama doble
            radioButtonCamaDoble0.Tag = 0;
            radioButtonCamaDoble1.Tag = 1;

            //Se capturan los datos de los textBoxes
            int numero = int.Parse(textBoxNumero.Text);
            int precioPorNoche = int.Parse(textBoxPrecioPorNoche.Text);

            //Se inicializan estas variables...no encontre la forma para capturarlos correctamente
            int cantidadDeCamasSingle = -1;
            bool camaDoble = false;

            //Se asigna el valor correspondiente a la cantidad de camas single
            foreach (Control control in groupBoxCamasSingle.Controls)
            {
                if (control is RadioButton oRadioButton && oRadioButton.Checked)
                {
                    cantidadDeCamasSingle = Convert.ToInt32(oRadioButton.Tag);
                    break;
                }
            }

            //Se asigna el valor correspondiente con respecto a la cama doble
            foreach (Control control in groupBoxCamaDoble.Controls)
            {
                if (radioButtonCamaDoble0.Checked)
                {
                    camaDoble = false;
                }
                else
                {
                    camaDoble = true;
                }
            }
            Habitacion oHabitacion = new Habitacion()
            {
                id = habitacionParaModificar.id,
                numero = numero,
                camasSingle = cantidadDeCamasSingle,
                camaDoble = camaDoble,
                precio = precioPorNoche
            };

            oControllerHabitacion.modificar(oHabitacion);

            viewCambiosGuardados ventana = new viewCambiosGuardados();
            ventana.ShowDialog();

            this.Close();
        }
    }
}
