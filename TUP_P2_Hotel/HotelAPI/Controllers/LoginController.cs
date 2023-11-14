using HotelBackEnd.Front.Interface;
using HotelBackEnd.Front.Implementation;

using HotelBackEnd.Front.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginFront front;
        public LoginController()
        {
            front = new LoginFront();
        }
        [HttpGet("/GetEmpleados")]
        public IActionResult GetEmpleados()
        {
            try
            {
                var result = front.GetEmpleados();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los empleados");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
