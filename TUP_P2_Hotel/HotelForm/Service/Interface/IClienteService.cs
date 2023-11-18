using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Interface
{
    public interface IClienteService
    {

        Task<HttpResponse> AltaCliente(ClienteModel cliente);
        Task<HttpResponse> ActualizarCliente(ClienteModel cliente);
        Task<HttpResponse> BajaCliente(string numero);
        Task<List<ClienteModel>> GetClientesListaAsync();
        Task <ClienteModel> GetClienteIDAsync(int id);
        Task<List<ClienteModel>> GetClientesAsync();
        Task<List<TipoDocumentoModel>> GetTipoDocumentosAsync();
        Task<List<TipoClienteModel>> GetTipoClientesAsync();
    }
}
