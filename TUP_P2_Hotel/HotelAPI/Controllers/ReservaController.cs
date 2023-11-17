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
        [HttpGet("/GetEstadosR")]
        public IActionResult GetEstadosReserva()
        {
            List<EstadoReservaModel> lsEstados;
            try
            {
                lsEstados = front.GetEstadosReserva();
                return Ok(lsEstados);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
        }
        [HttpGet("/GetHoteServ")]
        public IActionResult GetHabDisponibles(int idHotel)
        {
            try
            {

                var result = front.GetServiciosHotel(idHotel);
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
        [HttpPost("/PostReserva")]
        public IActionResult PostReserva(ReservaModel reserva)
        {
            try
            {
                if (reserva.Habitaciones.Count() < 1)
                    return StatusCode(401, "La reserva debe contener habitaciones");
                if (reserva.Cliente.Id_Cliente<1)
                    return StatusCode(401, "La reserva debe contener un cliente");
                if (reserva.Ingreso<DateTime.Now.Date)
                    return StatusCode(401, "La fecha de ingreso no puede ser menor a la del dia de hoy");
                var result = front.PostReserva(reserva);
                var mensaje = front.GetMensaje();
                if (!result)
                {
                    return StatusCode(500, mensaje);
                }
                return StatusCode(201,mensaje);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetReservas")]
        public IActionResult GetReservas([FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] int idHotel,[FromQuery] int idCliente, [FromQuery] int idEstado)
        {
            try
            {


                if (desde > hasta)
                {
                    var temp = desde;
                    desde = hasta;
                    hasta = temp;
                }
                var result = front.GetReservas(desde, hasta,idHotel);
                var clientes = front.GetClientes();
                var empleados = front.GetEmpleados();
                var estados = front.GetEstadosReserva();

                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar las reservas");
                }
                if (idCliente != 0)
                    result.RemoveAll(m => m.Cliente.Id_Cliente != idCliente);
                if(idEstado !=0)
                    result.RemoveAll(m => m.Estado.IdEstadoReserva != idEstado);

                foreach (var item in result)
                {
                    item.Estado = estados.FirstOrDefault(m=>m.IdEstadoReserva ==item.Estado.IdEstadoReserva);
                    item.Cliente = clientes.FirstOrDefault(m => m.Id_Cliente == item.Cliente.Id_Cliente);
                    item.Empleado = empleados.FirstOrDefault(m => m.Legajo == item.Empleado.Legajo);
                }


                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetResHab")]
        public IActionResult GetReservaHab(int idReserva)
        {
            try
            {

                var result = front.GetReservaHab(idReserva);
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
        [HttpGet("/GetResCuenta")]
        public IActionResult GetReservaCuenta(int idReserva)
        {
            try
            {

                var result = front.GetReservaCuenta(idReserva);
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
        [HttpDelete("/DeleteReserva")]
        public IActionResult DeleteReserva(int idReserva)
        {
            try
            {
                
                var result = front.DeleteReserva(idReserva);
                var mensaje = front.GetMensaje();
                if (!result)
                {
                    return StatusCode(500, mensaje);
                }
                return StatusCode(200, mensaje);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}