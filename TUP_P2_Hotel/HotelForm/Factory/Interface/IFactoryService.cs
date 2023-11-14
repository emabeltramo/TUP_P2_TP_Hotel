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
        IReservaService CreateReservaService();
        ILoginService CreateLoginService();
        void SetSesion(EmpleadoModel emp);
        EmpleadoModel GetSesion();
    }
}
