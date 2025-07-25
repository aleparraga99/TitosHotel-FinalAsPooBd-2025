using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.Conexion;
using Tito_s_Hotel.Interfaces;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.DAOs
{
    internal class DaoHabitacion : IDao
    {
        //Singlenton

        private static DaoHabitacion instanciaDaoHabitacion;

        private DaoHabitacion()
        {
        }
        public static DaoHabitacion GetDaoHabitacion()
        {
            if (instanciaDaoHabitacion == null)
            {
                instanciaDaoHabitacion = new DaoHabitacion();
            }
            return instanciaDaoHabitacion;
        }
        public void crear(Habitacion oHabitacion)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "INSERT INTO Habitacion (Numero, CamasSingle, CamaDoble, Precio, Estado) VALUES (@Numero, @CamasSingle, @CamaDoble, @Precio, 1)";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@Numero", oHabitacion.numero);
                comando.Parameters.AddWithValue("@CamasSingle", oHabitacion.camasSingle);
                comando.Parameters.AddWithValue("@CamaDoble", oHabitacion.camaDoble);
                comando.Parameters.AddWithValue("@Precio", oHabitacion.precio);
                comando.ExecuteNonQuery();
            }

        }
        public void modificar(Habitacion oHabitacion)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Habitacion SET numero  = @numero, camasSingle = @camasSingle, camaDoble = @camaDoble, precio = @precio WHERE Id_habitacion = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@numero", oHabitacion.numero);
                comando.Parameters.AddWithValue("@camasSingle", oHabitacion.camasSingle);
                comando.Parameters.AddWithValue("@camaDoble", oHabitacion.camaDoble);
                comando.Parameters.AddWithValue("@precio", oHabitacion.precio);
                comando.Parameters.AddWithValue("@id", oHabitacion.id);
                comando.ExecuteNonQuery();
            }
        }
        public void eliminar(Habitacion oHabitacion)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Habitacion SET Estado = 0 WHERE Id_habitacion = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@id", oHabitacion.id);
                comando.ExecuteNonQuery();
            }
        }
        public List<Habitacion> buscarTodasLashabitaciones()
        {
            List<Habitacion> listaDeHabitaciones = new List<Habitacion>();
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "SELECT * FROM Habitacion WHERE Estado = 1";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Habitacion habitacion = new Habitacion
                    {
                        id = lector.GetInt32(0),
                        numero = lector.GetInt32(1),
                        camasSingle = lector.GetInt32(2),
                        camaDoble = lector.GetBoolean(3),
                        precio = lector.GetFloat(4),
                        estado = lector.GetBoolean(5)
                    };
                    listaDeHabitaciones.Add(habitacion);
                }
            }
            return listaDeHabitaciones;
        }
    }
}
