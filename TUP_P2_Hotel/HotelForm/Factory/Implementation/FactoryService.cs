using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using HotelForm.Service.Implementation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Factory.Implementation
{
    internal class FactoryService : IFactoryService
    {
        public IReservaService CreateReservaService()
        {
            return new ReservaService();
        }
        public IReservaService CreateClienteService()
        {
            return new ClienteService();
        }
    }
}
