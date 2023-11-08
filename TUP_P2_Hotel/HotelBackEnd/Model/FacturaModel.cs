using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class FacturaModel
    {
        public int IdFactura { get; set; }
        public int NumFactura { get; set; }
        public ClienteModel Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public ReservaModel Reserva { get; set; }
        public EmpleadoModel Empleado { get; set; }
        public TipoFacturaModel TipoFactura { get; set; }
    }
}
