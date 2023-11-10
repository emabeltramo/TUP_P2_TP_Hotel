using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Implementation
{
    internal class ReservaFront : IReservaFront
    {
        List<ClienteModel> IReservaFront.GetClientes()
        {
            throw new NotImplementedException();
        }

        List<HabitacionHotelModel> IReservaFront.GetHabitacionHotelDisponibles(DateOnly desde, DateOnly hasta, int idHotel)
        {
            throw new NotImplementedException();
        }

        List<HotelModel> IReservaFront.GetHoteles()
        {
            throw new NotImplementedException();
        }

        List<LocalidadModel> IReservaFront.GetLocalidad()
        {
            throw new NotImplementedException();
        }

        List<ProvinciaModel> IReservaFront.GetProvincia()
        {
            throw new NotImplementedException();
        }
    }
}
