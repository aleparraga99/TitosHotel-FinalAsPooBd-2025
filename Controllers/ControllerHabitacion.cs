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
        private DaoHabitacion oDaoHabitacion;
        public ControllerHabitacion()
        {
            oDaoHabitacion = new DaoHabitacion();
        }

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
        public void buscarTodasLashabitaciones(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            oDaoHabitacion.buscarTodasLashabitaciones(oHabitacion);
        }

    }
}
