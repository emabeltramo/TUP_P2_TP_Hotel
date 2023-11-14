using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface ILoginFront
    {
        List<EmpleadoModel> GetEmpleados();
    }
}
