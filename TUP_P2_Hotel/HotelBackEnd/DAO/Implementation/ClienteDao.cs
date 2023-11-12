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
            bool ok = true;
            SqlConnection cnn = HelperDao.GetInstance().GetConnection();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_MODIFICAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@tDoc", cliente.TDoc.Id);
                cmd.Parameters.AddWithValue("@dni", cliente.DNI);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@tCliente", cliente.TCliente.Id);
                cmd.Parameters.AddWithValue("@razonSoc", cliente.RazonSocial);
                cmd.ExecuteNonQuery();

               
                
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
                comando.Parameters.AddWithValue("@dni", cliente.DNI);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@tCliente", cliente.TCliente.Id);
                comando.Parameters.AddWithValue("@razonSoc", cliente.RazonSocial);

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
            DataTable tabla = HelperDao.GetInstance().GetConsultSp("SP_CONSULTAR_TIPOCLIENTE", "TIPOS_CLIENTES");
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
            List<TipoDocumentoModel> lTipoDoc = new List<TipoDocumentoModel>();
            DataTable tabla = HelperDao.GetInstance().GetConsultSp("SP_CONSULTAR_TIPODOCUMENTO", "TIPOS_CLIENTES");
            foreach (DataRow r in tabla.Rows)
            {
                int id = Convert.ToInt32(r["ID"].ToString());
                string descripcion = r["TIPO_DOCUMENTO"].ToString();
                TipoDocumentoModel oTipoDoc = new TipoDocumentoModel(id, descripcion);
                lTipoDoc.Add(oTipoDoc);
            }
            return lTipoDoc;
        }


    }
}
