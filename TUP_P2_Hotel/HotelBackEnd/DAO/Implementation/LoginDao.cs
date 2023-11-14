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

    public class LoginDao : ILoginDao
    {
        private string mensaje = string.Empty;

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
