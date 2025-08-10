﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tito_s_Hotel.Conexion;
using Tito_s_Hotel.Interfaces;
using Tito_s_Hotel.Models;

namespace Tito_s_Hotel.DAOs
{
    public class DaoPasajero : IDao <Pasajero>
    {
        //SINGLENTON
        private static DaoPasajero instanciaDeDaoPasajero;
        private DaoPasajero()
        {

        }
        public static DaoPasajero GetDaoPasajero()

        {
            if (instanciaDeDaoPasajero == null)
            {
                instanciaDeDaoPasajero = new DaoPasajero();
            }
            return instanciaDeDaoPasajero;
        }

        //CRUD
        public void crear(Pasajero oPasajero)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "INSERT INTO Pasajero (Nombre, Apellido, Telefono, DNI, Correo, Estado) VALUES (@Nombre, @Apellido, @Telefono, @DNI, @Correo, 1)";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@Nombre", oPasajero.nombre);
                comando.Parameters.AddWithValue("@Apellido", oPasajero.apellido);
                comando.Parameters.AddWithValue("@Telefono", oPasajero.telefono);
                comando.Parameters.AddWithValue("@Dni", oPasajero.dni);
                comando.Parameters.AddWithValue("@Correo", oPasajero.correo);
                comando.ExecuteNonQuery();
            }
        }
        public void modificar(Pasajero oPasajero)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Pasajero SET Nombre  = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Dni = @DNI, Correo = @Correo WHERE Id_pasajero = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@Nombre", oPasajero.nombre);
                comando.Parameters.AddWithValue("@Apellido", oPasajero.apellido);
                comando.Parameters.AddWithValue("@Telefono", oPasajero.telefono);
                comando.Parameters.AddWithValue("@DNI", oPasajero.dni);
                comando.Parameters.AddWithValue("@Correo", oPasajero.correo);
                comando.Parameters.AddWithValue("@id", oPasajero.id);
                comando.ExecuteNonQuery();
            }
        }
        public void eliminar(int id)
        {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "UPDATE Pasajero SET Estado = 0 WHERE Id_pasajero = @id;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
        }
        public Pasajero buscarPasajeroPorDni(int dniBuscado) {
            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = $"SELECT * FROM Pasajero WHERE Dni = @Dni AND Estado = 1;";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("Dni", dniBuscado);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Pasajero pasajeroEncontrado = new Pasajero {

                            id = reader.GetInt32(reader.GetOrdinal("Id_pasajero")),
                            nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                            telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                            dni = reader.GetInt32(reader.GetOrdinal("Dni")),
                            correo = reader.GetString(reader.GetOrdinal("Correo")),
                            estado = reader.GetBoolean(reader.GetOrdinal("Estado"))
                        };
                        return pasajeroEncontrado;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public List<Pasajero> buscarTodosLosPasajeros()
        { 
            List<Pasajero> listaDePasajeros = new List<Pasajero>();

            using (SqlConnection conexion = BDTitosHotel.obtenerConexion())
            {
                string query = "SELECT * FROM Pasajero WHERE Estado = 1;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                        Pasajero pasajero = new Pasajero
                        {
                            id = lector.GetInt32(0),
                            nombre = lector.GetString(1),
                            apellido = lector.GetString(2),
                            telefono = lector.GetString(3),
                            //dni = lector.GetInt32(4),
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
