using HotelBackEnd.Front.Implementation;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private IFacturaFront front;
        public FacturaController()
        {
            front = new FacturaFront();
        }
        [HttpGet("/factura/GetClientes")]
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

        [HttpPost("/factura/PostFactura")]
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
        [HttpGet("/factura/GetTipoFactura")]
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
        [HttpGet("/factura/GetFormaPago")]
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
        [HttpGet("/factura/GetTipoServicio")]
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
        [HttpGet("/factura/GetFacturaNro")]
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
        [HttpGet("/factura/GetReserva")]
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
        [HttpGet("/factura/GetReporte")]
        public IActionResult GetReporte([FromQuery] int year)
        {
            try
            {
                var result = front.GetReporte(year);
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar el reporte");
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
