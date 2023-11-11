using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Front.Implementation;
using HotelBackEnd.Model;

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
        [HttpGet("/GetProvincias")]
        public IActionResult GetProvincias()
        {
            List<ProvinciaModel> lstProv;
            try
            {
                lstProv = front.GetProvincia();
                return Ok(lstProv);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
        }
        [HttpGet("/GetLocalidades")]
        public IActionResult GetLocalidades ()
        {
            List<LocalidadModel> lstLoc;
            try
            {
                lstLoc = front.GetLocalidad();
                return Ok(lstLoc);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
        }
        [HttpGet("/GetHoteles")]

        public IActionResult GetHoteles()
        {
            List<HotelModel> lstHotel;
            try
            {
                lstHotel = front.GetHoteles();
                return Ok(lstHotel);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
        }

    }
}
