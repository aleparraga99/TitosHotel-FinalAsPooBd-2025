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
    public class DaoPasajero : IDao
    {
        //SINGLENTON
        private static DaoPasajero instanciaDaoPasajero;
        private DaoPasajero()
        {

        }
        public static DaoPasajero GetDaoPasajero()

        {
            if (instanciaDaoPasajero == null)
            {
                instanciaDaoPasajero = new DaoPasajero();
            }
            return instanciaDaoPasajero;
        }

        //CRUD
        public void crear(Pasajero oPasajero) {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "INSERT INTO Pasajero (Nombre, Apellido, Telefono, DNI, Correo, Estado) VALUES (@Nombre, @Apellido, @Telefono, @DNI, @Correo, 1)";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@Nombre", oPasajero.nombre);
                comando.Parameters.AddWithValue("@Apellido", oPasajero.apellido);
                comando.Parameters.AddWithValue("@Telefono", oPasajero.telefono);
                comando.Parameters.AddWithValue("@DNI", oPasajero.dni);
                comando.Parameters.AddWithValue("@Correo", oPasajero.correo);
                comando.ExecuteNonQuery();
            }
        }
        public void modificar(Pasajero oPasajero) {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Pasajero SET Nombre  = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Dni = @DNI, Correo = @Correo WHERE Id_pasajero = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@Nombre", oPasajero.nombre);
                comando.Parameters.AddWithValue("@Apellido", oPasajero.apellido);
                comando.Parameters.AddWithValue("@Telefono", oPasajero.telefono);
                comando.Parameters.AddWithValue("@DNI", oPasajero.dni);
                comando.Parameters.AddWithValue("@Correo", oPasajero.correo);
                comando.Parameters.AddWithValue("@id", oPasajero.id);
                comando.ExecuteNonQuery();
            }

        }
        public void eliminar(Pasajero oPasajero) {

            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Pasajero SET Estado = 0 WHERE Id_pasajero = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                comando.Parameters.AddWithValue("@id", oPasajero.id);
                comando.ExecuteNonQuery();
            }
        }
        public List<Pasajero> buscarTodosLosPasajeros() {

            List<Pasajero> listaDePasajeros = new List<Pasajero>();
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "SELECT * FROM Pasajero WHERE Estado = 1";
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pasajero pasajero = new Pasajero
                    {
                        id = lector.GetInt32(0),
                        nombre = lector.GetString(1),
                        apellido = lector.GetString(2),
                        telefono = lector.GetInt32(3),
                        dni = lector.GetInt32(4),
                        correo = lector.GetString(5),
                        estado = lector.GetBoolean(6)
                    };
                    listaDePasajeros.Add(pasajero);
                }
            }
            return listaDePasajeros;
        }
    }
}
