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
using System.Text;
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
            nuevaFactura = new FacturaModel();
            nuevaFactura.Forma = new List<FormaPagoModel>();
            listaReserva = new List<ReservaModel>();
            facturanro = 999;

            legajoempleado = 1;
        }

        private void frmNuevaFactura_Load(object sender, EventArgs e)
        {
            CargarCombosAsync();
            Limpiar();
            ProximoPresupuesto();
        }

        private void Limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            cboCliente.Text = "CONSUMIDOR FINAL";
            cboCliente.SelectedIndex = -1;
            cboTipoFactura.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            cboReserva.Items.Clear();
            cboServicio.SelectedIndex = -1;
            txtCantidad.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtTotal.Text = string.Empty;
            dgvDetalles.Rows.Clear();
            dgvFormasPago.Rows.Clear();
            cboReserva.Enabled = false;
            nuevaFactura = new FacturaModel();
            listaReserva = new List<ReservaModel>();
        }

        private async void CargarCombosAsync()
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

            cboServicio.DataSource = await service.GetTipoServicioAsync();
            cboServicio.DisplayMember = "Descri";
            cboServicio.ValueMember = "Id";

            facturanro = await service.GetFacturaNroAsync(facturanro);

            listaReserva = await service.GetReservaAsync();

            //por la falta de empleados se hace esto de momento

            legajoempleado = factory.GetSesion().Legajo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboCliente.Text == "CONSUMIDOR FINAL")
            {
                MessageBox.Show("Debe seleccionar un cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClienteModel cliente = (ClienteModel)cboCliente.SelectedItem;
            List<ReservaModel> comboReserva = new List<ReservaModel>();

            foreach (ReservaModel reserva in listaReserva)
            {
                if (reserva.Cliente.Id_Cliente == cliente.Id_Cliente && reserva.Estado.IdEstadoReserva != 3)
                {
                    comboReserva.Add(reserva);
                }
            }
            if (comboReserva.Count > 0)
            {
                cboReserva.Enabled = true;
                cboReserva.DataSource = comboReserva;
                cboReserva.DisplayMember = "FechasAlquiladas";
                cboReserva.ValueMember = "IdReserva";
            }
            else
            {
                MessageBox.Show("No se encontro ninguna Reserva del Cliente seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAgregarFormaPago_Click(object sender, EventArgs e)
        {
            if (cboFormaPago.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una FORMA de PAGO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvFormasPago.Rows)
            {
                if (row.Cells["colFormaPago"].Value.ToString().Equals(cboFormaPago.Text))
                {
                    MessageBox.Show("FORMA DE PAGO: " + cboFormaPago.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            FormaPagoModel f = (FormaPagoModel)cboFormaPago.SelectedItem;

            nuevaFactura.AgregarFactura(f);

            dgvFormasPago.Rows.Add(new object[] { f.Id, f.Descripcion });
        }

        private void dgvFormasPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormasPago.CurrentCell.ColumnIndex == 2)
            {
                nuevaFactura.QuitarFactura(dgvFormasPago.CurrentRow.Index);

                dgvFormasPago.Rows.Remove(dgvFormasPago.CurrentRow);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboServicio.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un SERVICIO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCantidad.Text == "" || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colServicio"].Value.ToString().Equals(cboServicio.Text))
                {
                    MessageBox.Show("SERVICIO: " + cboServicio.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            TipoServicioModel s = (TipoServicioModel)cboServicio.SelectedItem;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal monto = Convert.ToInt32(txtMonto.Text);

            FacturaDetalleModel detalle = new FacturaDetalleModel();
            detalle.Servicio = s;
            detalle.Monto = monto;
            detalle.Cantidad = cantidad;
            nuevaFactura.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { s.Id, s.Descri, txtMonto.Text, txtCantidad.Text });

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = nuevaFactura.CalcularTotal();
            txtTotal.Text = total.ToString();

            decimal porcentaje = 0;
            foreach (FormaPagoModel formPago in nuevaFactura.Forma)
            {
                porcentaje += formPago.Porcentaje;
            }

            porcentaje /= nuevaFactura.Forma.Count;
            if (porcentaje > 0)
            {
                decimal rec = total * porcentaje / 100;
                txtFinal.Text = (total + rec).ToString();
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevaFactura.QuitarDetalle(dgvDetalles.CurrentRow.Index);

                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

                CalcularTotal();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                nuevaFactura.NumFactura = facturanro;
                nuevaFactura.Cliente = (ClienteModel)cboCliente.SelectedItem;
                nuevaFactura.Fecha = dtpFecha.Value;
                nuevaFactura.Reserva = (ReservaModel)cboReserva.SelectedItem;
                nuevaFactura.TipoFactura = (TipoFacturaModel)cboTipoFactura.SelectedItem;
                nuevaFactura.Empleado.Legajo = legajoempleado;

                var result = await service.AltaFactura(nuevaFactura);
                if (result.SuccessStatus)
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
            if (dgvFormasPago.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna forma de pago!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
