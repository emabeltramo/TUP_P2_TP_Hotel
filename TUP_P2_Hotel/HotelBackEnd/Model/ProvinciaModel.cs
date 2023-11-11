using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ProvinciaModel : PaisModel
    {
        public int Id_Provincia { get; set; }
        public string Descri_Prov { get; set; }

        public ProvinciaModel(int id, string nombre)
        {
                Id_Provincia=id;
                Descri_Prov=nombre;
        }
        public ProvinciaModel()
        {
                
        }
    }
}
