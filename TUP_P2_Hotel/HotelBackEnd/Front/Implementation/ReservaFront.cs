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
        private string mensaje;
        private IReservaDao reservaDao;
        public ReservaFront()
        {
            reservaDao = new ReservaDao();
            mensaje = string.Empty;
        }

        public bool DeleteReserva(int idReserva)
        {
            var result= reservaDao.DeleteReserva(idReserva);
            mensaje = reservaDao.GetMensaje();
            return result;
        }

        public List<ClienteModel> GetClientes()
        {
            return reservaDao.GetClientes();
        }

        public List<EmpleadoModel> GetEmpleados()
        {
            return reservaDao.GetEmpleados();
        }

        public List<EstadoReservaModel> GetEstadosReserva()
        {
            return reservaDao.GetEstadosReserva();
        }

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel, int idReserva)
        {
            return reservaDao.GetHabitacionHotelDisponibles(desde, hasta, idHotel, idReserva);
        }

        public List<HotelModel> GetHoteles()
        {
            return reservaDao.GetHoteles();

        }

        public List<LocalidadModel> GetLocalidad()
        {
            return reservaDao.GetLocalidades();

        }

        public string GetMensaje()
        {
            return mensaje;
        }

        public List<ProvinciaModel> GetProvincia()
        {
            return reservaDao.GetProvincias();
        }

        public List<ReservaCuentaModel> GetReservaCuenta(int idReserva)
        {
           return reservaDao.GetReservaCuenta(idReserva);
        }

        public List<ReservaHabitacionModel> GetReservaHab(int idReserva)
        {
            return reservaDao.GetReservaHab(idReserva);
        }

        public List<ReservaModel> GetReservas(DateTime desde, DateTime hasta, int idHotel)
        {
            return reservaDao.GetReservas(desde, hasta,idHotel);
        }

        public List<HotelServicioModel> GetServiciosHotel(int idHotel)
        {
            return reservaDao.GetServiciosHotel(idHotel);
        }

        public bool PostReserva(ReservaModel reserva)
        {
           var result = reservaDao.PostReserva(reserva);
            mensaje = reservaDao.GetMensaje();
            return result;
            
        }
        public bool PutReserva(ReservaModel reserva)
        {
            var result = reservaDao.PutReserva(reserva);
            mensaje = reservaDao.GetMensaje();
            return result;

        }
    }
}
