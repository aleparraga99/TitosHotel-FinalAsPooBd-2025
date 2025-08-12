using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.Conexion;
using Tito_s_Hotel.Interfaces;
using Tito_s_Hotel.Models;
using Tito_s_Hotel.Views.viewsExcepciones;

namespace Tito_s_Hotel.DAOs
{
    internal class DaoReserva : IDao<Reserva>
    {
        //SINGLENTON
        private static DaoReserva instanciaDaoReserva;
        private DaoReserva()
        {
        }
        public static DaoReserva GetDaoReserva()
        {
            if (instanciaDaoReserva == null)
            {
                instanciaDaoReserva = new DaoReserva();
            }
            return instanciaDaoReserva;
        }

        //CRUD
        public void crear(Reserva oReserva)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "INSERT INTO Reserva (NumeroReserva, CheckIn, CheckOut, Adelanto, Id_habitacion, Id_pasajero, Estado) VALUES (@NumeroReserva, @CheckIn, @CheckOut, @Adelanto, @Id_habitacion, @Id_pasajero, 1)";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@NumeroReserva", oReserva.numReserva);
                comando.Parameters.AddWithValue("@CheckIn", oReserva.checkIn);
                comando.Parameters.AddWithValue("@CheckOut", oReserva.checkOut);
                comando.Parameters.AddWithValue("@Adelanto", oReserva.adelanto);
                comando.Parameters.AddWithValue("@Id_habitacion", oReserva.oHabitacion.id);
                comando.Parameters.AddWithValue("@Id_pasajero", oReserva.oPasajero.id);
                comando.ExecuteNonQuery();
            }
        }
        public void modificar(Reserva oReserva)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Reserva SET NumeroReserva  = @NumeroReserva, CheckIn = @CheckIn, CheckOut = @CheckOut, Adelanto = @Adelanto, Id_pasajero = @Id_pasajero, Id_habitacion = @Id_habitacion WHERE Id = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@NumeroReserva", oReserva.numReserva);
                comando.Parameters.AddWithValue("@CheckIn", oReserva.checkIn);
                comando.Parameters.AddWithValue("@CheckOut", oReserva.checkOut);
                comando.Parameters.AddWithValue("@Adelanto", oReserva.adelanto);
                comando.Parameters.AddWithValue("@Id_pasajero", oReserva.oPasajero.id);
                comando.Parameters.AddWithValue("@Id_habitacion", oReserva.oHabitacion.id);
                comando.Parameters.AddWithValue(@"@id", oReserva.id);
                comando.ExecuteNonQuery();
            }
        }
        public void eliminar(int id)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Reserva SET Estado = 0 WHERE Id = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
        }
        public List<Reserva> BuscarTodasLasReservas()
        {
            List<Reserva> listaDeReservas = new List<Reserva>();
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "SELECT * FROM Reserva WHERE Estado = 1";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Reserva reserva = new Reserva
                        {
                            id = lector.GetInt32(0),
                            numReserva = lector.GetInt32(1),
                            checkIn = lector.GetDateTime(2),
                            checkOut = lector.GetDateTime(3),
                            adelanto = lector.GetDouble(4),
                            //oHabitacion = new Habitacion { id = lector.GetInt32(5) },
                            //oPasajero = new Pasajero { id = lector.GetInt32(6) },
                            estado = lector.GetBoolean(7)
                        };
                        listaDeReservas.Add(reserva);
                    }

                }

            return listaDeReservas;
        }
    }
}

