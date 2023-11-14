using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HotelForm.Service.Implementation
{
    internal class ClienteService: IClienteService
    {
        private const string host = "https://localhost:7107";
        public async Task<List<TipoDocumentoModel>> GetTipoDocumentosAsync()
        {
            string url = host + "/GetTipoDocumento";
            List<TipoDocumentoModel> result = new List<TipoDocumentoModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); 
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<TipoDocumentoModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<TipoClienteModel>> GetTipoClientesAsync()
        {
            string url = host + "/GetTipoCliente";
            List<TipoClienteModel> result = new List<TipoClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<TipoClienteModel>>(response.Data);
            }
            return result;
        }
  


        public async Task<HttpResponse> ActualizarCliente(ClienteModel cliente)
        {
            string url = host + "/PutCliente";
            var cuerpo = JsonConvert.SerializeObject(cliente);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);

            return response;
        }

        public async Task<HttpResponse> BajaCliente(int numero)
        {
            string url = host + "/DeleteCliente";
            var cuerpo = JsonConvert.SerializeObject(numero);
            var response = await ClientSingleton.GetInstance().DeleteAsync(url, cuerpo);
           
            throw new NotImplementedException();
        }

        public async Task<List<ClienteModel>> GetClientesAsync()
        {
            string url = host + "/GetClientes";
            List<ClienteModel> result = new List<ClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Data);
            }
            return result;
        }

        public async Task<HttpResponse> AltaCliente(ClienteModel cliente)
        {
            string url = host + "/PostCliente";
            var cuerpo = JsonConvert.SerializeObject(cliente);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);


            return response;
        }
        public async Task<HttpResponse> AltaFactura(FacturaModel factura)
        {
            string url = host + "/PostFactura";
            var cuerpo = JsonConvert.SerializeObject(factura);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);


            return response;
        }

        public async Task<List<TipoFacturaModel>> GetTipoFacturaAsync()
        {
            string url = host + "/GetTipoFactura";
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
            string url = host + "/GetFormaPago";
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
            string url = host + "/GetTipoServicio";
            List<TipoServicioModel> result = new List<TipoServicioModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<TipoServicioModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<ReservaModel>> GetReservaAsync()
        {
            string url = host + "/GetReserva";
            List<ReservaModel> result = new List<ReservaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaModel>>(response.Data);
            }
            return result;
        }

        public async Task<int> GetFacturaNroAsync(int result)
        {
            string url = host + "/GetFacturaNro";
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<int>(response.Data);
            }
            return result;
        }
    }
}
