using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class EmpleadoModel
    {
        public int Legajo { get; set; }
        public TipoDocumentoModel TDoc { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public EmpleadoModel()
        {
            Legajo = 0;
            TDoc = new TipoDocumentoModel();
            DNI = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;

        }
    }
}
