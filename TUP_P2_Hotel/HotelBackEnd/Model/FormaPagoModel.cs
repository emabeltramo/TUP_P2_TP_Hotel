using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class FormaPagoModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Recargo { get; set; }
        public int Porcentaje { get; set; }
    }
}
