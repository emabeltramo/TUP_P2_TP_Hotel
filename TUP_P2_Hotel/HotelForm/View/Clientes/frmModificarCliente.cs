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
        private void frmModificarCliente_Load(object sender, EventArgs e)
        {

            CargarComboCliente();

        }

        private async void CargarComboCliente()
        {
            List<ClienteModel> clients = await clienteService.GetClientesAsync();
            cboCliente.DataSource = clients;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
