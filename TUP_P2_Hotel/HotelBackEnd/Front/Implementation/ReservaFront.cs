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
        public List<ClienteModel> GetClientes()
        {
            throw new NotImplementedException();
        }

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateOnly desde, DateOnly hasta, int idHotel)
        {
            throw new NotImplementedException();
        }

        public List<HotelModel> GetHoteles()
        {
            throw new NotImplementedException();
        }

        public List<LocalidadModel> GetLocalidad()
        {
            throw new NotImplementedException();
        }

        public List<ProvinciaModel> GetProvincia()
        {
            throw new NotImplementedException();
        }
    }
}
