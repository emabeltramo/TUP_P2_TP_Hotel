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
    public class FacturaFront : IFacturaFront
    {
        private IFacturaDao facturaDao;
        public FacturaFront()
        {
            facturaDao = new FacturaDao();
        }
        public List<ClienteModel> GetClientes()
        {
            return facturaDao.GetClientes();
        }
        public int GetFacturaNro()
        {
            return facturaDao.GetFacturaNro();
        }

        public List<FormaPagoModel> GetFormaPago()
        {
            return facturaDao.GetFormaPago();
        }
        public List<ReservaModel> GetReserva()
        {
            return facturaDao.GetReserva();
        }
        public List<TipoFacturaModel> GetTipoFactura()
        {
            return facturaDao.GetTipoFactura();
        }

        public List<TipoServicioModel> GetTipoServicio()
        {
            return facturaDao.GetTipoServicio();
        }
        public bool SaveFactura(FacturaModel factura)
        {
            return facturaDao.SaveFactura(factura);
        }
    }
}
