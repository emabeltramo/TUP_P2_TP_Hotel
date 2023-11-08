using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class HotelServicioModel
    {
        public int IdServicioHotel { get; set; }
        public TipoServicioModel Servicio { get; set; }
        public decimal Precio { get; set; }
    }
}
