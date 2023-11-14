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

namespace HotelForm.View.Reserva
{
    public partial class frmReservas : Form
    {
        IReservaService service;
        IFactoryService factory;
        private List<ReservaModel> reservas;
        public frmReservas(IFactoryService factory)
        {
            service = factory.CreateReservaService();
            this.factory = factory;
            InitializeComponent();
            InitComponent();
            dtpDesde.ValueChanged += DtpDesde_ValueChanged;
            dtpHasta.ValueChanged += DtpHasta_ValueChanged;
            this.Load += FrmReservas_Load;
            btnFiltrar.Click += BtnFiltrar_Click;
            reservas = new List<ReservaModel>();
            dgvReserva.CellClick += DgvReserva_CellClick;
        }

        private void DgvReserva_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && dgvReserva.Rows[e.RowIndex].Cells["Ver"].ColumnIndex ==e.ColumnIndex)
            {
                var idReserva = int.Parse(dgvReserva.Rows[e.RowIndex].Cells["Reserva"].Value.ToString());
                var reserva = reservas.FirstOrDefault(m => m.IdReserva == idReserva);
                var form = new frmViewReserva(factory, reserva);
                form.ShowDialog();
                btnFiltrar.PerformClick();
            }
        }

        private async void BtnFiltrar_Click(object? sender, EventArgs e)
        {
            var hotel = (HotelModel)cboHotel.SelectedItem;
            var cliente = (ClienteModel)cboCliente.SelectedItem;
            var estado = (EstadoReservaModel)cboEstado.SelectedItem;

            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;
            await Reservas(desde, hasta, hotel.IdHotel, cliente.Id_Cliente, estado.IdEstadoReserva);

        }
        private async Task Reservas(DateTime desde, DateTime hasta, int idHotel, int idCliente, int idEstado)
        {

            List<ReservaModel> reservas = await service.
                GetReservasAsync(desde.Date, hasta.Date, idHotel,idCliente,idEstado);
            dgvReserva.Rows.Clear();
            foreach (var item in reservas)
            {
                dgvReserva.Rows.Add(new object[]
                {
                    item.Cliente.NombreCompleto,
                    item.IdReserva,
                    item.Estado.Descri,
                    item.Ingreso.ToString("dd/MM/yyyy"),
                    item.Salida.ToString("dd/MM/yyyy"),
                    "Ver"
                });
            }
            this.reservas = reservas;
            //cboClienteReserva.DataSource = habitaciones;

        }
        private async void FrmReservas_Load(object? sender, EventArgs e)
        {
            await CargarComboCliente();
            await CargarComboEstados();

            await CargarComboHotel();
        }

        private void InitComponent()
        {
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHotel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpHasta.MinDate = DateTime.Now.Date;
            dtpHasta.Value = DateTime.Now.AddMonths(1).Date;

            cboHotel.DataSource = new List<HotelModel>();
            cboHotel.DisplayMember = "Nombre";
            cboHotel.ValueMember = "IdHotel";

            cboCliente.DataSource = new List<ClienteModel>();
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";

            cboEstado.DataSource = new List<EstadoReservaModel>();
            cboEstado.DisplayMember = "Descri";
            cboEstado.ValueMember = "IdEstadoReserva";
        }
        private void DtpHasta_ValueChanged(object? sender, EventArgs e)
        {
            dtpDesde.MaxDate = dtpHasta.Value;
        }

        private void DtpDesde_ValueChanged(object? sender, EventArgs e)
        {
            dtpHasta.MinDate = dtpDesde.Value.AddDays(1);
        }

        private async Task CargarComboCliente()
        {

            List<ClienteModel> clients = await service.GetClientesAsync();
            clients.Add(new ClienteModel()
            {
                Nombre = "Todos"
            });
            cboCliente.DataSource = clients.OrderBy(m=>m.Id_Cliente).ToList();

        }
        private async Task CargarComboEstados()
        {

            List<EstadoReservaModel> estados = await service.GetEstadosReservaAsync();
            estados.Add(new EstadoReservaModel()
            {
                Descri = "Todos"
            });
            cboEstado.DataSource = estados.OrderBy(m=>m.IdEstadoReserva).ToList();

        }
        private async Task CargarComboHotel()
        {
            var hoteles = await service.GetHotelesAsync();
            hoteles.Add(new HotelModel()
            {
                Nombre = "Todos"
            });
            cboHotel.DataSource = hoteles.OrderBy(m=>m.IdHotel).ToList();
        }
    }
}
