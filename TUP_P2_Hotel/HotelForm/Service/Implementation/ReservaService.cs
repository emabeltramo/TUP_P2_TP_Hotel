using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Implementation
{
    //
    public class ReservaService : IReservaService
    {
        private const string host = "https://localhost:7107";

        public async Task<List<ClienteModel>> GetClientesAsync()
        {
            string url = host + "/GetClientes";
            List<ClienteModel> result = new List<ClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Data);
            }
            return result;
        }
        public async Task<List<TipoDocumentoModel>> GetTipoDocumentosAsync()
        {
            string url = "https://localhost:7107/GetTipoDocumento"; 

            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoDocumentoModel>>(result);
            if (result != null )
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            return lst;
        }
        public async Task<List<TipoClienteModel>> GetTipoClientesAsync()
        {
            string url = host+"/GetTipoCliente";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoClienteModel>>(result);
           

            return lst;
        }

        public Task<List<HabitacionHotelModel>> GetHabitacionHotelDisponiblesAsync(DateTime desde, DateTime hasta, int idHotel)
        {
            throw new NotImplementedException();
        }

        public Task<List<HotelModel>> GetHotelesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<LocalidadModel>> GetLocalidadAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProvinciaModel>> GetProvinciaAsync()
        {
            throw new NotImplementedException();
        }

        public async Task AltaCliente(ClienteModel cliente)
        {
            string url = host + "/PostCliente";
            string cuerpo = JsonConvert.SerializeObject(cliente);
            var response = await ClientSingleton.GetInstance().PostAsync(url, cuerpo);
            if (response != null && response.SuccessStatus)
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public async Task ActualizarCliente(ClienteModel cliente)
        {
            string url = host + "/PutCliente";
            string cuerpo = JsonConvert.SerializeObject(cliente);
            var response = await ClientSingleton.GetInstance().PutAsync(url, cuerpo);
            if (response != null && response.SuccessStatus)
            {
                MessageBox.Show("Cliente actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("ERROR. No se pudo actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public async Task BajaCliente(int numero)
        {
            string url = host + "/DeleteCliente";
            string cuerpo = JsonConvert.SerializeObject(numero);
            var response = await ClientSingleton.GetInstance().DeleteAsync(url, cuerpo);
            if (response != null && response.SuccessStatus)
            {
                MessageBox.Show("Cliente actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("ERROR. No se pudo actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}


