using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Front.Implementation;


namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private IReservaFront front;
        public ReservaController()
        {
            front = new ReservaFront();
        }
    }
}
