using HotelBackEnd.DAO.Implementation;
using HotelBackEnd.DAO.Interface;
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
        private IReservaDao reservaDao;
        public ReservaFront()
        {
            reservaDao = new ReservaDao();
        }
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
            return reservaDao.GetHoteles();

        }

        public List<LocalidadModel> GetLocalidad()
        {
            return reservaDao.GetLocalidades();

        }

        public List<ProvinciaModel> GetProvincia()
        {
            return reservaDao.GetProvincias();
        }
    }
}
