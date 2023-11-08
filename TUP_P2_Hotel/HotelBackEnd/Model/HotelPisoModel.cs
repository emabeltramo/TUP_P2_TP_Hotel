using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class HotelPisoModel
    {
        public int IdPiso { get; set; }
        public int Nivel { get; set; }
        public string Codigo { get; set; }
        public string Descri { get; set; }
        public List<HabitacionHotelModel> Habitaciones { get; set; }
    }
}
