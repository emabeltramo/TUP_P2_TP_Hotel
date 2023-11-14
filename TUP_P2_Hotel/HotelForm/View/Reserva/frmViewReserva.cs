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
    public partial class frmViewReserva : Form
    {
        IFactoryService factory;
        IReservaService service;
        ReservaModel reserva;
        HotelModel hotel;
        public frmViewReserva(IFactoryService factory,ReservaModel reserva)
        {
            InitializeComponent();
            this.factory = factory;
            service = factory.CreateReservaService();
            this.reserva = reserva;
            this.Text = $"Reserva {reserva.IdReserva} || Estado: {reserva.Estado.Descri}";
            hotel = new HotelModel();
            this.Load += FrmViewReserva_Load;
            InitComp();
            btnAnular.Click += BtnAnular_Click;
        }

        private async void BtnAnular_Click(object? sender, EventArgs e)
        {
            if (reserva.Estado.IdEstadoReserva != 3)
            {
                if (MessageBox.Show("Esta seguro que desea anular la reserva?","Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var result = await service.DeleteReservaAsync(reserva.IdReserva);
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show(result.Data,"Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show(result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void FrmViewReserva_Load(object? sender, EventArgs e)
        {
            await ObtenerHotel();
            await ObtenerHabitaciones();
            await ObtenerServicios();
            txbDireccion.Text = hotel.Direccion;
            txbDni.Text = string.IsNullOrEmpty(reserva.Cliente.DNI) ? reserva.Cliente.CUIL:reserva.Cliente.DNI ;
            txbHNombre.Text = hotel.Nombre;
            txbMail.Text = reserva.Cliente.Email;
            txbNombre.Text = string.IsNullOrEmpty(reserva.Cliente.RazonSocial) ? reserva.Cliente.Apellido+ " "+ reserva.Cliente.Nombre: 
                reserva.Cliente.RazonSocial;
            txbTelefono.Text = reserva.Cliente.Celular;
            dtpDesde.Value = reserva.Ingreso;
            dtpHasta.Value = reserva.Salida;

        }
        private void InitComp()
        {
            txbDireccion.ReadOnly = true;
            txbDni.ReadOnly = true;
            txbHNombre.ReadOnly = true;
            txbMail.ReadOnly = true;
            txbNombre.ReadOnly = true;
            txbTelefono.ReadOnly = true;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            if (reserva.Estado.IdEstadoReserva == 3)
            {
                btnAnular.Enabled = false;
            }
        }
        private async Task ObtenerHabitaciones()
        {
            reserva.Habitaciones = await service.GetReservaHabAsync(reserva.IdReserva);
            dgvHabitaciones.Rows.Clear();
            foreach (var item in reserva.Habitaciones)
            {
                dgvHabitaciones.Rows.Add(new object[] { item.Habitacion.Codigo,
                    item.Habitacion.Categoria.Descri,
                    item.Habitacion.CamaMax,
                    item.Monto
                });
            }
            
        }
        private async Task ObtenerServicios()
        {
            reserva.Cuenta = await service.GetReservaCuentaAsync(reserva.IdReserva);
            dgvServicios.Rows.Clear();
            foreach (var item in reserva.Cuenta)
            {
                dgvServicios.Rows.Add(new object[] { item.Servicio.Descri,
                    item.Cantidad,
                    item.Bonificado,
                    item.Monto
                });
            }
        }
        private async Task ObtenerHotel()
        {
            var hoteles = await service.GetHotelesAsync();
            hotel = hoteles.FirstOrDefault(m => m.IdHotel == reserva.IdHotel) ?? new HotelModel();
        }
    }
}
