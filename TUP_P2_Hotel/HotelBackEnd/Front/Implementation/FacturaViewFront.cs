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
    public class FacturaViewFront : IFacturaViewFront
    {
        private IFacturaViewDao facturaviewDao;
        public FacturaViewFront()
        {
            facturaviewDao = new FacturaViewDao();
        }
        public List<ClienteModel> GetClientes()
        {
            return facturaviewDao.GetClientes();
        }
        public List<ReservaModel> GetReserva()
        {
            return facturaviewDao.GetReserva();
        }
        public List<EmpleadoModel> GetEmpleados()
        {
            return facturaviewDao.GetEmpleados();
        }
        public List<FacturaModel> GetFacturas(DateTime desde, DateTime hasta)
        {
            return facturaviewDao.GetFacturas(desde, hasta);
        }
        public List<FacturaDetalleModel> GetFacturaDetalle()
        {
            return facturaviewDao.GetFacturaDetalle();
        }
        public List<FormaPagoModel> GetFormasPago(int IdFactura)
        {
            return facturaviewDao.GetFormasPago(IdFactura);
        }
    }
}
