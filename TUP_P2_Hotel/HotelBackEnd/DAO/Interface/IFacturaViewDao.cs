﻿using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Interface
{
    public interface IFacturaViewDao
    {
        List<ClienteModel> GetClientes();
        public List<ReservaModel> GetReserva();
        List<FacturaModel> GetFacturas(DateTime desde, DateTime hasta, int idReserva);
        List<EmpleadoModel> GetEmpleados();
    }
}
