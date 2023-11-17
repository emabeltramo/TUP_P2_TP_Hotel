using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ReservaModel
    {
        public int IdReserva { get; set; }
        public int IdHotel { get; set; }
        public EstadoReservaModel Estado { get; set; }
        public ClienteModel Cliente { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Fecha { get; set; }
        public EmpleadoModel Empleado { get; set; }
        public List<ReservaCuentaModel> Cuenta { get; set; }
        public List<ReservaHabitacionModel> Habitaciones { get; set; }

        public ReservaModel()
        {
            IdReserva = 0;
            IdHotel = 0;
            Estado = new EstadoReservaModel();
            Cliente = new ClienteModel();
            Ingreso = DateTime.Now.Date;
            Salida = DateTime.Now.Date;
            Fecha = DateTime.Now.Date;
            Empleado = new EmpleadoModel();
            Cuenta = new List<ReservaCuentaModel>();
            Habitaciones = new List<ReservaHabitacionModel>();
        }

        public string MostrarReserva
        {
            get
            {
                if (Estado.Descri == "TODOS")
                    return "Todos";
                else
                    return IdReserva.ToString();
                    //return Ingreso.ToString("dd/MM/yyyy") + " - " + Salida.ToString("dd/MM/yyyy");
            }
        }
    }

}
