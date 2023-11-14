using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class FacturaModel
    {
        public int IdFactura { get; set; }
        public int NumFactura { get; set; }
        public ClienteModel Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public ReservaModel Reserva { get; set; }
        public EmpleadoModel Empleado { get; set; }
        public TipoFacturaModel TipoFactura { get; set; }
        public List<FacturaDetalleModel> Detalles { get; set; }

        public List<FormaPagoModel> Forma { get; set; }

        public FacturaModel()
        {
            Forma = new List<FormaPagoModel>();
            Detalles = new List<FacturaDetalleModel>();
        }
        public void AgregarDetalle(FacturaDetalleModel detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (FacturaDetalleModel item in Detalles)
                total += item.CalcularSubTotal();
            return total;
        }
        public void AgregarFactura(FormaPagoModel formaPago)
        {
            Forma.Add(formaPago);
        }

        public void QuitarFactura(int indice)
        {
            Forma.RemoveAt(indice);
        }
    }
}
