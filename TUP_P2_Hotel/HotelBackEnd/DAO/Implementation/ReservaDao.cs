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
                            Id_Cliente = reg.FirstOrDefault(m => m.Campo.ToUpper() == "ID_CLIENTE").Valor ?? 0,
                            CUIL = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CUIL").Valor ?? string.Empty,
                            Email = reg.FirstOrDefault(m => m.Campo.ToUpper() == "EMAIL").Valor ?? string.Empty,
                            Celular = reg.FirstOrDefault(m => m.Campo.ToUpper() == "CELULAR").Valor ?? string.Empty,
                            RazonSocial = reg.FirstOrDefault(m => m.Campo.ToUpper() == "RAZONSOCIAL").Valor ?? string.Empty,



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

        public List<HabitacionHotelModel> GetHabitacionHotelDisponibles(DateOnly desde, DateOnly hasta, int idHotel)
        {
            throw new NotImplementedException();
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
                    LocalidadModel localidad = new LocalidadModel(id, nameLoc);
                    lstLocalidades.Add(localidad);
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
                
                Console.WriteLine($"Error en GetProvincias: {ex.Message}");
            }

            return lstProvincias;
        }

        List<ClienteModel> IReservaDao.GetClientes()
        {
            throw new NotImplementedException();
        }

        List<HabitacionHotelModel> IReservaDao.GetHabitacionHotelDisponibles(DateOnly desde, DateOnly hasta, int idHotel)
        {
            throw new NotImplementedException();
        }

        List<HotelModel> IReservaDao.GetHoteles()
        {
            throw new NotImplementedException();
        }

        List<LocalidadModel> IReservaDao.GetLocalidad()
        {
            throw new NotImplementedException();
        }

        List<ProvinciaModel> IReservaDao.GetProvincia()
        {
            throw new NotImplementedException();
        }
    }
    
}
