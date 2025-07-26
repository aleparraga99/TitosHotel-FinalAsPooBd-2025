using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.Controllers
{
    public class ControllerHabitacion
    {
        //Implementación del patrón SINGLENTON
        private DaoHabitacion oDaoHabitacion;
        private DaoReserva oDaoReserva;
        public ControllerHabitacion()
        {
            oDaoHabitacion = new DaoHabitacion();
        }

        List<Habitacion> todasLasHabitaciones = new List<Habitacion>
        todasLasHabitaciones = buscarTodasLasHabitaciones;

        List<Habitacion> todasLasHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones;
        List<Reserva> todasLasReservas = oDaoReserva.BuscarTodasLasReservas;

        //Métodos de comportamiento
        public List<Habitacion> listarHabitacionesConCapacidadRequerida(int capacidadRequerida, List<Habitacion> todasLasHabitaciones)
        {
            List<Habitacion> habitacionesFiltradasPorCapacidad = new List<Habitacion>();
            for (int i = 0; i < todasLasHabitaciones.Count; i++)
            {
                Habitacion h = todasLasHabitaciones[i];
                int capacidad = h.calcularCapacidad();
                if (capacidad == capacidadRequerida)
                {
                    habitacionesFiltradasPorCapacidad.Add(h);
                }
            }
            return habitacionesFiltradasPorCapacidad;
        }
        public List<Habitacion> listarHabitacionesConDisponibilidad(int checkInRequerido, int checkOutRequerido, List<Reserva> todasLasReservas) {
            List<Habitacion> habitacionesFiltradasPorDisponibilidad = new List<Habitacion>();
            for(int i = 0; i < todasLasHabitaciones.Count; i++) {
                for (DateTime i = checkInRequerido + 1; i < checkOutRequerido; i++)
                {
                    Habitacion h = todasLasHabitaciones[i];
                    //Acá necesito un método que me indique la disponibilidad de la habitacion en un fecha dada
                    //  bool disponibilidad = h.consultarDisponibilidad();
                    // if (disponibilidad){
                    // }  
                }
            }
        }
       
        //CRUD
        public void crear(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.crear(oHabitacion);
        }
        public void modificar(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.modificar(oHabitacion);
        }
        public void eliminar(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.eliminar(oHabitacion);
        }
        public List<Habitacion> buscarTodasLasHabitaciones(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            List<Habitacion> todasLasHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones(oHabitacion);
            return todasLasHabitaciones;
        }

    }
}
