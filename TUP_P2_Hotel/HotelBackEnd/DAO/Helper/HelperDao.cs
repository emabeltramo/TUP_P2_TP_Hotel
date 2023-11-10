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
        private string stringConexion = "Data Source=DESKTOP-BNJA18M;Initial Catalog = HOTEL_DB;Integrated Security = True";
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

        internal DataTable GetConsult(string nombreSP)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            connection.Close();
            return tabla;
        }

        //internal DataTable Consultar(string nombreSP, List<Parametro> lParams)
        //{
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = conexion;
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.CommandText = nombreSP;
        //    foreach (Parametro p in lParams)
        //    {
        //        comando.Parameters.AddWithValue(p.Nombre, p.Valor);
        //    }
        //    DataTable tabla = new DataTable();
        //    tabla.Load(comando.ExecuteReader());
        //    conexion.Close();
        //    return tabla;
        //}
    }
}
