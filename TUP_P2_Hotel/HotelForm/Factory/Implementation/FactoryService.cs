using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using HotelForm.Service.Implementation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBackEnd.Model;

namespace HotelForm.Factory.Implementation
{
    internal class FactoryService : IFactoryService
    {
        private EmpleadoModel sesion;
        public IReservaService CreateReservaService()
        {
            return new ReservaService();
        }
        public ILoginService CreateLoginService()
        {
           return new LoginService();
        }

        public void SetSesion(EmpleadoModel emp)
        {
            sesion = emp;
        }

        public EmpleadoModel GetSesion()
        {
            return sesion;
        }
    }
}
