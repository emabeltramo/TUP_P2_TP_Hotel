using HotelBackEnd.DAO.Helper;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Implementation
{
    public class FacturaDao : IFacturaDao
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

        public int GetFacturaNro()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            int result = 0;
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select TOP 1 N_FACTURA from FACTURAS order by 1 desc";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var reg = procces.MakeReg(reader);

                        result = reg.FirstOrDefault(m => m.Campo.ToUpper() == "N_FACTURA").Valor ?? string.Empty;

                    }
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }

        public List<FormaPagoModel> GetFormaPago()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<FormaPagoModel> result = new List<FormaPagoModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select * from FORMAS_PAGOS";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var FormaPago = new FormaPagoModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? string.Empty,
                            Descripcion = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRICION").Valor ?? string.Empty,
                            Recargo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "RECARGO").Valor ?? string.Empty,
                            Porcentaje = reg.FirstOrDefault(m => m.Campo.ToUpper() == "PORCENTAJE_RECARGO").Valor ?? string.Empty,


                        };
                        result.Add(FormaPago);
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

        public List<ReporteModel> GetReporte(int year)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            var result = new List<ReporteModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "ps_RepClientesFacturado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@year", (object)year));
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var reporte = new ReporteModel()
                        {
                            Posicion = reg.FirstOrDefault(m => m.Campo.ToUpper() == "POSICION").Valor ?? 0,
                            Cliente = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CLIENTE").Valor ?? string.Empty,
                            Promedio = reg.FirstOrDefault(m => m.Campo.ToUpper() == "PROMEDIO").Valor ?? 0,
                            Noches = reg.FirstOrDefault(m => m.Campo.ToUpper() == "NOCHES").Valor ?? 0,
                            Total = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TOTAL").Valor ??0,



                        };
                        result.Add(reporte);
                    }
                }
            }
            catch (Exception ex)
            {
                result = null;
                
            }
            finally
            {
                try
                {
                    if(cmd.Connection.State == ConnectionState.Open)
                        cmd.Connection.Close();
                }
                catch (Exception)
                {

                    
                }
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
                cmd.CommandText = "select * from RESERVAS";
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

        public List<TipoFacturaModel> GetTipoFactura()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<TipoFacturaModel> result = new List<TipoFacturaModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select * from TIPOS_FACTURAS";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var TipoFactura = new TipoFacturaModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? string.Empty,
                            Tipo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TIPO_FACT").Valor ?? string.Empty,


                        };
                        result.Add(TipoFactura);
                    }
                }


            }
            catch (Exception ex)
            {
                result = null;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }

        public List<TipoServicioModel> GetTipoServicio()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<TipoServicioModel> result = new List<TipoServicioModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select * from TIPOS_SERVICIOS";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var TipoServicio = new TipoServicioModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? string.Empty,
                            Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRIPCION").Valor ?? string.Empty,


                        };
                        result.Add(TipoServicio);
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

        public bool SaveFactura(FacturaModel factura)
        {
            bool ok = true;
            SqlConnection cnn = HelperDao.GetInstance().GetConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_INSERTAR_FACTURA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nrofactura", factura.NumFactura);
                cmd.Parameters.AddWithValue("@cliente", factura.Cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@reserva", factura.Reserva.IdReserva);
                cmd.Parameters.AddWithValue("@empleado", factura.Empleado.Legajo);
                cmd.Parameters.AddWithValue("@tipo_fac", factura.TipoFactura.Id);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@factura_nro";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int facturanro = (int)pOut.Value;

                SqlCommand cmdDetalle;
                foreach (FacturaDetalleModel item in factura.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_FACTURA_DETALLES", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@idFactura", facturanro);
                    cmdDetalle.Parameters.AddWithValue("@idServicio", item.Servicio.Id);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@monto", item.Monto);
                    cmdDetalle.ExecuteNonQuery();
                }

                SqlCommand cmdFormaPago;
                foreach (FormaPagoModel item in factura.Forma)
                {
                    cmdFormaPago = new SqlCommand("SP_INSERTAR_FACTURAS_FORMAS_PAGO", cnn, t);
                    cmdFormaPago.CommandType = CommandType.StoredProcedure;
                    cmdFormaPago.Parameters.AddWithValue("@idFactura", facturanro);
                    cmdFormaPago.Parameters.AddWithValue("@idFormaPago", item.Id);
                    cmdFormaPago.ExecuteNonQuery();
                }

                t.Commit();

            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }
    }

}
