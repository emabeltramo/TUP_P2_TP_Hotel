using HotelBackEnd.DAO.Implementation;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Implementation
{
    public class LoginFront : ILoginFront
    {
        private string mensaje;
        private ILoginDao loginDao;
        public LoginFront()
        {
            loginDao = new LoginDao();
            mensaje = string.Empty;
        }
        public List<EmpleadoModel> GetEmpleados()
        {
            return loginDao.GetEmpleados();
        }
    }
}
