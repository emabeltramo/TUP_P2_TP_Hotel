using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class FacturaDetalleModel
    {
        public int IdDetalle { get; set; }
        public TipoServicioModel Servicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public double CalcularSubTotal()
        {
            return Monto * Cantidad;
        }
    }
}
