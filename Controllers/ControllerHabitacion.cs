using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;
using Tito_s_Hotel.Views;

namespace Tito_s_Hotel.Controllers
{
    public class ControllerHabitacion
    {
        private viewCrearHabitacion oViewCrearHabitacion;
        //SINGLENTON
        private DaoHabitacion oDaoHabitacion;
        public ControllerHabitacion()
        {
            ControllerHabitacion oDaoHabitacion = new ControllerHabitacion();
        }

        //Metodos de comportamiento
        public List<Habitacion> filtrarPorCapacidad(int capacidadRequerida)

        {
            List<Habitacion> todasLasHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones();
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
        public List<Habitacion> filtrarHabitacionesPorDisponibilidad (DateTime checkInRequerido, DateTime checkOutRequerido) {
           var listaHabitacionesFiltradasPorDisponibilidad = oDaoHabitacion.filtrarPorDisponibilidad(checkInRequerido, checkOutRequerido);
           return listaHabitacionesFiltradasPorDisponibilidad;
        }
        public List<Habitacion> verDisponibilidad(List<Habitacion> filtrarPorCapacidad, List<Habitacion> filtrarHabitacionesPorDisponibilidad) {
            var listaDehabitacionesDisponibles = oDaoHabitacion.verDisponibilidadDeHabitacionesDentroDeUnPeriodoYCapacidad(filtrarPorCapacidad, filtrarHabitacionesPorDisponibilidad);
            return listaDehabitacionesDisponibles;
        }
       
        //CRUD
        public void crear(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.crear(oHabitacion);
            // se tuvo que crear un nuevo constructor que no reciba id. 
            //seguramente se tendrá que hacer lo mismo para el resto de modelos
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
        public Habitacion encontrarHabitacionPorNumero(int numero) {
            Habitacion habitacion = oDaoHabitacion.buscarHabitacionPorNumero(numero);
            return habitacion;
        }
        public List<Habitacion> buscarTodasLasHabitaciones()
        {
            List<Habitacion> listaDeHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones();
            return listaDeHabitaciones;
        }

    }
}
