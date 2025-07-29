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
        //SINGLENTON
        private DaoHabitacion oDaoHabitacion;
        public ControllerHabitacion()
        {
            ControllerHabitacion oDaoHabitacion = new ControllerHabitacion();
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
        public List<Habitacion> buscarTodasLasHabitaciones(int numero, int camasSingle, bool camaDoble, float precio)
        {
            Habitacion oHabitacion = new Habitacion(numero, camasSingle, camaDoble, precio);
            List<Habitacion> todasLasHabitaciones = oDaoHabitacion.buscarTodasLashabitaciones();//prestar mas atencion a los argumentos correspondientes de los metodos
            return todasLasHabitaciones;
        }

    }
}
