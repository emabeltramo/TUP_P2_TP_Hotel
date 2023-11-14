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
        Task<List<EstadoReservaModel>> GetEstadosReservaAsync();
        Task<List<HotelServicioModel>> GetServiciosHotelAsync(int idHotel);
        Task<List<ReservaModel>> GetReservasAsync(DateTime desde, DateTime hasta, int idHotel, int idCliente, int idEstado);
        Task<List<ReservaHabitacionModel>> GetReservaHabAsync(int idReserva);
        Task<List<ReservaCuentaModel>> GetReservaCuentaAsync(int idReserva);
        Task<HttpResponse> PostReservaAsync(ReservaModel Reservar);
        Task<HttpResponse> DeleteReservaAsync(int idReserva);

    }
}
