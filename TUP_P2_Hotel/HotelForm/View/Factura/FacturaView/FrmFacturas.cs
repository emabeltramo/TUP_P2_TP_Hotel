using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using HotelForm.View.Reserva;
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
    public partial class FrmFacturas : Form
    {
        IFacturaViewService service;
        IFactoryService factory;
        private List<FacturaModel> facturas;
        public FrmFacturas(IFactoryService factory)
        {
            InitializeComponent();
            service = factory.CreateFacturaViewService();
            this.factory = factory;

            //dtpDesde.ValueChanged += DtpDesde_ValueChanged;
            //dtpHasta.ValueChanged += DtpHasta_ValueChanged;
            //this.Load += FrmFacturas_Load;
            //btnFiltrar.Click += btnFiltrar_Click;
            //facturas = new List<FacturaModel>();
            //dgvFacturas.CellClick += dgvFacturas_CellContentClick;
        }

        private async void FrmFacturas_Load(object sender, EventArgs e)
        {
            await CargarComboCliente();
        }


        private async Task CargarComboCliente()
        {
            List<ClienteModel> clients = await service.GetClientesAsync();
            clients.Add(new ClienteModel()
            {
                Id_Cliente = 0,
                Nombre = "Todos"
            });
            cboCliente.DataSource = clients.OrderBy(m => m.Id_Cliente).ToList();
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";
        }

        private async void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteModel cliente = (ClienteModel)cboCliente.SelectedItem;
            List<ReservaModel> reserva = await service.GetReservasAsync(cliente.Id_Cliente);
            //await LlenarReservas(reservas);

            EstadoReservaModel estado = new EstadoReservaModel();
            estado.Descri = "TODOS";
            reserva.Add(new ReservaModel()
            {
                IdReserva = 0,
                Estado = estado
            });

            cboReserva.DataSource = reserva.OrderBy(m => m.IdReserva).ToList();
            if (cboReserva.Enabled == false)
            {
                cboReserva.Enabled = true;
            }
            cboReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReserva.DisplayMember = "MostrarReserva";
            cboReserva.ValueMember = "IdReserva";
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            var cliente = (ClienteModel)cboCliente.SelectedItem;
            var reserva = (ReservaModel)cboReserva.SelectedItem;

            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;
            await Reservas(desde, hasta, cliente.Id_Cliente, reserva.IdReserva);
        }
        private async Task Reservas(DateTime desde, DateTime hasta, int idCliente, int idReserva)
        {
            dgvFacturas.Rows.Clear();
            List<FacturaModel> facturas = await service.GetFacturasAsync(desde.Date, hasta.Date, idCliente, idReserva);
            List<FacturaDetalleModel> detalle = await service.GetFacturaDetalle();
            //foreach (var item in facturas)
            for (int i = 0; i < facturas.Count; i++)
            {
                for(int j = 0; j < detalle.Count; j++)
                {
                    if (facturas[i].IdFactura == detalle[j].idFactura)
                    {
                        facturas[i].AgregarDetalle(detalle[j]);
                    }
                }
            }
            foreach (var item in facturas) { 
                dgvFacturas.Rows.Add(new object[]
                {
                    item.IdFactura,
                    item.Cliente.NombreCompleto,
                    item.NumFactura,
                    item.Fecha.ToString("dd/MM/yyyy"),
                    item.TipoFactura.Tipo,
                    item.CalcularTotal(),
                    "Ver"
                });
            }
            this.facturas = facturas;
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFacturas.Rows[e.RowIndex].Cells["Colver"].ColumnIndex == e.ColumnIndex)
            {
                var idFactura = int.Parse(dgvFacturas.Rows[e.RowIndex].Cells["IdCol"].Value.ToString());
                var factura = facturas.FirstOrDefault(m => m.IdFactura == idFactura);
                var form = new FrmViewFactura(factory, factura);
                form.ShowDialog();
                btnFiltrar.PerformClick();
            }
        }


        private void DtpHasta_ValueChanged(object? sender, EventArgs e)
        {
            dtpDesde.MaxDate = dtpHasta.Value;
        }

        private void DtpDesde_ValueChanged(object? sender, EventArgs e)
        {
            dtpHasta.MinDate = dtpDesde.Value.AddDays(1);
        }
    }
}
