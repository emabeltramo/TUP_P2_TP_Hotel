using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.HTTPClient
{
    public class HttpResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Data { get; set; }

        public HttpResponse(HttpStatusCode code, string data)
        {
            StatusCode = code;
            Data = data;
        }
    }
}
