using HotelBackEnd.DAO.Implementation;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Implementation
{
    public class ClienteFront : IClienteFront
    {
        IClienteDao dao; 
        public bool ActualizarCliente(ClienteModel cliente)
        {
            return dao.ActualizarCliente(cliente);
        }

        public bool AltaCliente(ClienteModel cliente)
        {
            return dao.AltaCliente(cliente);
        }

        public bool BajaCliente(int numero)
        {
            return dao.BajaCliente(numero);
        }

        public List<TipoClienteModel> GetTipoCliente()
        {
            return dao.GetTipoCliente();
        }

        public List<TipoDocumentoModel> GetTipoDocumento()
        {
            return dao.GetTipoDocumento();
        }
    }
}
