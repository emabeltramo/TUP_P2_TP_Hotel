using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ClienteModel
    {
     

        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumentoModel TDoc { get; set; }
        public string DNI { get; set; }
        public string CUIL { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public TipoClienteModel TCliente { get; set; }
        public string RazonSocial { get; set; }

        public string NombreCompleto
        {
            get
            {
                if (RazonSocial=="-" || RazonSocial==string.Empty )
                    return Apellido + " - " + Nombre + " - " + DNI;
                else
                    return RazonSocial + " - " + CUIL;
            }
        }

        public override string ToString()
        {
            if (RazonSocial == "-")
                return Apellido + " - " + Nombre + " - " + DNI;
            else
                return RazonSocial + " - " + CUIL;
        }
    }
}
