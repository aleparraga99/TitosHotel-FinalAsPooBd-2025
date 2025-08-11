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
        private DaoPasajero oDaoPasajero = DaoPasajero.GetDaoPasajero();

        //SINGLENTON
        private static ControllerPasajero instanciaDeControllerPasajero;
        private ControllerPasajero()
        {
        }
        public static ControllerPasajero GetInstanciaDeControllerdePasajero() {
            if (instanciaDeControllerPasajero == null)
            {
                instanciaDeControllerPasajero = new ControllerPasajero();
            }
            return instanciaDeControllerPasajero;
        }

        //CRUD
        public void crear(string nombre, string apellido, string telefono, string dni, string correo)
        {
            Pasajero oPasajero = new Pasajero(nombre, apellido, telefono, dni, correo);
            oDaoPasajero.crear(oPasajero);
        }
        public void modificar(string nombre, string apellido, string telefono,string dni, string correo)
        {
            Pasajero oPasajero = new Pasajero(nombre, apellido, telefono, dni, correo);
            oDaoPasajero.modificar(oPasajero);
        }
        public void eliminar(int id)
        {
            oDaoPasajero.eliminar(id);
        }
        public Pasajero buscarPorDni(int dniBuscado) {
            Pasajero pasajero = oDaoPasajero.buscarPasajeroPorDni(dniBuscado);
            return pasajero;
        }
      
        public List<Pasajero> buscarTodosLosPasajeros()
        {
            List<Pasajero> listaDePasajeros = oDaoPasajero.buscarTodosLosPasajeros();
            return listaDePasajeros;
        }
    }
}
