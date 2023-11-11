using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class TipoClienteModel
    {
        public int Id { get; set; }
        public string Descri { get; set; }

        public TipoClienteModel()
        {
            Id = 0;
            Descri = string.Empty;
        }

        public TipoClienteModel(int id,string descripcion)
        {
            Id=id;
            Descri=descripcion;
        }
    }
}
