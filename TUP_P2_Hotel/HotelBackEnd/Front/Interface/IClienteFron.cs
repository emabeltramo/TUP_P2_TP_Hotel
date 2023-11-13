using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface IClienteFront
    {
        List<TipoClienteModel> GetTipoCliente();
        List<TipoDocumentoModel> GetTipoDocumento();

        bool AltaCliente(ClienteModel cliente);
        bool ActualizarCliente(ClienteModel cliente);
        bool BajaCliente(int numero);
    }
}
