using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class FacturaPagoModel
    {
        public int IdFactPago { get; set; }
        public List<FormaPagoModel> Forma { get; set; }
        
    }
    
}
