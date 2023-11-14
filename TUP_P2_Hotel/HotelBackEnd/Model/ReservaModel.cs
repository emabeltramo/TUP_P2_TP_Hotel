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
        public EstadoReservaModel Estado { get; set; }
        public ClienteModel Cliente { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Fecha { get; set; }
        public EmpleadoModel Empleado { get; set; }
        public List<ReservaCuentaModel> Cuenta { get; set; }
        public List<ReservaHabitacionModel> Habitaciones { get; set; }

        public string FechasAlquiladas
        {
            get
            {
                    return Ingreso + " - " + Salida;
                
            }
        }
    }
}
