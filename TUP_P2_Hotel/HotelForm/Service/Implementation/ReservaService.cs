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


    }
}


