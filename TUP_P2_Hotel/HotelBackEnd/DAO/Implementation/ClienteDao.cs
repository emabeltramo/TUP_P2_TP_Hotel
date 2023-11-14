using HotelBackEnd.DAO.Helper;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Implementation
{
    public class ClienteDao : IClienteDao
    {
        public bool ActualizarCliente(ClienteModel cliente)
        {
            SqlConnection conexion = null;
            SqlTransaction t = null;
            bool resultado = true;

            try
            {
                conexion = HelperDao.GetInstance().GetConnection();
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand("SP_MODIFICAR_CLIENTE", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", cliente.Id_Cliente);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@tDoc", cliente.TDoc.Id);
                comando.Parameters.AddWithValue("@cuil", cliente.CUIL);
                comando.Parameters.AddWithValue("@dni", cliente.DNI);
                comando.Parameters.AddWithValue("@celular", cliente.Celular);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@tCliente", cliente.TCliente.Id);
                comando.Parameters.AddWithValue("@razonSoc", cliente.RazonSocial);

                comando.ExecuteNonQuery();

                t.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar SP_MODIFICAR_CLIENTE: {ex.Message}");
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }


        public bool AltaCliente(ClienteModel cliente)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.GetInstance().GetConnection();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_CLIENTE", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@tDoc", cliente.TDoc.Id);
                comando.Parameters.AddWithValue("@cuil", cliente.CUIL);
                comando.Parameters.AddWithValue("@dni", cliente.DNI);
                comando.Parameters.AddWithValue("@celular", cliente.Celular);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@tCliente", cliente.TCliente.Id);
                comando.Parameters.AddWithValue("@razonSoc", cliente.RazonSocial);

                comando.ExecuteNonQuery();

                t.Commit();
                resultado = true;
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }


        public bool BajaCliente(int numero)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.GetInstance().GetConnection();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_BORRAR_CLIENTE", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", numero);

                comando.ExecuteNonQuery();

                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

      
            public List<TipoClienteModel> GetTipoCliente()
            {
                List<TipoClienteModel> lTipoClientes = new List<TipoClienteModel>();

                DataTable tabla = HelperDao.GetInstance().GetConsult("SELECT * FROM TIPOS_CLIENTES ORDER BY 2");
                foreach (DataRow r in tabla.Rows)
                {
                    int id = Convert.ToInt32(r["ID"].ToString());
                    string descripcion = r["Descripcion"].ToString();
                    TipoClienteModel oTipoCliente = new TipoClienteModel(id, descripcion);
                    lTipoClientes.Add(oTipoCliente);
                }
                return lTipoClientes;
            }
        

        public List<TipoDocumentoModel> GetTipoDocumento()
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            List<TipoDocumentoModel> result = new List<TipoDocumentoModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("SELECT * FROM TIPO_DOCUMENTOS ORDER BY 2");
                foreach (DataRow row in table.Rows)
                {
                    int id = int.Parse(row["ID"].ToString());
                    string Descri = row["TIPO_DOCUMENTO"].ToString();
                    TipoDocumentoModel p = new TipoDocumentoModel(id, Descri);
                    result.Add(p);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en GetTiposDocumento", ex);
            }

            return result;
        }

        public List<ClienteModel> GetClientes()
        {
                ProccesData procces = new ProccesData();
                SqlCommand cmd = new SqlCommand();
                List<ClienteModel> result = new List<ClienteModel>();
                try
                {
                    cmd.Connection = HelperDao.GetInstance().GetConnection();
                    cmd.CommandText = "select * from clientes order by apellido,nombre";
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

        public ClienteModel GetClienteID(int id)
        {
            ProccesData procces = new ProccesData();
            SqlCommand cmd = new SqlCommand();
            ClienteModel result = null; // Inicializar la variable result como nula
            try
            {
                string ID = id.ToString();
                cmd.Connection = HelperDao.GetInstance().GetConnection();
                cmd.CommandText = "select * from clientes where id=" + ID + " order by apellido,nombre";
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = procces.MakeReg(reader);
                        result = new ClienteModel()
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
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, puedes imprimir el mensaje de error o lanzar una excepción, según tus necesidades.
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return result;
        }

    }
     
         
        }
    



    



    

