using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            

        }

        private async void BtnCargarReserva_Click(object? sender, EventArgs e)
        {
            var modelo = new ReservaModel();
            modelo.Habitaciones= ReadDgvHabitaciones();
            if (modelo.Habitaciones.Count() == 0)
            {
                MessageBox.Show("No selecciono ninguna habitacion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            modelo.Cuenta = ReadDgvServicios();
            modelo.Empleado = new EmpleadoModel(); //Agregrar empleado
            modelo.Cliente = (ClienteModel)cboClienteReserva.SelectedItem;
            modelo.Ingreso = dtpDesde.Value.Date;
            modelo.Salida = dtpHasta.Value.Date;
            var result = await service.PostReservaAsync(modelo);
            if (result.SuccessStatus)
            {
                MessageBox.Show("Reserva generada con exito","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (int.Parse(row.Cells["Cantidad"].Value.ToString()) >0)
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
            List<HotelServicioModel> servicios = await service.
                GetServiciosHotelAsync(id);
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

        private void FrmNuevaReserva_Load(object? sender, EventArgs e)
        {
            

            CargarComboCliente();
            ObtenerListas();
            Noches();
            
        }
        private async void CargarComboCliente()
        {
            
            List<ClienteModel> clients = await service.GetClientesAsync();
            cboClienteReserva.DataSource = clients;

        }
        private async void ObtenerListas()
        {
            hoteles = await service.GetHotelesAsync();
            localidades = await service.GetLocalidadAsync();
            provincias = await service.GetProvinciaAsync();
            localidades.RemoveAll(m => !hoteles.Exists(l => 
                l.Localidad.Id_Localidad == m.Id_Localidad));
            provincias.RemoveAll(m => !localidades.Exists(l => l.Id_Provincia == m.Id_Provincia));
            cboProvincia.DataSource = provincias;
        }

        private async Task HabitacionDisponibles(DateTime desde,DateTime hasta, int id)
        {

            List<HabitacionHotelModel> habitaciones = await service.
                GetHabitacionHotelDisponiblesAsync(desde.Date,hasta.Date,id);
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
                    false,
                });
            }
            //cboClienteReserva.DataSource = habitaciones;

        }
        private void btnSalirReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
