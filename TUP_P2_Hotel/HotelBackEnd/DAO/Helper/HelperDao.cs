using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using HotelBackEnd.Model;

namespace HotelBackEnd.DAO.Helper
{
    public class HelperDao
    {
        private SqlConnection connection;
        //private string stringConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=HOTEL_DB;Integrated Security=True";
        private string stringConexion = "Data Source=DESKTOP-6KIGGOG\\MSSQLSERVER01;Initial Catalog=HOTEL_DB;Integrated Security=True"; //Claudio
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
        public DataTable Consultar(string nombreSP, List<Parametro> parametros)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Name, p.Value);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            connection.Close();
            return tabla;
        }
    }
}
