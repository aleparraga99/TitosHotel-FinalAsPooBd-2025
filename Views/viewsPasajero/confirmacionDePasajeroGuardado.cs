using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tito_s_Hotel.Views.viewsPasajero
{
    public partial class confirmacionDePasajeroGuardado : Form
    {
        public confirmacionDePasajeroGuardado()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
