using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Reserva
{
    public partial class frmNuevaReserva : Form
    {
        IFactoryService factory;
        IReservaService service;
        private List<LocalidadModel> localidades;
        private List<HotelModel> hoteles;
        private List<ProvinciaModel> provincias;


        public frmNuevaReserva(IFactoryService factory)
        {
            this.factory = factory;
            service = factory.CreateReservaService();
            InitializeComponent();
            this.Load += FrmNuevaReserva_Load;
            InitComponent();
            btnBuscar.Click += BtnBuscar_Click;
            btnReiniciar.Click += BtnReiniciar_Click;
            btnCargarReserva.Click += BtnCargarReserva_Click;
            dtpDesde.ValueChanged += DtpDesde_ValueChanged;
            dtpHasta.ValueChanged += DtpHasta_ValueChanged;
            cboProvincia.SelectedValueChanged += CboProvincia_SelectedValueChanged;
            cboLocalidad.SelectedValueChanged += CboLocalidad_SelectedValueChanged;

            dgvNuevaReserva.CellContentClick += DgvNuevaReserva_CellContentClick;
            dgvServicios.CellEndEdit += DgvServicios_CellEndEdit;
            dgvServicios.CellContentClick += DgvServicios_CellContentClick;
        }
        private void Total()
        {
            var srv = ReadDgvServicios();
            var hab = ReadDgvHabitaciones();
            var subTotalSrv = srv.Where(m => !m.Bonificado).Sum(m => m.Cantidad * m.Monto);
            var subTotalHab = hab.Sum(m => m.Monto) * int.Parse(txbNoches.Text);
            txbTotal.Text = $"$ {(subTotalHab + subTotalSrv).ToString("#.##")}";

        }
        private void DgvServicios_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvServicios.Rows[e.RowIndex].Cells["Bonificado"].ColumnIndex == e.ColumnIndex)
            {

                dgvServicios.Rows[e.RowIndex].Cells["Bonificado"].Value = !(bool)dgvServicios.Rows[e.RowIndex].Cells["Bonificado"].Value;
                Total();
            }
        }

        private void DgvServicios_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvServicios.Rows[e.RowIndex].Cells["Cantidad"].ColumnIndex == e.ColumnIndex)
            {
                Total();
            }
        }

        private void DgvNuevaReserva_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && dgvNuevaReserva.Rows[e.RowIndex].Cells["Reservar"].ColumnIndex == e.ColumnIndex)
            {

                dgvNuevaReserva.Rows[e.RowIndex].Cells["Reservar"].Value = !(bool)dgvNuevaReserva.Rows[e.RowIndex].Cells["Reservar"].Value;
                //var valor=(decimal)dgvNuevaReserva.Rows[e.RowIndex].Cells["Precio"].Value;
                //var reservar = (bool)dgvNuevaReserva.Rows[e.RowIndex].Cells["Reservar"].Value;
                //if (reservar)
                //{
                //    totelHab += int.Parse(txbNoches.Text) * valor;
                //}
                //else
                //{
                //    totelHab -= int.Parse(txbNoches.Text) * valor;
                //}
                Total();
            }
        }

        private async void BtnCargarReserva_Click(object? sender, EventArgs e)
        {
            var modelo = new ReservaModel();
            modelo.Habitaciones = ReadDgvHabitaciones();
            if (modelo.Habitaciones.Count() == 0)
            {
                MessageBox.Show("No selecciono ninguna habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modelo.Cuenta = ReadDgvServicios();
            modelo.Empleado = new EmpleadoModel(); //Agregrar empleado
            modelo.Cliente = (ClienteModel)cboClienteReserva.SelectedItem;
            //modelo.Ingreso = dtpDesde.Value.Date;
            //modelo.Salida = dtpHasta.Value.Date;
            //var result = await service.PostReservaAsync(modelo);
            //if (result.StatusCode == System.Net.HttpStatusCode.Created)
            //{
            //    MessageBox.Show($"Reserva generada con exito\nNumero:{result.Data}",
            //        "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    btnReiniciar.PerformClick();
            //}
            //else
            //{
            //    MessageBox.Show(result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private List<ReservaHabitacionModel> ReadDgvHabitaciones()
        {
            var resutlt = new List<ReservaHabitacionModel>();
            foreach (DataGridViewRow row in dgvNuevaReserva.Rows)
            {
                if ((bool)row.Cells["Reservar"].Value)
                {
                    var model = new ReservaHabitacionModel();
                    model.Habitacion = new HabitacionHotelModel()
                    {
                        Id_Habitacion = (int)row.Cells["Id"].Value,

                    };
                    model.Monto = (decimal)row.Cells["Precio"].Value;
                    resutlt.Add(model);
                }

            }
            return resutlt;
        }
        private List<ReservaCuentaModel> ReadDgvServicios()
        {
            var resutlt = new List<ReservaCuentaModel>();
            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                if (int.Parse(row.Cells["Cantidad"].Value.ToString()) > 0)
                {
                    var model = new ReservaCuentaModel();
                    model.Servicio = new TipoServicioModel()
                    {
                        Id = (int)row.Cells["IdSrv"].Value,
                    };
                    model.Monto = (decimal)row.Cells["PrecioSrv"].Value;
                    model.Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    model.Bonificado = (bool)row.Cells["Bonificado"].Value;


                    resutlt.Add(model);
                }

            }
            return resutlt;
        }
        private void BtnReiniciar_Click(object? sender, EventArgs e)
        {
            gbFechas.Enabled = true;
            gbHotel.Enabled = true;
            btnCargarReserva.Enabled = false;
            tab.Enabled = false;
            dgvNuevaReserva.Rows.Clear();
            dgvServicios.Rows.Clear();
            Total();

        }

        private async void BtnBuscar_Click(object? sender, EventArgs e)
        {
            dgvNuevaReserva.Rows.Clear();
            dgvServicios.Rows.Clear();
            tab.Enabled = true;
            gbFechas.Enabled = false;
            gbHotel.Enabled = false;
            btnCargarReserva.Enabled = true;
            var hotel = (HotelModel)cboHotel.SelectedItem;
            var desde = dtpDesde.Value;
            var hasta = dtpHasta.Value;
            await HabitacionDisponibles(desde, hasta, hotel.IdHotel);
            ServDisponibles(hotel.IdHotel);

        }

        private async void ServDisponibles(int id)
        {
            List<HotelServicioModel> servicios = await service.GetServiciosHotelAsync(id);
            dgvServicios.Rows.Clear();
            foreach (var item in servicios)
            {
                dgvServicios.Rows.Add(new object[]
                {
                    item.Servicio.Id,
                    item.Servicio.Descri,
                    item.Precio,
                    0,
                    false,

                });
            }
        }

        private void CboLocalidad_SelectedValueChanged(object? sender, EventArgs e)
        {
            var item = (LocalidadModel)cboLocalidad.SelectedItem;
            cboHotel.DataSource = hoteles.Where
                (m => m.Localidad.Id_Localidad == item.Id_Localidad).ToList();
        }

        private void CboProvincia_SelectedValueChanged(object? sender, EventArgs e)
        {
            var item = (ProvinciaModel)cboProvincia.SelectedItem;
            cboLocalidad.DataSource = localidades.Where
                (m => m.Id_Provincia == item.Id_Provincia).ToList();
        }

        private void InitComponent()
        {
            #region DataPicker
            dtpDesde.MinDate = DateTime.Now.Date;
            dtpHasta.MinDate = DateTime.Now.AddDays(1).Date;
            dtpHasta.Value = DateTime.Now.AddMonths(1).Date;
            #endregion
            #region Combos
            cboClienteReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHotel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cboClienteReserva.DataSource = new List<ClienteModel>();
            cboClienteReserva.DisplayMember = "NombreCompleto";
            cboClienteReserva.ValueMember = "Id_Cliente";

            cboProvincia.DataSource = new List<ProvinciaModel>();
            cboProvincia.DisplayMember = "Descri_Prov";
            cboProvincia.ValueMember = "Id_Provincia";

            cboHotel.DataSource = new List<HotelModel>();
            cboHotel.DisplayMember = "Nombre";
            cboHotel.ValueMember = "IdHotel";

            cboLocalidad.DataSource = new List<LocalidadModel>();
            cboLocalidad.DisplayMember = "Descri_Localidad";
            cboLocalidad.ValueMember = "Id_Localidad";
            #endregion
            #region DGV


            #endregion
            #region Tab
            tab.Enabled = false;
            #endregion
        }
        private void DtpHasta_ValueChanged(object? sender, EventArgs e)
        {

            dtpDesde.MaxDate = dtpHasta.Value;

            Noches();

        }

        private void DtpDesde_ValueChanged(object? sender, EventArgs e)
        {

            dtpHasta.MinDate = dtpDesde.Value.AddDays(1);
            Noches();


        }
        private void Noches()
        {
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;
            txbNoches.Text = ((int)(hasta - desde).TotalDays).ToString();
        }

        private async void FrmNuevaReserva_Load(object? sender, EventArgs e)
        {


            await CargarComboCliente();
            await ObtenerListas();
            Noches();

        }
        private async Task CargarComboCliente()
        {

            List<ClienteModel> clients = await service.GetClientesAsync();
            cboClienteReserva.DataSource = clients;

        }
        private async Task ObtenerListas()
        {
            hoteles = await service.GetHotelesAsync();
            localidades = await service.GetLocalidadAsync();
            provincias = await service.GetProvinciaAsync();
            localidades.RemoveAll(m => !hoteles.Exists(l =>
                l.Localidad.Id_Localidad == m.Id_Localidad));
            provincias.RemoveAll(m => !localidades.Exists(l => l.Id_Provincia == m.Id_Provincia));
            cboProvincia.DataSource = provincias;
        }

        private async Task HabitacionDisponibles(DateTime desde, DateTime hasta, int id)
        {

            List<HabitacionHotelModel> habitaciones = await service.
                GetHabitacionHotelDisponiblesAsync(desde.Date, hasta.Date, id);
            dgvNuevaReserva.Rows.Clear();
            foreach (var item in habitaciones)
            {
                dgvNuevaReserva.Rows.Add(new object[]
                {
                    item.Id_Habitacion,
                    item.Codigo,
                    item.Categoria.Descri,
                    item.CamaMax,
                    item.Categoria.Precio,
                    false
                });
            }
            //cboClienteReserva.DataSource = habitaciones;

        }
        private void btnSalirReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevaReserva_Load_1(object sender, EventArgs e)
        {

        }
    }
}
