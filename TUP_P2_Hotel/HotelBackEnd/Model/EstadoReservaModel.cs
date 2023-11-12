using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class EstadoReservaModel
    {
        public int IdEstadoReserva { get; set; }
        public string Descri { get; set; }

        public EstadoReservaModel()
        {
            IdEstadoReserva = 0;
            Descri = string.Empty;
        }
    }
}
