using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Interface
{
    internal interface IReservaDao
    {
        int GetFacturaNro();
        int GetLegajoEmpleado(); //por el momento
        List<ClienteModel> GetClientes();
        List<FormaPagoModel> GetFormaPago();
        List<TipoFacturaModel> GetTipoFactura();
        List<TipoServicioModel> GetTipoServicio();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincias();
        List<LocalidadModel> GetLocalidades();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel);
        List<ReservaModel> GetReserva();
        bool CrearFactura(FacturaModel factura);
    }
}
