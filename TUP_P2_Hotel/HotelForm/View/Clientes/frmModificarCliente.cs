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

namespace HotelForm.View.Clientes
{
    public partial class frmModificarCliente : Form
    {
        IFactoryService factory;
        IClienteService clienteService;
        private List<TipoDocumentoModel> tipoDocumento;
        private List<TipoClienteModel> tipoCliente;

        public frmModificarCliente(IFactoryService factory)
        {
            this.factory = factory;
            clienteService = factory.CreateClienteService();
            InitializeComponent();

        }
        private async void frmModificarCliente_Load(object sender, EventArgs e)
        {

            CargarComboCliente();
            tipoDocumento = await clienteService.GetTipoDocumentosAsync();
            cboTipoDocumento.DataSource = tipoDocumento;
            cboTipoDocumento.DisplayMember = "Descri";
            cboTipoDocumento.ValueMember = "Id";
            tipoCliente = await clienteService.GetTipoClientesAsync();
            cboTipoCliente.DataSource = tipoCliente;
            cboTipoCliente.DisplayMember = "Descri";
            cboTipoCliente.ValueMember = "Id";

        }

        private async void CargarComboCliente()
        {

            List<ClienteModel> clients = await clienteService.GetClientesAsync();
            cboCliente.DataSource = clients;

            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";
        }

        private async void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = (ClienteModel)cboCliente.SelectedItem;
            txtApellido.Text = c.Apellido;
            txtNombre.Text = c.Nombre;
            if (c.CUIL == 0.ToString())
                txtNroDocumento.Text = c.DNI;
            else
                txtNroDocumento.Text = c.CUIL;

            
        }
    }
}
