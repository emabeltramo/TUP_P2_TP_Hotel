using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ReservaHabitacionModel
    {
        public int IdResHabitacion { get; set; }
        public HabitacionHotelModel Habitacion { get; set; }
        public decimal Monto { get; set; }

        public ReservaHabitacionModel()
        {
            IdResHabitacion = 0;
            Habitacion = new HabitacionHotelModel();
            Monto = 0;
        }
    }
}
