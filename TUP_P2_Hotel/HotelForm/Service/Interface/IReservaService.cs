using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBackEnd.Model;

namespace HotelForm.Service.Interface
{
    public interface IReservaService
    {
        Task<List<ClienteModel>> GetClientesAsync();
        Task<List<TipoDocumentoModel>> GetTipoDocumentosAsync();
        Task<List<TipoClienteModel>> GetTipoClientesAsync();
        Task<List<HotelModel>> GetHotelesAsync();
        Task<List<ProvinciaModel>> GetProvinciaAsync();
        Task<List<LocalidadModel>> GetLocalidadAsync();
        Task<List<HabitacionHotelModel>> GetHabitacionHotelDisponiblesAsync(DateTime desde, DateTime hasta, int idHotel);
    }
}
