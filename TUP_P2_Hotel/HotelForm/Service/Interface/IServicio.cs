
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios.Interfaz
{
    public interface IServicio
    {

        List<ClienteModel> GetClientes();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincia();
        List<LocalidadModel> GetLocalidad();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateOnly desde, DateOnly hasta, int idHotel);
    }
}
