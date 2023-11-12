using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class TipoServicioModel
    {
        public int Id { get; set; }
        public string Descri { get; set; }
        public TipoServicioModel()
        {
            Id = 0;
            Descri = string.Empty;
        }
    }
}
