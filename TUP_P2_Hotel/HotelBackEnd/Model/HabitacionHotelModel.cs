using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class HabitacionHotelModel
    {
        public int Id_Habitacion { get; set; }
        public string Codigo { get; set; }
        public int CamaMax { get; set; }
        public CatHabitacionModel Categoria { get; set; }
        public int Telefono { get; set; }
        public HabitacionHotelModel()
        {
            Categoria = new CatHabitacionModel();
        }
    }

}
