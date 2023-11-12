using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using HotelForm.View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Clientes
{
    public partial class frmAltaCliente : Form
    {
        IFactoryService factory;
        IReservaService service;
        
        
        public frmAltaCliente(IFactoryService factory)
        {
            this.factory = factory;
            service = factory.CreateReservaService();
            InitializeComponent();
        }

        private async void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            List<TipoDocumentoModel> tipoDocumento = await service.GetTipoDocumentosAsync();
            List<TipoClienteModel> tipoCliente = await service.GetTipoClientesAsync();
            cboTipoCliente.DataSource = tipoCliente;
            cboTipoDocumento.DataSource = tipoDocumento;
        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();
            cliente.TDoc = (TipoDocumentoModel)cboTipoDocumento.SelectedItem;
            cliente.TCliente = (TipoClienteModel)cboTipoCliente.SelectedItem;
            if (cboTipoCliente.SelectedIndex== 0)//aca seria tipo particular por ej
            { 
            cliente.Nombre= txtNombre.Text;
            cliente.Apellido= txtApellido.Text;
                cliente.DNI = txtNroDocumento.Text;
            }
            else {
                cliente.Nombre = string.Empty;
                cliente.Apellido = string.Empty;
                cliente.RazonSocial= txtRazonSocial.Text;
                cliente.DNI = string.Empty;
                cliente.CUIL= txtNroDocumento.Text;
            }
            cliente.Email= txtEmail.Text;
            cliente.Celular= txtTelefono.Text;
             service.AltaCliente(cliente); 
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
                this.Dispose();
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
    }
}
