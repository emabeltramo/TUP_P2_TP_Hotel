using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ReservaCuentaModel
    {
        public int IdResCuenta { get; set; }
        public TipoServicioModel Servicio { get; set; }
        public decimal Monto { get; set; }
        public bool Bonificado { get; set; }
        public int Cantidad { get; set; }
    }
}
