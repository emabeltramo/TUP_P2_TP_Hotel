using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Interface
{
    public interface IReservaDao
    {
        List<ClienteModel> GetClientes();
        List<EmpleadoModel> GetEmpleados();
        List<HotelModel> GetHoteles();
        List<ProvinciaModel> GetProvincias();
        List<LocalidadModel> GetLocalidades();
        List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel);
        List<HotelServicioModel> GetServiciosHotel(int idHotel);
        List<EstadoReservaModel> GetEstadosReserva();
        List<ReservaModel> GetReservas(DateTime desde, DateTime hasta, int idHotel);
        List<ReservaHabitacionModel>GetReservaHab(int idReserva);
        List<ReservaCuentaModel> GetReservaCuenta(int idReserva);

        bool PostReserva(ReservaModel reserva);
        string GetMensaje();
    }
}
