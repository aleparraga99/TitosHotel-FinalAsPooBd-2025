using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Tito_s_Hotel.Conexion
{
    public class BDTitosHotel
    {
        public static SqlConnection obtenerConexion()
        { 
            SqlConnection conexion = new SqlConnection("Data source = DESKTOP-TQ8IRKU\\SQLEXPRESS; Initial Catalog = TitosHotel; Integrated security = true");
            conexion.Open();
            return conexion;
        }
    }
}
