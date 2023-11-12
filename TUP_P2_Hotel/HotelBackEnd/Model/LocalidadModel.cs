using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class LocalidadModel : ProvinciaModel
    {
        public int Id_Localidad { get; set; }
        public string Descri_Localidad { get; set; }

        public int Id_Provincia { get; set; }

        public LocalidadModel(int id, string nombre, int id_Provincia) : base()
        {
            Id_Localidad = id;
            Descri_Localidad = nombre;
            Id_Provincia = id_Provincia;
        }
        public LocalidadModel(int id, string nombre)
        {
            Id_Localidad = id;
            Descri_Localidad = nombre;
        }
        public LocalidadModel()
        {

        }
    }
}
