using HotelForm.Factory.Interface;
using HotelForm.Service.Implementation;
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
    public partial class frmCliente : Form
    {
        IFactoryService factory;
        IClienteService clienteService;
        DataTable dtClientes;
        public frmCliente(IFactoryService factory)
        {
            this.factory = factory;
            clienteService = factory.CreateClienteService();
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarDgvClientesAsync();
        }

        private async void CargarDgvClientesAsync()
        {
            dtClientes = new DataTable();
            dtClientes.Clear();
            //dtClientes = await clienteService.GetClientesTAsync(txtBuscar.Text);
            int columnas = dtClientes.Columns.Count;
            dgvClientes.DataSource = dtClientes;
            dgvClientes.Columns["ColModificar"].DisplayIndex = columnas+1;
            dgvClientes.Columns["ColEliminar"].DisplayIndex = columnas +1 ;
        }

        private void frmCliente_Load_1(object sender, EventArgs e)
        {

        }
    }
}
