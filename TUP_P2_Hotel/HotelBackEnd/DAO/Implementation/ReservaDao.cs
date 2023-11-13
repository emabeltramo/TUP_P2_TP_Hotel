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
    public class ReservaDao : IReservaDao
    {
        private string mensaje = string.Empty;

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

        public string GetMensaje()
        {
            return mensaje;
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
                            Codigo = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CODIGO_HABITACION").Valor ?? string.Empty,
                            Telefono = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TELEFONO").Valor ?? 0,

                        };
                        var categoria = new CatHabitacionModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID_CATEGORIA").Valor ?? 0,
                            Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRIPCION").Valor ?? string.Empty,
                            Precio = reg.FirstOrDefault(m => m.Campo.ToUpper() == "PRECIO").Valor ?? 0,

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
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SELECT * FROM HOTELES ORDER BY 5 ASC ");
                foreach (DataRow row in table.Rows)
                {
                    int idHotel = int.Parse(row["ID"].ToString());
                    string adress = row["DIRECCION"].ToString();
                    string name = row["NOMBRE"].ToString();
                    bool enabled = (bool)row["HABILITADO"];
                    int localidad = int.Parse(row["LOCALIDAD"].ToString());

                    HotelModel lh = new HotelModel(idHotel, adress, name, enabled);
                    lh.Localidad = new LocalidadModel(localidad, "");
                    lstHoteles.Add(lh);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en GetHoteles", ex);
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
                    int idprov = int.Parse(row["ID_PROVINCIAS"].ToString());
                    LocalidadModel p = new LocalidadModel(id, nameLoc, idprov);
                    lstLocalidades.Add(p);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en GetLocalidades", ex);
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

                throw new Exception("Error en GetProvincias", ex);
            }

            return lstProvincias;
        }

        public List<HotelServicioModel> GetServiciosHotel(int idHotel)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<HotelServicioModel> result = new List<HotelServicioModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select HOTEL_SERVICIOS.ID as hs_id,TIPOS_SERVICIOS.ID as ts_id," +
                    "TIPOS_SERVICIOS.DESCRIPCION as ts_desc,PRECIO as hs_precio " +
                    "from HOTEL_SERVICIOS " +
                    "inner join TIPOS_SERVICIOS on HOTEL_SERVICIOS.SERVICIO=TIPOS_SERVICIOS.ID " +
                    "where HOTEL_SERVICIOS.HOTEL=@idHotel";
                cmd.Parameters.Add(new SqlParameter("@idHotel", (object)idHotel));
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var servicio = new HotelServicioModel()
                        {
                            IdServicioHotel = reg.FirstOrDefault(m => m.Campo.ToUpper() == "HS_ID").Valor ?? 0,
                            Precio = reg.FirstOrDefault(m => m.Campo.ToUpper() == "HS_PRECIO").Valor ?? 0
                        };
                        servicio.Servicio = new TipoServicioModel()
                        {
                            Id = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TS_ID").Valor ?? 0,
                            Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "TS_DESC").Valor ?? 0
                        };

                        result.Add(servicio);
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

        public bool PostReserva(ReservaModel reserva)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.Connection.Open();
                t = cmd.Connection.BeginTransaction();
                cmd.Transaction = t;
                SqlParameter p = new SqlParameter("@id", SqlDbType.Int);
                p.Direction = ParameterDirection.Output;
                cmd.CommandText = "ps_InsertReserva";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(p);
                cmd.Parameters.AddWithValue("@cliente", (object)reserva.Cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@ingreso", (object)reserva.Ingreso);
                cmd.Parameters.AddWithValue("@salida", (object)reserva.Salida);
                //cmd.Parameters.AddWithValue("@empleado", (object)reserva.Empleado.Legajo); usar este ; Fuerzo el empleado
                cmd.Parameters.AddWithValue("@empleado", (object)1);

                cmd.ExecuteNonQuery();
                reserva.IdReserva = (int)p.Value;
                foreach (var item in reserva.Habitaciones)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@reserva", (object)reserva.IdReserva);
                    cmd.Parameters.AddWithValue("@habitacion", (object)item.Habitacion.Id_Habitacion);
                    cmd.Parameters.AddWithValue("@monto", (object)item.Monto);
                    cmd.CommandText = "ps_InsertReservaHabitacion";
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        this.mensaje = "No se inserto habitacion en reserva";
                        t.Rollback();
                        cmd.Connection.Close();
                        return false;
                    }
                }
                foreach (var item in reserva.Cuenta)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@reserva", (object)reserva.IdReserva);
                    cmd.Parameters.AddWithValue("@servicio", (object)item.Servicio.Id);
                    cmd.Parameters.AddWithValue("@monto", (object)item.Monto);
                    cmd.Parameters.AddWithValue("@bonificado", (object)item.Bonificado);
                    cmd.Parameters.AddWithValue("@cantidad", (object)item.Cantidad);

                    cmd.CommandText = "ps_InsertReservaCuenta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        this.mensaje = "No se inserto el servicio en reserva";
                        t.Rollback();
                        cmd.Connection.Close();
                        return false;
                    }
                }
                t.Commit();
                result = true;
                mensaje = reserva.IdReserva.ToString();
            }
            catch (Exception ex)
            {

                t.Rollback();
                mensaje = ex.Message;
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            return result;
        }

        public List<EstadoReservaModel> GetEstadosReserva()
        {

            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<EstadoReservaModel> result = new List<EstadoReservaModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select * from ESTADOS_RESERVA";

                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        var model = new EstadoReservaModel()
                        {
                            IdEstadoReserva = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? 0,
                            Descri = reg.FirstOrDefault(m => m.Campo.ToUpper() == "DESCRIPCION").Valor ?? string.Empty
                        };

                        result.Add(model);
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

        public List<ReservaModel> GetReservas(DateTime desde, DateTime hasta, int idHotel)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<ReservaModel> result = new List<ReservaModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "ps_Reservas";
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
                        var model = new ReservaModel()
                        {
                            IdReserva = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID").Valor ?? 0,
                            Ingreso = reg.FirstOrDefault(m => m.Campo.ToUpper() == "INGRESO").Valor ?? DateTime.Now.Date,
                            Salida = reg.FirstOrDefault(m => m.Campo.ToUpper() == "SALIDA").Valor ?? DateTime.Now.Date,
                            Fecha = reg.FirstOrDefault(m => m.Campo.ToUpper() == "FECHA_RESERVA").Valor ?? DateTime.Now.Date,

                        };
                        model.Estado.IdEstadoReserva = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ESTADO").Valor ?? 0;
                        model.Cliente.Id_Cliente= reg.FirstOrDefault(m => m.Campo.ToUpper() == "CLIENTE").Valor ?? 0;
                        model.Empleado.Legajo= reg.FirstOrDefault(m => m.Campo.ToUpper() == "EMPLEADO").Valor ?? 0;


                        result.Add(model);
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

        public List<EmpleadoModel> GetEmpleados()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<EmpleadoModel> result = new List<EmpleadoModel>();
            try
            {
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select legajo,DNI,NOMBRE,APELLIDO,TIPO_DNI,TIPO_DOCUMENTO " +
                    "from EMPLEADO inner join TIPO_DOCUMENTOS on EMPLEADO.TIPO_DNI=TIPO_DOCUMENTOS.ID";
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
