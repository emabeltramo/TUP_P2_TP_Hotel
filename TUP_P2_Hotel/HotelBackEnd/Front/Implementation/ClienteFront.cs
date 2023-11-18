using HotelBackEnd.DAO.Implementation;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Implementation
{
    public class ClienteFront : IClienteFront
    {
        private IClienteDao dao;

        public ClienteFront()
        {
            dao = new ClienteDao();
        }

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

        public List<ClienteModel> GetClientes()
        {
            return dao.GetClientes();
        }public List<ClienteModel> GetClientesLista()
        {
            return dao.GetClientesLista();
        }
        public ClienteModel GetClienteID(int id)
        {
            return dao.GetClienteID(id);
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
