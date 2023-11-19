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
    public partial class frmUpdateReserva : Form
    {
        IFactoryService factory;
        IReservaService service;
        private List<LocalidadModel> localidades;
        private List<HotelModel> hoteles;
        private List<ProvinciaModel> provincias;
        private ReservaModel reserva;
        private HotelModel hotel;


        public frmUpdateReserva(IFactoryService factory, ReservaModel reserva)
        {
            InitializeComponent();
            this.reserva = reserva;
            this.Text = $"Reserva {reserva.IdReserva} || Estado: {reserva.Estado.Descri}";
            hotel = new HotelModel();
            this.factory = factory;
            service = factory.CreateReservaService();

            #region Eventos
            this.Load += FrmUpdateReserva_Load;
            
            #region Btn
            btnBuscar.Click += BtnBuscar_Click;
            btnReiniciar.Click += BtnReiniciar_Click;
            btnCargarReserva.Click += BtnCargarReserva_Click;
            #endregion
            #region Dgv
            dgvNuevaReserva.CellContentClick += DgvNuevaReserva_CellContentClick;
            dgvServicios.CellEndEdit += DgvServicios_CellEndEdit;
            dgvServicios.CellContentClick += DgvServicios_CellContentClick;
            #endregion
            #region Dtp
            dtpDesde.ValueChanged += DtpDesde_ValueChanged;
            dtpHasta.ValueChanged += DtpHasta_ValueChanged;
            #endregion

            
            
            
            #endregion
            #region Configuraciones
            txbCliente.Enabled = false;
            txbHotel.Enabled = false;
            txbNoches.Enabled = false;
            tab.Enabled = false;
            #endregion


        }

        private async void FrmUpdateReserva_Load(object? sender, EventArgs e)
        {
            await InitFrm();
        }

        /*
* Obtener las habitaciones de la reserva
* Obtener las habitaciones disponibles en la fecha indicada, ignorando la reserva actual
* Lllenar dgv, los que estan en la reserva actual marcarlo como reservado
* 
* Obtener los servicios de la reserva
* Obtener los servicios del hotel
* llenar dgv con los datos entrelazados
*/
        private async Task InitFrm()
        {
            await GetHabReserva(); //Habitaciones reservadas
            await GetSrvReserva(); //Servicios Contratados
            await GetHotelReserva();

            txbCliente.Text = reserva.Cliente.NombreCompleto;
            txbHotel.Text = hotel.Nombre;
            dtpDesde.Value = reserva.Ingreso;
            dtpHasta.Value = reserva.Salida;
            dtpDesde.MinDate = DateTime.Now.Date;
            dtpHasta.MinDate = DateTime.Now.AddDays(1).Date;
            btnBuscar.PerformClick();
        }
        private async Task GetHabReserva()
        {

            reserva.Habitaciones = await service.GetReservaHabAsync(reserva.IdReserva);

        }
        private async Task GetSrvReserva()
        {


            reserva.Cuenta = await service.GetReservaCuentaAsync(reserva.IdReserva);

        }
        private async Task GetHotelReserva()
        {
            var hoteles = await service.GetHotelesAsync();
            hotel = hoteles.FirstOrDefault(m => m.IdHotel == reserva.IdHotel) ?? new HotelModel();
        }
        private async Task ServDisponibles(int id)
        {
            List<HotelServicioModel> servicios = await service.
                GetServiciosHotelAsync(id);
            dgvServicios.Rows.Clear();
            foreach (var item in servicios)
            {
                int cantidad = 0;
                bool bonificado = false;
                if (reserva.Cuenta.Exists(m => m.Servicio.Id == item.Servicio.Id))
                {
                    var srv = reserva.Cuenta.FirstOrDefault(m => m.Servicio.Id == item.Servicio.Id);
                    cantidad = srv.Cantidad;
                    bonificado = srv.Bonificado;
                }
                dgvServicios.Rows.Add(new object[]
                {
                    item.Servicio.Id,
                    item.Servicio.Descri,
                    item.Precio,
                    cantidad,
                    bonificado,

                });
            }
        }
        private async Task HabitacionDisponibles(DateTime desde, DateTime hasta, int idHotel, int idReserva)
        {

            List<HabitacionHotelModel> habitaciones = await service.
                GetHabitacionHotelDisponiblesAsync(desde.Date, hasta.Date, idHotel, idReserva);
            dgvNuevaReserva.Rows.Clear();
            foreach (var item in habitaciones)
            {
                bool reservado = false;
                if (reserva.Habitaciones.Exists(m => m.Habitacion.Id_Habitacion == item.Id_Habitacion))
                    reservado = true;
                dgvNuevaReserva.Rows.Add(new object[]
                {
                    item.Id_Habitacion,
                    item.Codigo,
                    item.Categoria.Descri,
                    item.CamaMax,
                    item.Categoria.Precio,
                    reservado
                });
            }
            //cboClienteReserva.DataSource = habitaciones;

        }

        #region Eventos DateTimePicker
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
        #endregion
        #region Eventos DGV
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
                int cantidad = 0;
                int.TryParse(dgvServicios.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString(), out cantidad);
                if (cantidad < 1)
                    dgvServicios.Rows[e.RowIndex].Cells["Cantidad"].Value = 0;
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
        #endregion

        private async void BtnBuscar_Click(object? sender, EventArgs e)
        {
            dgvNuevaReserva.Rows.Clear();
            dgvServicios.Rows.Clear();
            tab.Enabled = true;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            btnCargarReserva.Enabled = true;
            var desde = dtpDesde.Value;
            var hasta = dtpHasta.Value;
            await HabitacionDisponibles(desde, hasta, reserva.IdHotel, reserva.IdReserva);
            await ServDisponibles(hotel.IdHotel);
            Total();

        }
        private void BtnReiniciar_Click(object? sender, EventArgs e)
        {
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;
            btnCargarReserva.Enabled = false;
            tab.Enabled = false;
            dgvNuevaReserva.Rows.Clear();
            dgvServicios.Rows.Clear();
            Total();

        }
        private async void BtnCargarReserva_Click(object? sender, EventArgs e)
        {
            var modelo = reserva;
            modelo.Habitaciones = ReadDgvHabitaciones();
            if (modelo.Habitaciones.Count() == 0)
            {
                MessageBox.Show("No selecciono ninguna habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modelo.Cuenta = ReadDgvServicios();

            
            modelo.Ingreso = dtpDesde.Value.Date;
            modelo.Salida = dtpHasta.Value.Date;
            modelo.Empleado = factory.GetSesion();
            var result = await service.PutReservaAsync(modelo);
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"La reserva se modifico con exito",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Lectura de DGV
        private void Total()
        {
            var srv = ReadDgvServicios();
            var hab = ReadDgvHabitaciones();
            var subTotalSrv = srv.Where(m => !m.Bonificado).Sum(m => m.Cantidad * m.Monto);
            var subTotalHab = hab.Sum(m => m.Monto) * int.Parse(txbNoches.Text);
            txbTotal.Text = $"$ {(subTotalHab + subTotalSrv).ToString("#.##")}";

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
        #endregion
    }
}
