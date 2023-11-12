using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBackEnd.Model;
using HotelForm.HTTPClient;

namespace HotelForm.Service.Interface
{
    public interface IReservaService
    {
        Task<List<ClienteModel>> GetClientesAsync();
        Task<List<HotelModel>> GetHotelesAsync();
        Task<List<ProvinciaModel>> GetProvinciaAsync();
        Task<List<LocalidadModel>> GetLocalidadAsync();
        Task<List<HabitacionHotelModel>> GetHabitacionHotelDisponiblesAsync(DateTime desde, DateTime hasta, int idHotel);
        Task<List<HotelServicioModel>> GetServiciosHotelAsync(int idHotel);
        Task<HttpResponse> PostReservaAsync(ReservaModel Reservar);
    }
}
