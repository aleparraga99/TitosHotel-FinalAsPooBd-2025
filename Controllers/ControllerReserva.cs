using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.Controllers
{
    public class ControllerReserva
    {
        //Se llama al DAO de Reserva (SINGLENTON)
        private DaoReserva oDaoReserva = DaoReserva.GetDaoReserva();

        //SINGLENTON
        private static ControllerReserva instanciaControllerReserva;
        private ControllerReserva() { 
        }
        public static ControllerReserva GetInstanciaControllerReserva() {
            if (instanciaControllerReserva == null) {
                instanciaControllerReserva = new ControllerReserva();
                return instanciaControllerReserva;
            }
            return instanciaControllerReserva;
        }

        //METODOS DE COMPORTAMIENTO
        public int CalcularDiasTotales(DateTime checkIn, DateTime checkOut)
        {
            TimeSpan diferencia = checkOut - checkIn;
            int cantidadDeDias = diferencia.Days;
            return cantidadDeDias;
        }

        //CRUD
        public void crear(int numReserva, DateTime checkIn, DateTime checkOut, Pasajero oPasajero, Habitacion oHabitacion, double adelanto)
        {
            Reserva oReserva = new Reserva(numReserva, checkIn, checkOut, oPasajero, oHabitacion, adelanto);
            oDaoReserva.crear(oReserva);
        }
        public void modificar(Reserva oReserva)
        { 
            oDaoReserva.modificar(oReserva);
        }
        public void eliminar(int id)
        {
            oDaoReserva.eliminar(id);
        }
        public List<Reserva> buscarTodasLasReservas()
        {
            List<Reserva> todasLasReservas = oDaoReserva.BuscarTodasLasReservas();
            return todasLasReservas;
        }
    }
}
