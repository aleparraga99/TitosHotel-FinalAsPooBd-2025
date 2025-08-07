using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.Controllers;

namespace Tito_s_Hotel.Models
{
    public class Habitacion
    {
        public int id { get; set; }
        public int numero { get; set; }
        public int camasSingle { get; set; }
        public bool camaDoble { get; set; }
        public float precio { get; set; }
        public bool estado { get; set; }

        //Constructores
        public Habitacion()
        {

            this.estado = true;
        }
        public Habitacion(int id)
        {
            this.estado = true;
            this.id = id;
        }
        public Habitacion(int numero, int camasSingle, bool camaDoble, float precio)
        {

            this.numero = numero;
            this.camasSingle = camasSingle;
            this.camaDoble = camaDoble;
            this.precio = precio;
        }
        public Habitacion(int id, int numero, int camasSingle, bool camaDoble, float precio)
        {

            this.numero = numero;
            this.camasSingle = camasSingle;
            this.camaDoble = camaDoble;
            this.precio = precio;
        }

        //ToString
        public override string ToString()
        {
            string auxEstado;
            if (this.estado)
            {
                auxEstado = "Activa";
            }
            else
            {
                auxEstado = "Inactiva";
            }
            return $"[Habitacion número {numero}][Camas single:{camasSingle}][Cama doble:{camaDoble}][Precio:{precio}][Estado:{auxEstado}]";
        }

        //Equals
        public bool Equals(Habitacion oHabitacion)
        {
            if (this == oHabitacion)
            {
                return true;
            }
            if (oHabitacion == null)
            {
                return false;
            }
            if (this.GetType != oHabitacion.GetType)
            {
                return false;
            }
            Habitacion aux = (Habitacion)oHabitacion;

            if (this.numero != aux.numero)
            {
                return false;
            }
            if (this.camasSingle != aux.camasSingle)
            {
                return false;
            }
            if (this.camaDoble != aux.camaDoble)
            {
                return false;
            }
            if (this.precio.Equals(aux.precio) == false)
            {
                return false;
            }
            return true;

        }
    }
}
