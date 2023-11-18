using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Factura.FacturaView
{
    public partial class FrmViewFactura : Form
    {
        IFactoryService factory;
        IFacturaViewService service;
        FacturaModel factura;
        public FrmViewFactura(IFactoryService factory, FacturaModel factura)
        {
            InitializeComponent();
            this.factura = factura;
            service = factory.CreateFacturaViewService();
            this.Text = $"Factura N° {factura.IdFactura}";
            this.factory = factory;
            InitComp();
        }
        private void InitComp()
        {
            txbNombre.ReadOnly = true;
            txbDni.ReadOnly = true;
            txbMail.ReadOnly = true;
            txbTelefono.ReadOnly = true;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            txtEstado.ReadOnly = true;
            txtIdReserva.ReadOnly = true;
            dtpFecha.Enabled = false;
            txtTipoFactura.ReadOnly = true;
            txtTotal.ReadOnly = true;
        }

        private async void FrmViewFactura_Load(object sender, EventArgs e)
        {
            txbNombre.Text = string.IsNullOrEmpty(factura.Cliente.RazonSocial) ? factura.Cliente.Apellido + " " + factura.Cliente.Nombre : factura.Cliente.RazonSocial;
            txbDni.Text = string.IsNullOrEmpty(factura.Cliente.DNI) ? factura.Cliente.CUIL : factura.Cliente.DNI;
            txbMail.Text = factura.Cliente.Email;
            txbTelefono.Text = factura.Cliente.Celular;
            txtIdReserva.Text = factura.Reserva.IdReserva.ToString();
            txtEstado.Text = factura.Reserva.Estado.Descri;
            dtpDesde.Value = factura.Reserva.Ingreso;
            dtpHasta.Value = factura.Reserva.Salida;
            dtpFecha.Value = factura.Fecha;
            txtTipoFactura.Text = factura.TipoFactura.Tipo;

            await ObtenerFormasPagos();

            cargarDetalle();
        }

        private async Task ObtenerFormasPagos()
        {
            factura.Forma = await service.GetFormasPagoAsync(factura.IdFactura);
            dgvFormaPago.Rows.Clear();
            foreach (var item in factura.Forma)
            {
                dgvFormaPago.Rows.Add(new object[] {item.Descripcion});
            }
        }

        private void cargarDetalle()
        {
            dgvDetalle.Rows.Clear();
            foreach (var item in factura.Detalles)
            {
                dgvDetalle.Rows.Add(new object[]
                {
                    item.IdDetalle,
                    item.Servicio.Descri,
                    item.Cantidad,
                    item.Monto
                });
            }

            txtTotal.Text = factura.CalcularTotal().ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
