using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Interface
{
    public interface IClienteDao
    {
        List<TipoClienteModel> GetTipoCliente();
        List<TipoDocumentoModel> GetTipoDocumento();

        DataTable GetClientes();
        bool AltaCliente(ClienteModel cliente);
        bool ActualizarCliente(ClienteModel cliente);
        bool BajaCliente(int numero);
    }
}
