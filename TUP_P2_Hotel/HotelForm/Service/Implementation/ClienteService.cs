using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Implementation
{
    internal class ClienteService
    {

        public async Task<List<TipoDocumentoModel>> GetTipoDocumentosAsync()
        {
            string url = "https://localhost:7107/GetTipoDocumento";

            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoDocumentoModel>>(result);
            if (result != null)
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            return lst;
        }
        public async Task<List<TipoClienteModel>> GetTipoClientesAsync()
        {
            string url = host + "/GetTipoCliente";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoClienteModel>>(result);


            return lst;
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
