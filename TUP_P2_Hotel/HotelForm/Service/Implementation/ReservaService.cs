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
    internal class ReservaService : IReservaService
    {
        private  const string host = "https://localhost:7107";
        
        public async Task<List<ClienteModel>> GetClientesAsync()
        {
            string url = host + "/GetCleintes";
            List<ClienteModel> result = new List<ClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response!=null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Data);
            }
            return result;
        }

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel)
        {
            throw new NotImplementedException();
        }

        public List<HotelModel> GetHoteles()
        {
            throw new NotImplementedException();
        }

        public List<LocalidadModel> GetLocalidad()
        {
            throw new NotImplementedException();
        }

        public List<ProvinciaModel> GetProvincia()
        {
            throw new NotImplementedException();
        }
    }
}
