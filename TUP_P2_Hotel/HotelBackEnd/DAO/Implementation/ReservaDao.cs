﻿using HotelBackEnd.DAO.Helper;
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
                    int  idprov= int.Parse(row["ID_PROVINCIAS"].ToString());
                    LocalidadModel p = new LocalidadModel(id, nameLoc,idprov);
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

        
    }
    
}
