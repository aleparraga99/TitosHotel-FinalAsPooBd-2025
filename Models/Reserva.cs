using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tito_s_Hotel.Models
{
    public class Reserva
    {
        public int id { get; set; }
        public int numReserva { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public Pasajero oPasajero { get; set; }
        public Habitacion oHabitacion { get; set; }
        public float adelanto { get; set; }
        public bool estado { get; set; }

        //Constructores
        public Reserva()
        {
            this.estado = true;
        }

        public Reserva(int numReserva)
        {
            this.estado = true;

            this.numReserva = numReserva;
        }
        public Reserva(int numReserva, DateTime checkIn)
        {
            this.estado = true;

            this.numReserva = numReserva;
            this.checkIn = checkIn;
        }
        public Reserva(int numReserva, DateTime checkIn, DateTime checkOut)
        {
            this.estado = true;

            this.numReserva = numReserva;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }
        public Reserva(int numReserva, DateTime checkIn, DateTime checkOut, Pasajero oPasajero)
        {
            this.estado = true;

            this.numReserva = numReserva;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.oPasajero = oPasajero;
        }
        public Reserva(int numReserva, DateTime checkIn, DateTime checkOut, Pasajero oPasajero, Habitacion oHabitacion)
        {
            this.estado = true;

            this.numReserva = numReserva;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.oPasajero = oPasajero;
            this.oHabitacion = oHabitacion;
        }
        public Reserva(int numReserva, DateTime checkIn, DateTime checkOut, Pasajero oPasajero, Habitacion oHabitacion, float adelanto)
        {
            this.estado = true;

            this.numReserva = numReserva;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.oPasajero = oPasajero;
            this.oHabitacion = oHabitacion;
            this.adelanto = adelanto;
        }



        //ToString
        public string ToString(Pasajero oPasajero, Habitacion oHabitacion)
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
            return $"[Reserva numero {numReserva}][Check In: {checkIn}][Check Out: {checkOut}][Pasajero:{oPasajero.ToString}][Habitacion:{oHabitacion.ToString}][Adelanto:{adelanto}][Estado: {auxEstado}]";
        }

        //Equals
        public bool equals(Reserva oReserva)
        {
            if (this == oReserva)
            {
                return true;
            }
            if (this == null)
            {
                return false;
            }
            if (this.GetType != oReserva.GetType)
            {
                return false;
            }

            Reserva aux = (Reserva)oReserva;

            if (this.numReserva != aux.numReserva)
            {
                return false;
            }
            if (this.checkIn != aux.checkIn)
            {
                return false;
            }
            if (this.checkOut != aux.checkOut)
            {
                return false;
            }
            if (this.oPasajero != aux.oPasajero)
            {
                return false;
            }
            if (this.oHabitacion != aux.oHabitacion)
            {
                return false;
            }
            if (this.adelanto.Equals(aux.adelanto) == false)
            {
                return false;
            }
            return true;
        }
    }
}
