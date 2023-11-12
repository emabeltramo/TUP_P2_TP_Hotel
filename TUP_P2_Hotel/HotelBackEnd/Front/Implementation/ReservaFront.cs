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
    public class ReservaFront : IReservaFront
    {
        private IReservaDao reservaDao;
        public ReservaFront()
        {
            reservaDao = new ReservaDao();
        }
        public List<ClienteModel> GetClientes()
        {
            return reservaDao.GetClientes();
        }

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel)
        {
            return reservaDao.GetHabitacionHotelDisponibles(desde, hasta, idHotel);
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

        public List<HotelServicioModel> GetServiciosHotel(int idHotel)
        {
            return reservaDao.GetServiciosHotel(idHotel);
        }

        public string PostReserva(ReservaModel reserva)
        {
            if (!reservaDao.PostReserva(reserva))
                return reservaDao.GetError();
            return string.Empty;
        }
    }
}
