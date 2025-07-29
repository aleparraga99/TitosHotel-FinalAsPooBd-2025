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
        private DaoReserva oDaoReserva;
        public ControllerReserva()
        {
            this.oDaoReserva = new DaoReserva();
        }

        public void crear(int numReserva, DateTime checkIn, DateTime checkOut, float adelanto, Habitacion oHabitacion, Pasajero oPasajero)
        {
            Reserva oReserva = new Reserva(numReserva, checkIn, checkOut, adelanto, oHabitacion, oPasajero);
            oDaoReserva.crear(oReserva);
        }
        public void modificar(int numReserva, DateTime checkIn, DateTime checkOut, float adelanto, Habitacion oHabitacion, Pasajero oPasajero)
        {
            Reserva oReserva = new Reserva(numReserva, checkIn, checkOut, adelanto, oHabitacion, oPasajero);
            oDaoReserva.modificar(oReserva);
        }
        public void eliminar(int numReserva, DateTime checkIn, DateTime checkOut, float adelanto, Habitacion oHabitacion, Pasajero oPasajero)
        {
            Reserva oReserva = new Reserva(numReserva, checkIn, checkOut, adelanto, oHabitacion, oPasajero);
            oDaoReserva.eliminar(oReserva);
        }
        public void buscarTodasLasReservas(int numReserva, DateTime checkIn, DateTime checkOut, float adelanto, Habitacion oHabitacion, Pasajero oPasajero)
        {
            Reserva oReserva = new Reserva(numReserva, checkIn, checkOut, adelanto, oHabitacion, oPasajero);
            oDaoReserva.BuscarTodasLasReservas(oReserva);
        }

    }
}
