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
        List<ClienteModel> GetClientes();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincia();
        List<LocalidadModel> GetLocalidad();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel);
    }
}
