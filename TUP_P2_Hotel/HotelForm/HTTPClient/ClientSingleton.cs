using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.HTTPClient
{
    public class ClientSingleton
    {
        private static ClientSingleton instance;
        private HttpClient client;

        public ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instance == null)
            {

                instance = new ClientSingleton();

            }
            return instance;
        }
        public async Task<HttpResponse> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";


            if (result.IsSuccessStatusCode)
            {

                content = await result.Content.ReadAsStringAsync();
            }
            Console.WriteLine(content);
            return new HttpResponse(result.StatusCode, content);
        }

        public async Task<HttpResponse> PostAsync(string url, string data)
        {


            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            var reply = "";

            if (result.IsSuccessStatusCode)
            {

                reply = await result.Content.ReadAsStringAsync();
            }
            return new HttpResponse(result.StatusCode, reply);


            //
        }
    }
}
