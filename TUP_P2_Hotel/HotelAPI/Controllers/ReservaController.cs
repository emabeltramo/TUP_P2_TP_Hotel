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
        [HttpGet("/GetClientes")]
        public IActionResult GetClientes()
        {
            try
            {
                var result = front.GetClientes();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los clientes");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetHabDispo")]
        public IActionResult GetHabDisponibles([FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] int idHotel)
        {
            try
            {


                if (desde > hasta)
                {
                    var temp = desde;
                    desde = hasta;
                    hasta = temp;
                }
                var result = front.GetHabitacionHotelDisponibles(desde, hasta, idHotel);
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar las habitaciones");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
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
        public IActionResult GetLocalidades()
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