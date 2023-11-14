using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Interface
{
    public interface ILoginService
    {
        Task<List<EmpleadoModel>> GetEmpleados();
    }
}
