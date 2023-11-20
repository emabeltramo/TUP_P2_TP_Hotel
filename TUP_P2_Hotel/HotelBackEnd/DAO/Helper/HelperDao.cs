using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace HotelBackEnd.DAO.Helper
{
    public class HelperDao
    {
        private SqlConnection connection;
        private string stringConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=HOTEL_DB;Integrated Security=True;Encrypt=False";
        //private string stringConexion = "Data Source=172.16.10.196;Initial Catalog=HOTEL_DB;User ID=alumno1w1;Password=alumno1w1";
        private static HelperDao instance;

        private HelperDao()
        {
            connection = new SqlConnection(stringConexion);
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            return this.connection;
        }

        private void Connect()
        {
            connection.Open();
        }

        private void Disconect()
        {
            connection.Close();
        }

        public int GetScalar(string sentencia, string nomParam)
        {
            int aux = 0;
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sentencia;
            SqlParameter param = new SqlParameter(nomParam, SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            Disconect();
            aux = (int)param.Value;
            return aux;
        }

        internal DataTable GetConsult(string consulta)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            connection.Close();
            return tabla;
        }
        public DataTable GetConsultSp(string nombreSp, string nomTabla)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSp;
            cmd.Parameters.AddWithValue("@tabla", nomTabla);
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            connection.Close();
            return tabla;
        } 
        public DataTable GetSPP(string nombreSp, int numero)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSp;
            cmd.Parameters.AddWithValue("@id", numero);
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            connection.Close();
            return tabla;
        }
        public bool VerificarClienteExistente(int clienteId)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VERIFICAR_CLIENTE_EXISTENTE";
            cmd.Parameters.AddWithValue("@ClienteID", clienteId);
            cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            bool resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);

            connection.Close();

            return resultado;
        }
        public DataTable GetSp(string nombreSp)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSp;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            connection.Close();
            return tabla;
        }
    
    }
}
