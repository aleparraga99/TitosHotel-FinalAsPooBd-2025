using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tito_s_Hotel.Interfaces
{
    internal interface IDao <T>
    {
        public void crear(T entidad)
        {
        }
        public void modificar(T entidad)
        {
        }
        public void eliminar(T entidad)
        {
        }
        public List<T> buscar()
        {
            return new List<T>();
        }
    }
}
