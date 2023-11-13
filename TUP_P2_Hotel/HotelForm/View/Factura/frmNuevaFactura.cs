using HotelBackEnd.Model;
using HotelForm.HTTPClient;
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

namespace HotelForm.View.Factura
{
    public partial class frmNuevaFactura : Form
    {
        private FacturaModel nuevo;
        public frmNuevaFactura()
        {
            InitializeComponent();
            nuevo = new FacturaModel();
        }

        private void frmNuevaFactura_Load(object sender, EventArgs e)
        {
            ProximoPresupuesto();
            CargarClienteAsync();
            CargarTipoFacturaAsync();
            CargarFormaPagoAsync();
            CargarServicioAsync();
            Limpiar();
            //this.ActiveControl = cboServicio;
        }

        private void Limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            cboCliente.Text = "CONSUMIDOR FINAL";
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

        }

        private async Task CargarClienteAsync()
        {
            string url;  //"https://localhost:7107/api/OrdenProduccion/componentes"; 
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ClienteModel>>(result);
            cboCliente.DataSource = lst;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";
        }

        private async Task CargarTipoFacturaAsync()
        {
            string url;
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ClienteModel>>(result);
            cboTipoFactura.DataSource = lst;
            cboTipoFactura.DisplayMember = "Tipo";
            cboTipoFactura.ValueMember = "Id";
        }

        private async Task CargarFormaPagoAsync()
        {
            string url;
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ClienteModel>>(result);
            cboFormaPago.DataSource = lst;
            cboFormaPago.DisplayMember = "Descripcion";
            cboFormaPago.ValueMember = "Id";
        }

        private async Task CargarServicioAsync()
        {
            string url;
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ClienteModel>>(result);
            cboServicio.DataSource = lst;
            cboServicio.DisplayMember = "Descri";
            cboServicio.ValueMember = "Id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
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

            //lista de FacturaPago?
            dgvDetalles.Rows.Add(new object[] { f.Id, f.Descripcion });
        }

        private void dgvFormasPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormasPago.CurrentCell.ColumnIndex == 2)
            {
                dgvFormasPago.Rows.Remove(dgvFormasPago.CurrentRow);

                CalcularTotal();

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
            nuevo.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { s.Id, s.Descri, txtMonto.Text, txtCantidad.Text });

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double total = nuevo.CalcularTotal();
            txtTotal.Text = total.ToString();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);

                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

                CalcularTotal();

            }
        }

        private void ProximoPresupuesto()//VERIFICAR
        {

            int next = 999;//servicio.ProximoPresupuesto();
            if (next > 0)
                lblNroFactura.Text = "Presupuesto Nº: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //VALIDAR

            //GUARDAR

            Limpiar();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
