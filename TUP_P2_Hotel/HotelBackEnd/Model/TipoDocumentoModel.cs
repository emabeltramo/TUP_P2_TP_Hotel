using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class TipoDocumentoModel
    {
        public int Id { get; set; }
        public string Descri { get; set; }
    

    public TipoDocumentoModel()
    {
        Id = 0;
        Descri = string.Empty;
    }

    public TipoDocumentoModel(int id, string descri)
    {
        Id = id;
        Descri = descri;
    }
}
}