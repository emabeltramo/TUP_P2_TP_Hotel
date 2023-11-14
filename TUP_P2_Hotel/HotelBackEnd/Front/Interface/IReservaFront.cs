using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface IReservaFront
    {
        List<ClienteModel> GetClientes();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincia();
        List<LocalidadModel> GetLocalidad();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel);
        List<TipoFacturaModel> GetTipoFactura();
        List<FormaPagoModel> GetFormaPago();
        List<TipoServicioModel> GetTipoServicio();
        List<ReservaModel> GetReserva();
        int GetFacturaNro();
        int GetLegajoEmpleado(); //por el momento
        public bool SaveFactura(FacturaModel factura);
    }
}
