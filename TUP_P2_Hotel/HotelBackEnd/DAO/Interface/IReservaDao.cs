using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Interface
{
    internal interface IReservaDao
    {
        List<ClienteModel> GetClientes();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincias();
        List<LocalidadModel> GetLocalidades();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel);
    }
}
