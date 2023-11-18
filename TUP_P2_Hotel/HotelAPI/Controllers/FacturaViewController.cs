using HotelBackEnd.Front.Implementation;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaViewController : ControllerBase
    {
        private IFacturaViewFront front;
        public FacturaViewController()
        {
            front = new FacturaViewFront();
        }
        [HttpGet("/FacturaView/GetClientes")]
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
        [HttpGet("/FacturaView/GetReserva")]
        public IActionResult GetReserva([FromQuery] int idCliente)
        {
            try
            {
                var result = front.GetReserva();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar las reservas");
                }
                if (idCliente != 0 )
                    result.RemoveAll(m => m.Cliente.Id_Cliente != idCliente);

                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/FacturaView/GetFacturaDetalle")]
        public IActionResult GetFacturaDetalle()
        {
            try
            {
                var result = front.GetFacturaDetalle();

                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar las facturas");
                }

                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        

            [HttpGet("/FacturaView/GetFormasPago")]
        public IActionResult GetFormasPago(int IdFactura)
        {
            try
            {
                var result = front.GetFormasPago(IdFactura);
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

        [HttpGet("/FacturaView/GetFactura")]
        public IActionResult GetFactura([FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] int idCliente, [FromQuery] int idReserva)
        {
            try
            {
                if (desde > hasta)
                {
                    var temp = desde;
                    desde = hasta;
                    hasta = temp;
                }
                var result = front.GetFacturas(desde, hasta);
                var clientes = front.GetClientes();
                var reserva = front.GetReserva();
                var empleados = front.GetEmpleados();

                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar las facturas");
                }
                if (idCliente != 0)
                    result.RemoveAll(m => m.Cliente.Id_Cliente != idCliente);
                if (idReserva != 0)
                    result.RemoveAll(m => m.Reserva.IdReserva != idReserva);

                foreach (var item in result)
                {
                    item.Cliente = clientes.FirstOrDefault(m => m.Id_Cliente == item.Cliente.Id_Cliente);
                    item.Reserva = reserva.FirstOrDefault(m => m.IdReserva == item.Reserva.IdReserva);
                    item.Empleado = empleados.FirstOrDefault(m => m.Legajo == item.Empleado.Legajo);
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
