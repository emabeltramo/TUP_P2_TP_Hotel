using HotelBackEnd.DAO.Helper;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Implementation
{
    public class FacturaViewDao : IFacturaViewDao
    {
        public List<ClienteModel> GetClientes()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<ClienteModel> result = new List<ClienteModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select * from clientes order by apellido, nombre";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var cliente = new ClienteModel()
                        {
                            Apellido = reg.FirstOrDefault(m => m.Campo.ToUpper() == "APELLIDO").Valor ?? string.Empty,
                            Nombre = reg.FirstOrDefault(m => m.Campo.ToUpper() == "NOMBRE").Valor ?? string.Empty,
                            DNI = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DNI").Valor ?? string.Empty,
                            Id_Cliente = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? 0,
                            CUIL = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CUIL").Valor ?? string.Empty,
                            Email = reg.FirstOrDefault(m => m.Campo.ToUpper() == "EMAIL").Valor ?? string.Empty,
                            Celular = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CELULAR").Valor ?? string.Empty,
                            RazonSocial = reg.FirstOrDefault(m => m.Campo.ToUpper() == "RAZON_SOCIAL").Valor ?? string.Empty,



                        };
                        result.Add(cliente);
                    }
                }


            }
            catch (Exception)
            {
                result = null;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }
        private List<FormaPagoModel> GetFormaPago(int idFactura, SqlConnection cnn, SqlTransaction t)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<FormaPagoModel> result = new List<FormaPagoModel>();
            try
            {
                cmd.CommandText = "ps_FormasPago";
                cmd.Connection = cnn;
                cmd.Transaction = t;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                var p = new List<SqlParameter>();
                p.Add(new SqlParameter("@idfactura", (object)idFactura ?? DBNull.Value));
                cmd.Parameters.AddRange(p.ToArray());

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);

                        var formapago = new FormaPagoModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? 0,
                            Descripcion = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRICION").Valor ?? string.Empty,
                            Recargo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "RECARGO").Valor ?? false,
                            Porcentaje = reg.FirstOrDefault(m => m.Campo.ToUpper() == "PORCENTAJE_RECARGO").Valor ?? 0,

                        };
                        result.Add(formapago);
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        public List<ReservaModel> GetReserva()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<ReservaModel> result = new List<ReservaModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "ps_ReservasView";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);

                        int estado = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ESTADO").Valor ?? string.Empty;
                        int cliente = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CLIENTE").Valor ?? string.Empty;
                        int empleado = reg.FirstOrDefault(m => m.Campo.ToUpper() == "EMPLEADO").Valor ?? string.Empty;

                        var Reserva = new ReservaModel()
                        {
                            IdReserva = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? string.Empty,
                            Ingreso = reg.FirstOrDefault(m => m.Campo.ToUpper() == "INGRESO").Valor ?? string.Empty,
                            Salida = reg.FirstOrDefault(m => m.Campo.ToUpper() == "SALIDA").Valor ?? string.Empty,
                            Fecha = reg.FirstOrDefault(m => m.Campo.ToUpper() == "FECHA_RESERVA").Valor ?? string.Empty,

                        };

                        Reserva.Estado.IdEstadoReserva = estado;
                        Reserva.Estado.Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRIPCION").Valor ?? string.Empty;
                        Reserva.Cliente.Id_Cliente = cliente;
                        Reserva.Empleado.Legajo = empleado;
                        result.Add(Reserva);
                    }
                }


            }
            catch (Exception)
            {
                result = null;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }

        private List<FacturaDetalleModel> GetFacturaDetalle(int idFactura, SqlConnection cnn, SqlTransaction t)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<FacturaDetalleModel> result = new List<FacturaDetalleModel>();
            try
            {
                cmd.CommandText = "ps_detalleFacturas";
                cmd.Connection = cnn;
                cmd.Transaction = t;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                var p = new List<SqlParameter>();
                p.Add(new SqlParameter("@idfactura", (object)idFactura ?? DBNull.Value));
                cmd.Parameters.AddRange(p.ToArray());

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var model = new FacturaDetalleModel()
                        {
                            IdDetalle = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? 0,
                            Cantidad = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CANTIDAD").Valor ?? 0,
                            Monto = reg.FirstOrDefault(m => m.Campo.ToUpper() == "MONTO").Valor ?? 0,
                        };
                        model.Servicio.Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "idServicio").Valor ?? 0;
                        model.Servicio.Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRIPCION").Valor ?? string.Empty;

                        result.Add(model);
                    }
                }


            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public List<FacturaModel> GetFacturas(DateTime desde, DateTime hasta, int idReserva)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<FacturaModel> result = new List<FacturaModel>();
            SqlTransaction t = null;
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "ps_Facturas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                var p = new List<SqlParameter>();
                p.Add(new SqlParameter("@desde", (object)desde ?? DBNull.Value));
                p.Add(new SqlParameter("@hasta", (object)hasta ?? DBNull.Value));
                p.Add(new SqlParameter("@reserva", (object)idReserva ?? DBNull.Value));

                cmd.Parameters.AddRange(p.ToArray());
                cmd.Connection.Open();
                t = cmd.Connection.BeginTransaction();
                cmd.Transaction = t;
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var model = new FacturaModel()
                        {
                            IdFactura = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? 0,
                            NumFactura = reg.FirstOrDefault(m => m.Campo.ToUpper() == "N_FACTURA").Valor ?? 0,
                            Fecha = reg.FirstOrDefault(m => m.Campo.ToUpper() == "FECHA").Valor ?? DateTime.Now.Date,

                        };

                        var tipofac = new TipoFacturaModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TIPO_FACTURA").Valor ?? 0,
                            Tipo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TIPO_FACT").Valor ?? string.Empty,
                    };
                        int idcliente= reg.FirstOrDefault(m => m.Campo.ToUpper() == "CLIENTE").Valor ?? 0;
                        int idreserva = reg.FirstOrDefault(m => m.Campo.ToUpper() == "RESERVA").Valor ?? 0;
                        model.TipoFactura = tipofac;

                        List<FacturaDetalleModel> detalle = GetFacturaDetalle(model.IdFactura, cmd.Connection, cmd.Transaction);
                        List<FormaPagoModel> forma = GetFormaPago(model.IdFactura, cmd.Connection, cmd.Transaction);

                        model.Cliente.Id_Cliente = idcliente;
                        model.Reserva.IdReserva = idreserva;
                        model.Detalles = detalle;
                        model.Forma = forma;
                        int legajo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "Empleado").Valor ?? 0;
                        model.Empleado.Legajo = legajo;

                        result.Add(model);
                    }
                }

                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
                result = null;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }
        public List<EmpleadoModel> GetEmpleados()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<EmpleadoModel> result = new List<EmpleadoModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "ps_Empleados";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var cliente = new EmpleadoModel()
                        {
                            Apellido = reg.FirstOrDefault(m => m.Campo.ToUpper() == "APELLIDO").Valor ?? string.Empty,
                            Nombre = reg.FirstOrDefault(m => m.Campo.ToUpper() == "NOMBRE").Valor ?? string.Empty,
                            DNI = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DNI").Valor ?? 0,
                            Legajo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "LEGAJO").Valor ?? 0,



                        };
                        cliente.TDoc.Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TIPO_DNI").Valor ?? 0;
                        cliente.TDoc.Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TIPO_DOCUMENTO").Valor ?? string.Empty;
                        result.Add(cliente);
                    }
                }


            }
            catch (Exception)
            {
                result = null;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }
    }
}
