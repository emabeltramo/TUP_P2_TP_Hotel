using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public ClienteModel()
        {
            Id_Cliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            TDoc = new TipoDocumentoModel();
            DNI = string.Empty;
            CUIL = string.Empty;
            Email = string.Empty;   
            Celular = string.Empty; 
            TCliente = new TipoClienteModel();
            RazonSocial = string.Empty;

        }

        public ClienteModel(int id, string nom , string ape, TipoDocumentoModel tDoc,string dni,string cuil,string mail, string cel,TipoClienteModel tCli,string razSoc)
        {
            Id_Cliente= id;
            Nombre= nom;
            Apellido= ape;
            TDoc = tDoc;
            DNI = dni;
            CUIL = cuil;
            Email = mail;
            Celular = cel;
            TCliente= tCli;
            RazonSocial = razSoc;
        }
    }
}
