using HotelBackEnd.DAO.Helper;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Implementation
{
    internal class ReservaDao : IReservaDao
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
                if(reader.HasRows)
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

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateTime desde, DateTime hasta, int idHotel)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<HabitacionHotelModel> result = new List<HabitacionHotelModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "ps_HabDisponibles";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                var p = new List<SqlParameter>();
                p.Add(new SqlParameter("@desde", (object)desde ?? DBNull.Value));
                p.Add(new SqlParameter("@hasta", (object)hasta ?? DBNull.Value));
                p.Add(new SqlParameter("@hotel", (object)idHotel ?? DBNull.Value));
                cmd.Parameters.AddRange(p.ToArray());
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var habitacion = new HabitacionHotelModel()
                        {
                            Id_Habitacion = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID_HABITACION").Valor ?? 0,
                            CamaMax = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CAMA_MAX").Valor ?? 0,
                            Codigo= reg.FirstOrDefault(m => m.Campo.ToUpper() == "CODIGO_HABITACION").Valor ?? string.Empty,
                            Telefono= reg.FirstOrDefault(m => m.Campo.ToUpper() == "TELEFONO").Valor ?? 0,
                            
                        };
                        var categoria = new CatHabitacionModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID_CATEGORIA").Valor ?? 0,
                            Descri= reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRIPCION").Valor ?? string.Empty,
                            Precio= reg.FirstOrDefault(m => m.Campo.ToUpper() == "PRECIO").Valor ?? 0,

                        };
                        habitacion.Categoria = categoria;
                        result.Add(habitacion);
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

        public List<HotelModel> GetHoteles()
        {
            List<HotelModel> lstHoteles = new List<HotelModel>();
            DataTable table = HelperDao.GetInstance().GetConsult("SELECT * FROM HOTELES ORDER BY 5 ASC ");
            foreach (DataRow row in table.Rows)
            {
                int idhotel = int.Parse(row["ID"].ToString());
                string adress = row["DIRECCION"].ToString();
                string name = row["NOMBRE"].ToString();
                bool enabled = (bool)row["HABILITADO"];
                HotelModel lh = new HotelModel(idhotel,adress,name,enabled);
                lstHoteles.Add(lh);
            }
            return lstHoteles;
        }

        public List<LocalidadModel> GetLocalidades()
        {
            List<LocalidadModel> lstLocalidades = new List<LocalidadModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SELECT * FROM LOCALIDADES ORDER BY 2 ");
                foreach (DataRow row in table.Rows)
                {
                    int id = int.Parse(row["ID_LOCALIDAD"].ToString());
                    string nameLoc = row["NOMBRE"].ToString();
                    LocalidadModel p = new LocalidadModel(id, nameLoc);
                    lstLocalidades.Add(p);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error en GetLocalidades: {ex.Message}");
            }
            
            return lstLocalidades;
        }

        public List<ProvinciaModel> GetProvincias()
        {
            List<ProvinciaModel> lstProvincias = new List<ProvinciaModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SELECT * FROM PROVINCIAS ORDER BY 2 ");
                foreach (DataRow row in table.Rows)
                {
                    int id = int.Parse(row["ID_PROVINCIAS"].ToString());
                    string nameProv = row["NOMBRE"].ToString();
                    ProvinciaModel p = new ProvinciaModel(id, nameProv);
                    lstProvincias.Add(p);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error en GetProvincia: {ex.Message}");
            }
            
            return lstProvincias;
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

        public bool CrearFactura(FacturaModel factura)
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
            catch (Exception)
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

        public int GetLegajoEmpleado()//por el momento
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            int result = 0;
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select TOP 1 LEGAJO from EMPLEADO";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var reg = procces.MakeReg(reader);

                        result = reg.FirstOrDefault(m => m.Campo.ToUpper() == "LEGAJO").Valor ?? string.Empty;

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
    }
    }
    

