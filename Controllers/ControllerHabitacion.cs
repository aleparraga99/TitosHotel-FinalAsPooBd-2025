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
        private DaoHabitacion oDaoHabitacion = DaoHabitacion.GetDaoHabitacion();

        //SINGLENTON
        private static ControllerHabitacion instanciaDeControllerHabitacion;
        private ControllerHabitacion()
        {
        }
        public static ControllerHabitacion GetInstanciaDeControllerDeHabitacion() {
            if (instanciaDeControllerHabitacion == null) {
                instanciaDeControllerHabitacion = new ControllerHabitacion();
                return instanciaDeControllerHabitacion;
            }
            return instanciaDeControllerHabitacion;
        }

        //METODOS DE COMPORTAMIENTO
        public int calcularCapacidad(int camasSingle, Boolean camaDoble) {
            int capacidadPersonas = camasSingle;
            if (camaDoble)
            {
                capacidadPersonas += 2;
            }
            return capacidadPersonas;
        }
        public List<Habitacion> filtrarPorCapacidad(int capacidadRequerida)

        {
            List<Habitacion> todasLasHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones();
            List<Habitacion> habitacionesFiltradasPorCapacidad = new List<Habitacion>();
            for (int i = 0; i < todasLasHabitaciones.Count; i++)
            {
                Habitacion h = todasLasHabitaciones[i];
                int camasSingleH = h.camasSingle;
                bool camaDobleH = h.camaDoble;
                int capacidad = calcularCapacidad(camasSingleH, camaDobleH);
                if (capacidad == capacidadRequerida)
                {
                    habitacionesFiltradasPorCapacidad.Add(h);
                }
            }
            return habitacionesFiltradasPorCapacidad;
        }
        public List<Habitacion> filtrarHabitacionesPorDisponibilidad (DateTime checkInRequerido, DateTime checkOutRequerido) {
           var habitacionesFiltradasPorDisponibilidad = oDaoHabitacion.filtrarPorDisponibilidad(checkInRequerido, checkOutRequerido);
           return habitacionesFiltradasPorDisponibilidad;
        }
        public List<Habitacion> verDisponibilidad(List<Habitacion> filtrarPorCapacidad, List<Habitacion> filtrarHabitacionesPorDisponibilidad) {
            List<Habitacion> listaDehabitacionesDisponibles = oDaoHabitacion.verDisponibilidadDeHabitacionesDentroDeUnPeriodoYCapacidad(filtrarPorCapacidad, filtrarHabitacionesPorDisponibilidad);
            if (listaDehabitacionesDisponibles == null) {
                return new List<Habitacion>();
            }
            return listaDehabitacionesDisponibles;
        }
       
        //CRUD
        public void crear(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.crear(oHabitacion);
        }
        public void modificar(int id, int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(id, numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.modificar(oHabitacion);
        }
        public void eliminar(int id)
        {
            oDaoHabitacion.eliminar(id);
        }
        public Habitacion encontrarHabitacionPorNumero(int numeroHabitacion) {
            Habitacion habitacion = oDaoHabitacion.buscarHabitacionPorNumero(numeroHabitacion);
            return habitacion;
        }
        public Habitacion buscarPorNumero(int numeroHabitacion) {
            Habitacion habitacionEncontrada = oDaoHabitacion.buscarHabitacionPorNumero(numeroHabitacion);
            return habitacionEncontrada;
        }
        public List<Habitacion> buscarTodasLasHabitaciones()
        {
            List<Habitacion> listaDeHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones();
            return listaDeHabitaciones;
        }
    }
}
