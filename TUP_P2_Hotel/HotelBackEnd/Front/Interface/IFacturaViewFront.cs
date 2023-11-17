using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface IFacturaViewFront
    {
        List<ClienteModel> GetClientes();
        List<ReservaModel> GetReserva();
        List<EmpleadoModel> GetEmpleados();
        List<FacturaModel> GetFacturas(DateTime desde, DateTime hasta, int idReserva);
    }
}
