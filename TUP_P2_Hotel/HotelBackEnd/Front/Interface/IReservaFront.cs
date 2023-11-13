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
        List<EmpleadoModel> GetEmpleados();

        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincia();
        List<LocalidadModel> GetLocalidad();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel);
        List<HotelServicioModel> GetServiciosHotel(int idHotel);
        List<ReservaModel> GetReservas(DateTime desde, DateTime hasta, int idHotel);
        List<ReservaHabitacionModel> GetReservaHab(int idReserva);
        List<ReservaCuentaModel> GetReservaCuenta(int idReserva);
        List<EstadoReservaModel> GetEstadosReserva();
        bool PostReserva(ReservaModel reserva);
        string GetMensaje();
    }
}
