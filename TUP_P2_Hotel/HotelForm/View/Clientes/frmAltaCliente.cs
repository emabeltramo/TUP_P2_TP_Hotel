using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using HotelForm.View.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Clientes
{
    public partial class frmAltaCliente : Form
    {
        IFactoryService factory;
        IClienteService clienteService;
        private List<TipoDocumentoModel> tipoDocumento;
        private List<TipoClienteModel> tipoCliente;

        public frmAltaCliente(IFactoryService factory)
        {
            this.factory = factory;
            clienteService = factory.CreateClienteService();
            InitializeComponent();

        }

        private async void frmAgregarCliente_Load(object sender, EventArgs e)
        {

            CargarCombosAsync();
        }
        private async void CargarCombosAsync()
        {


            tipoDocumento = await clienteService.GetTipoDocumentosAsync();
            cboTipoDocumento.DataSource = tipoDocumento;
            cboTipoDocumento.DisplayMember = "Descri";
            cboTipoDocumento.ValueMember = "Id";
            tipoCliente = await clienteService.GetTipoClientesAsync();
            cboTipoCliente.DataSource = tipoCliente;
            cboTipoCliente.DisplayMember = "Descri";
            cboTipoCliente.ValueMember = "Id";

        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private async void btnCargarCliente_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                ClienteModel cliente = new ClienteModel();
                cliente.TDoc = (TipoDocumentoModel)cboTipoDocumento.SelectedItem;
                cliente.TCliente = (TipoClienteModel)cboTipoCliente.SelectedItem;
                if (cboTipoCliente.SelectedIndex == 0)
                {

                    cliente.Nombre = "-";
                    cliente.Apellido = "-";
                    cliente.DNI = string.Empty;
                    cliente.RazonSocial = txtRazonSocial.Text;
                    cliente.CUIL = txtNroDocumento.Text;

                }
                else
                {

                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.RazonSocial = txtRazonSocial.Text;
                    cliente.DNI = txtNroDocumento.Text;
                    cliente.CUIL = "20" + txtNroDocumento.Text + "1";

                }
                cliente.Email = txtEmail.Text;
                cliente.Celular = txtTelefono.Text;
                var result = await clienteService.AltaCliente(cliente);
                if (result.SuccessStatus)
                {
                    MessageBox.Show("Cliente generado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al cargar cliente : " + result.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtNroDocumento.Text = string.Empty;
                txtRazonSocial.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                cboTipoCliente.SelectedIndex = -1;
                cboTipoDocumento.SelectedIndex = -1;

            }
        }

        private bool Validar()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox combo)
                {

                    if (combo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una opcion de cada menu.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            foreach (Char c in txtNroDocumento.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Solo se pueden ingresar numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                break;
            }

            foreach (Char c in txtTelefono.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Solo se pueden ingresar numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                break;
            }

            return true;

        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoCliente.SelectedIndex == 0)
            {
                txtRazonSocial.Enabled = true;
                txtNombre.Text = "-";
                txtApellido.Text = "-";
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                cboTipoDocumento.SelectedIndex = 1;
                cboTipoDocumento.Enabled = false;
                txtRazonSocial.Text = string.Empty;
            }
            else
            {
                txtRazonSocial.Text = "-";
                cboTipoDocumento.SelectedIndex = 0;
                cboTipoDocumento.Enabled = true;
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtRazonSocial.Enabled = false;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
            }
        }
    }
}
