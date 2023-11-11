using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class HotelModel
    {
        public HotelModel(int idHotel, string direccion, string nombre, bool habilitado)
        {
            IdHotel = idHotel;
            Direccion = direccion;
            Nombre = nombre;
            Habilitado = habilitado;
        }

        public int IdHotel { get; set; }
        public string Direccion { get; set; }
        public LocalidadModel Localidad { get; set; }
        public TipoCategoriaHotelModel Categoria { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public List<HotelServicioModel> Servicios { get; set; }
        public List<HotelPisoModel> Pisos { get; set; }
        public List<HotelContactoModel> Contactos { get; set; }

    }
}
