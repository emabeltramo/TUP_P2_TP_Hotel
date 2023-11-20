using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ReporteModel
    {
        public int Posicion { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public int Noches{ get; set; }
        public decimal Promedio { get; set; }
        public ReporteModel()
        {

        }
    }
}
