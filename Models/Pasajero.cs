using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tito_s_Hotel.Models
{
    public class Pasajero
    {
        //ATRIBUTOS
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }

        //CONSTRUCTORES
        public Pasajero()
        {
            this.estado = true;
        }
        public Pasajero(int id)
        {
            this.estado = true;
            this.id = id;
        }
        public Pasajero(string nombre, string apellido, string telefono,string dni, string correo)
        {
            this.estado = true;

            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.dni = dni;
            this.correo = correo;
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
            return $"^[{nombre} {apellido}][{dni}][{telefono}][{correo}][{auxEstado}]";
        }

        //Equals
        public bool Equals(Pasajero oPasajero)
        {
            if (this == oPasajero)
            {
                return true;
            }
            if (oPasajero == null)
            {
                return false;
            }
            if (this.GetType != oPasajero.GetType)
            {
                return false;
            }
            Pasajero aux = (Pasajero)oPasajero;

            if (this.nombre != aux.nombre)
            {
                return false;
            }
            if (this.apellido != aux.apellido)
            {
                return false;
            }
            if (this.telefono != aux.telefono)
            {
                return false;
            }
            if (this.dni != aux.dni)
            {
                return false;
            }
            if (this.correo.Equals(aux.correo) == false)
            {
                return false;
            }
            return true;

        }
    }
}



