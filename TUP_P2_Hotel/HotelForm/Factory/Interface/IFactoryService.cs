using HotelBackEnd.Model;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Factory.Interface
{
    public interface IFactoryService
    {
        IFacturaViewService CreateFacturaViewService();
        IReservaService CreateReservaService();
        ILoginService CreateLoginService();
        IFacturaService CreateFacturaService();
        void SetSesion(EmpleadoModel emp);
        EmpleadoModel GetSesion();
    }
}
