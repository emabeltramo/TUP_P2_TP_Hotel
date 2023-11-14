using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HotelForm.Service.Implementation
{
    public class FacturaService : IFacturaService
    {
        private const string host = "https://localhost:7107";
        public async Task<List<ClienteModel>> GetClientesAsync()
        {
            string url = host + "/factura/GetClientes";
            List<ClienteModel> result = new List<ClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Data);
            }
            return result;
        }
        public async Task<HttpResponse> AltaFactura(FacturaModel factura)
        {
            string url = host + "/factura/PostFactura";
            var cuerpo = JsonConvert.SerializeObject(factura);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);


            return response;
        }
        public async Task<List<TipoFacturaModel>> GetTipoFacturaAsync()
        {
            string url = host + "/factura/GetTipoFactura";
            List<TipoFacturaModel> result = new List<TipoFacturaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<TipoFacturaModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<FormaPagoModel>> GetFormaPagoAsync()
        {
            string url = host + "/factura/GetFormaPago";
            List<FormaPagoModel> result = new List<FormaPagoModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<FormaPagoModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<TipoServicioModel>> GetTipoServicioAsync()
        {
            string url = host + "/factura/GetTipoServicio";
            List<TipoServicioModel> result = new List<TipoServicioModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<TipoServicioModel>>(response.Data);
            }
            return result;
        }
        public async Task<int> GetFacturaNroAsync(int result)
        {
            string url = host + "/factura/GetFacturaNro";
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<int>(response.Data);
            }
            return result+1;
        }
        public async Task<List<ReservaModel>> GetReservasAsync(int idCliente)
        {
            string url = host + "/GetReservas?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["desde"] = "01/01/1950";
            query["hasta"] = "01/01/2500";
            query["idHotel"] = 0.ToString();
            query["idCliente"] = idCliente.ToString();
            query["idEstado"] = 1.ToString();



            List<ReservaModel> result = new List<ReservaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<ReservaCuentaModel>> GetReservaCuentaAsync(int idReserva)
        {
            string url = host + "/GetResCuenta?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["idReserva"] = idReserva.ToString();
            List<ReservaCuentaModel> result = new List<ReservaCuentaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaCuentaModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<ReservaHabitacionModel>> GetReservaHabAsync(int idReserva)
        {
            string url = host + "/GetResHab?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["idReserva"] = idReserva.ToString();
            List<ReservaHabitacionModel> result = new List<ReservaHabitacionModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaHabitacionModel>>(response.Data);
            }
            return result;
        }
    }
}
