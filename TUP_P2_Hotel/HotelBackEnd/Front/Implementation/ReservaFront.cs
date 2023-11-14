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

        public int GetFacturaNro()
        {
            return reservaDao.GetFacturaNro();
        }

        public List<FormaPagoModel> GetFormaPago()
        {
            return reservaDao.GetFormaPago();
        }

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel)
        {
            return reservaDao.GetHabitacionHotelDisponibles(desde, hasta, idHotel);
        }

        public List<HotelModel> GetHoteles()
        {
            return reservaDao.GetHoteles();

        }

        public int GetLegajoEmpleado() //por el momento
        {
            return reservaDao.GetLegajoEmpleado();
        }

        public List<LocalidadModel> GetLocalidad()
        {
            return reservaDao.GetLocalidades();

        }

        public List<ProvinciaModel> GetProvincia()
        {
            return reservaDao.GetProvincias();
        }

        public List<ReservaModel> GetReserva()
        {
            return reservaDao.GetReserva();
        }

        public List<TipoFacturaModel> GetTipoFactura()
        {
            return reservaDao.GetTipoFactura();
        }

        public List<TipoServicioModel> GetTipoServicio()
        {
            return reservaDao.GetTipoServicio();
        }

        public bool SaveFactura(FacturaModel factura)
        {
            return reservaDao.CrearFactura(factura);
        }
    }
}
