using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using Newtonsoft.Json;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Implementation
{
    public class LoginService : ILoginService
    {
        private const string host = "https://localhost:7107";
        public async Task<List<EmpleadoModel>> GetEmpleados()
        {
            
                string url = host + "/GetEmpleados";
                List<EmpleadoModel> result = new List<EmpleadoModel>();
                var response = await ClientSingleton.GetInstance().GetAsync(url); ;
                if (response != null && response.SuccessStatus)
                {
                    result = JsonConvert.DeserializeObject<List<EmpleadoModel>>(response.Data);
                }
                return result;
           
        }
    }
}
