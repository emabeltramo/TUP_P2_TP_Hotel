using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Interface
{
    internal interface IClienteService
    {

        Task AltaCliente(ClienteModel cliente);
        Task ActualizarCliente(ClienteModel cliente);
        Task BajaCliente(int numero);
        Task<List<ClienteModel>> GetClientesAsync();
        Task<List<TipoDocumentoModel>> GetTipoDocumentosAsync();
        Task<List<TipoClienteModel>> GetTipoClientesAsync();
    }
}
