using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Interface
{
    public interface IFacturaViewService
    {
        Task<List<ClienteModel>> GetClientesAsync();
        Task<List<ReservaModel>> GetReservasAsync(int idCliente);
        Task<List<FacturaModel>> GetFacturasAsync(DateTime desde, DateTime hasta, int idCliente, int idReserva);
    }
}
