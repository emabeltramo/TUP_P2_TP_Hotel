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
        [HttpGet("/GetCleintes")]
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


        [HttpGet("/GetTipoFactura")]
        public IActionResult GetTipoFactura()
        {
            try
            {
                var result = front.GetTipoFactura();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los tipos de facturas");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetFormaPago")]
        public IActionResult GetFormaPago()
        {
            try
            {
                var result = front.GetFormaPago();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar las formas de pagos");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetTipoServicio")]
        public IActionResult GetTipoServicio()
        {
            try
            {
                var result = front.GetTipoServicio();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los servicios");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        
            [HttpGet("/GetLegajoEmpleado")] //por el momento
        public IActionResult GetLegajoEmpleado()
        {
            try
            {
                var result = front.GetLegajoEmpleado();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los servicios");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet("/GetFacturaNro")]
        public IActionResult GetFacturaNro()
        {
            try
            {
                var result = front.GetFacturaNro();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los servicios");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetReserva")]
        public IActionResult GetReserva()
        {
            try
            {
                var result = front.GetReserva();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los servicios");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpPost("/PostFactura")]
        public IActionResult PostFactura(FacturaModel factura)
        {
            try
            {
                if (factura == null)
                {
                    return BadRequest("Datos de Factura incorrectas!");
                }
                return Ok(front.SaveFactura(factura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
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