﻿using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForm.Service.Interface
{
    public interface IFacturaService
    {
        Task<List<ClienteModel>> GetClientesAsync();
        Task<List<TipoFacturaModel>> GetTipoFacturaAsync();
        Task<List<FormaPagoModel>> GetFormaPagoAsync();
        Task<List<TipoServicioModel>> GetTipoServicioAsync();
        Task<int> GetFacturaNroAsync(int result);
        Task<List<ReservaModel>> GetReservaAsync();
        Task<HttpResponse> AltaFactura(FacturaModel factura);
    }
}
