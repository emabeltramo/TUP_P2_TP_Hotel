using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class LocalidadModel : ProvinciaModel
    {
        public LocalidadModel(int id, string nombre) : base()
        {
            Id_Localidad = id;
            Descri_Localidad= nombre;
        }

        public int Id_Localidad { get; set; }
        public string Descri_Localidad { get; set; }
       
    }
}
