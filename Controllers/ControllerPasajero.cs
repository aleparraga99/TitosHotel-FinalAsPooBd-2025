using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.Controllers
{
    public class ControllerPasajero
    {
        private DaoPasajero oDaoPasajero;
        public ControllerPasajero()
        {
            oDaoPasajero = new DaoPasajero;
        }

        public void crear(string nombre, string apellido, int telefono, int dni, string correo)
        {
            Pasajero oPasajero = new Pasajero (nombre, apellido, telefono, dni, correo);
            oDaoPasajero.crear(oPasajero);
        }
        public void modificar(string nombre, string apellido, int telefono, int dni, string correo)
        {
            Pasajero oPasajero = new Pasajero(nombre, apellido, telefono, dni, correo);
            oDaoPasajero.modificar(oPasajero);
        }
        public void eliminar(string nombre, string apellido, int telefono, int dni, string correo)
        {
            Pasajero oPasajero = new Pasajero(nombre, apellido, telefono, dni, correo);
            oDaoPasajero.eliminar(oPasajero);
        }
        public void buscarTodasLosPasajeros(string nombre, string apellido, int telefono, int dni, string correo)
        {
            Pasajero oPasajero = new Pasajero(nombre, apellido, telefono, dni, correo);
            oDaoPasajero.buscarTodosLosPasajeros(oPasajero);
        }

    }
}
