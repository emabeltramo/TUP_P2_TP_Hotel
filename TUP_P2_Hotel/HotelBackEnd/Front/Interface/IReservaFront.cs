using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface IReservaFront
    {
        List<ClienteModel> GetClientes();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincia();
        List<LocalidadModel> GetLocalidad();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateOnly desde, DateOnly hasta, int idHotel);
    }
}
