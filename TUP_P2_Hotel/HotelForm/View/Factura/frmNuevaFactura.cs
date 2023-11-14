using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelForm.View.Factura
{
    public partial class frmNuevaFactura : Form
    {
        IFactoryService factory;
        IFacturaService service;
        private FacturaModel nuevaFactura;
        private List<ReservaModel> listaReserva;
        int facturanro;

        //private EmpleadoModel empleado; 
        int legajoempleado;
        public frmNuevaFactura(IFactoryService factory) //tiene que pedir los valores del empleado
        {
            //this.empleado = empleado; 
            this.factory = factory;
            InitializeComponent();
            service = factory.CreateFacturaService();
            InitComp();
            nuevaFactura = new FacturaModel();
            nuevaFactura.Forma = new List<FormaPagoModel>();
            listaReserva = new List<ReservaModel>();
            facturanro = 999;
            this.Load += FrmNuevaFactura_Load;
            legajoempleado = 1;
            btnBuscar.Click += BtnBuscar_Click;
            btnCargar.Click += BtnCargar_Click;
            btnSalir.Click += BtnSalir_Click;
            btnCancelar.Click += BtnCancelar_Click;
            cboReserva.SelectedValueChanged += CboReserva_SelectedValueChanged;
        }

        

        private void InitComp()
        {
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async void BtnCargar_Click(object? sender, EventArgs e)
        {
            if (Validar())
            {
                nuevaFactura.NumFactura = facturanro;
                //nuevaFactura.Cliente = (ClienteModel)cboCliente.SelectedItem;
                nuevaFactura.Fecha = dtpFecha.Value;
                //nuevaFactura.Reserva = (ReservaModel)cboReserva.SelectedItem;
                nuevaFactura.TipoFactura = (TipoFacturaModel)cboTipoFactura.SelectedItem;
                nuevaFactura.Forma.Add((FormaPagoModel)cboFormaPago.SelectedItem);
                nuevaFactura.Empleado.Legajo = legajoempleado;

                var result = await service.AltaFactura(nuevaFactura);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("FACTURA generada con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    ProximoPresupuesto();
                }
                else
                {
                    MessageBox.Show("Error al cargar Factura : " + result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void BtnBuscar_Click(object? sender, EventArgs e)
        {
            if (cboCliente.Text == "CONSUMIDOR FINAL")
            {
                MessageBox.Show("Debe seleccionar un cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClienteModel cliente = (ClienteModel)cboCliente.SelectedItem;
            var reservas = await ObtenerReserva(cliente.Id_Cliente);
            await LlenarReservas(reservas);
            cboReserva.Enabled = true;
            cboReserva.DataSource = reservas;
            cboReserva.DisplayMember = "IdReserva";
            cboReserva.ValueMember = "IdReserva";
        }

        private async void FrmNuevaFactura_Load(object? sender, EventArgs e)
        {
            await CargarCombosAsync();
            Limpiar();
            ProximoPresupuesto();
        }
        private async Task LlenarReservas(List<ReservaModel> Reservas)
        {
            foreach (var Reserva in Reservas)
            {
                var cuenta = await service.GetReservaCuentaAsync(Reserva.IdReserva);
                var habitaciones = await service.GetReservaHabAsync(Reserva.IdReserva);
                Reserva.Cuenta = cuenta;
                Reserva.Habitaciones = habitaciones;
            }
        }
        private async void CboReserva_SelectedValueChanged(object? sender, EventArgs e)
        {
            var item = (ReservaModel)cboReserva.SelectedItem;
            await ObetenerDatosReserva(item);
            CargarTabla();
        }
        private async Task ObetenerDatosReserva(ReservaModel Reserva)
        {
            nuevaFactura.Detalles.Clear();
            dgvDetalles.Rows.Clear();
            
            foreach (var item in Reserva.Cuenta)
            {
                var detalle = new FacturaDetalleModel();
                detalle.Servicio=item.Servicio;
                detalle.Cantidad = item.Cantidad;
                detalle.Monto = item.Bonificado ? 0: item.Monto;
                nuevaFactura.AgregarDetalle(detalle);
                
            }
            var dias = (int)(Reserva.Salida - Reserva.Ingreso).TotalDays;
            var total = dias * Reserva.Habitaciones.Sum(m => m.Monto);
            var detalleHab = new FacturaDetalleModel();
            detalleHab.Servicio = new TipoServicioModel()
            {
                Id = 14,
                Descri = "Alojamiento"
            };
            detalleHab.Cantidad = dias;
            detalleHab.Monto=total;
            nuevaFactura.Reserva = Reserva;
            nuevaFactura.Cliente = Reserva.Cliente;
            nuevaFactura.AgregarDetalle(detalleHab);

            

        }
        private void CargarTabla()
        {
            dgvDetalles.Rows.Clear();
            foreach (var detalle in nuevaFactura.Detalles)
            {
                dgvDetalles.Rows.Add(new object[] { detalle.Servicio.Id,detalle.Servicio.Descri,
                    detalle.Cantidad, detalle.Monto});
            }
            CalcularTotal();

        }
        

        private void Limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            //cboCliente.Text = "CONSUMIDOR FINAL";
            cboCliente.SelectedIndex = 0;
            cboTipoFactura.SelectedIndex = 0;
            cboFormaPago.SelectedIndex = 0;
            //cboReserva.Items.Clear();
            dgvDetalles.Rows.Clear();
            cboReserva.Enabled = false;
            nuevaFactura = new FacturaModel();
            listaReserva = new List<ReservaModel>();
        }

        private async Task CargarCombosAsync()
        {
            cboCliente.DataSource = await service.GetClientesAsync();
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";

            cboTipoFactura.DataSource = await service.GetTipoFacturaAsync();
            cboTipoFactura.DisplayMember = "Tipo";
            cboTipoFactura.ValueMember = "Id";

            cboFormaPago.DataSource = await service.GetFormaPagoAsync();
            cboFormaPago.DisplayMember = "Descripcion";
            cboFormaPago.ValueMember = "Id";

            

            facturanro = await service.GetFacturaNroAsync(facturanro);

            

            //por la falta de empleados se hace esto de momento

            legajoempleado = factory.GetSesion().Legajo;
        }
        private async Task<List<ReservaModel>> ObtenerReserva(int IdCliente)
        {
            List<ReservaModel> comboReserva = await service.GetReservasAsync(IdCliente);
            
            return comboReserva;
        }
        

        

        

        

        private void CalcularTotal()
        {
            decimal total = nuevaFactura.CalcularTotal();
            txtFinal.Text = total.ToString();

            
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void BtnSalir_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        
        private bool Validar()
        {

            if (cboCliente.Text == "CONSUMIDOR FINAL")
            {
                MessageBox.Show("Debe seleccionar un cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboTipoFactura.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un tipo de factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar algun servicio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            ClienteModel cliente = (ClienteModel)cboCliente.SelectedItem;
            ReservaModel reserva = (ReservaModel)cboReserva.SelectedItem;
            if (cliente.Id_Cliente != reserva.Cliente.Id_Cliente)
            {
                MessageBox.Show("El cliente no coincide con el que hizo la reserva!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void ProximoPresupuesto()
        {
            facturanro++;
            if (facturanro > 0)
            {
                lblNroFactura.Text = "Presupuesto Nº: " + facturanro.ToString();
            }

            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        
    }
}
