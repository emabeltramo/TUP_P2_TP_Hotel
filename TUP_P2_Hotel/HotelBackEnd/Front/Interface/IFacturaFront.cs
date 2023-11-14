using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface IFacturaFront
    {
        List<ClienteModel> GetClientes();
        public bool SaveFactura(FacturaModel factura);
        List<TipoFacturaModel> GetTipoFactura();
        List<FormaPagoModel> GetFormaPago();
        List<TipoServicioModel> GetTipoServicio();
        int GetFacturaNro();
        List<ReservaModel> GetReserva();
    }
}
