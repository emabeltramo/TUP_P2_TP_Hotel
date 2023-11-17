using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace HotelForm.Service.Implementation
{
    public class FacturaViewService : IFacturaViewService
    {
        private const string host = "https://localhost:7107";
        public async Task<List<ClienteModel>> GetClientesAsync()
        {
            string url = host + "/FacturaView/GetClientes";
            List<ClienteModel> result = new List<ClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<ReservaModel>> GetReservasAsync(int idCliente)
        {
            string url = host + "/GetReservas?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["desde"] = "01/01/1950";
            query["hasta"] = "01/01/2500";
            query["idCliente"] = idCliente.ToString();
            //query["idEstado"] = 1.ToString();



            List<ReservaModel> result = new List<ReservaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<FacturaModel>> GetFacturasAsync(DateTime desde, DateTime hasta, int idCliente, int idReserva)
        {
            string url = host + "/FacturaView/GetFactura?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["desde"] = desde.ToString("MM/dd/yyyy");
            query["hasta"] = hasta.ToString("MM/dd/yyyy");
            query["idCliente"] = idCliente.ToString();
            query["idReserva"] = idReserva.ToString();



            List<FacturaModel> result = new List<FacturaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<FacturaModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<FormaPagoModel>> GetFormasPagoAsync(int IdFactura)
        {
            string url = host + "/FacturaView/GetFormasPagoAsync?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["IdFactura"] = IdFactura.ToString();

            List<FormaPagoModel> result = new List<FormaPagoModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<FormaPagoModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<FacturaDetalleModel>> GetFacturaDetalle()
        {
            string url = host + "/FacturaView/GetFacturaDetalle";



            List<FacturaDetalleModel> result = new List<FacturaDetalleModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url ); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<FacturaDetalleModel>>(response.Data);
            }
            return result;
        }
    }
}
