using HotelBackEnd.Model;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Implementation
{
    internal class ReservaService : IReservaService
    {
        public List<ClienteModel> GetClientes()
        {
            throw new NotImplementedException();
        }

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel)
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
