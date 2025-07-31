using System.Drawing.Text;
using Tito_s_Hotel.DAOs;
using Tito_s_Hotel.Models;
using Tito_s_Hotel.Views;

namespace Tito_s_Hotel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DaoReserva oDaoReserva = DaoReserva.GetDaoReserva();
            List<Reserva> oReservas = oDaoReserva.BuscarTodasLasReservas();
            ApplicationConfiguration.Initialize();
            if (oReservas.Count > 0)
            {
                Application.Run(new viewGeneral());
            }
            else {
                Application.Run(new viewGeneral2());
            }
        }
    }
}