using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class HotelContactoModel
    {
        public int IdContacto { get; set; }
        public TipoContactoModel TCantacto { get; set; }
        public string Descri { get; set; }
    }
}
