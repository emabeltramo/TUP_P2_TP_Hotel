using HotelBackEnd.Model;
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
    public partial class frmEliminar : Form
    {
        IClienteService clienteService;
        IFactoryService factory;
        int id;

        public frmEliminar(IFactoryService factory)
        {
            this.factory = factory;
            clienteService = factory.CreateClienteService();
            InitializeComponent();

        }
        private async void CargarComboCliente()
        {

            List<ClienteModel> clients = await clienteService.GetClientesListaAsync();
            cboCliente.DataSource = clients;

            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id_Cliente";
        }

        private async void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem != null)
            {
                ClienteModel c = (ClienteModel)cboCliente.SelectedItem;
                id = c.Id_Cliente;

            }


        }

        private async void btnCargarCliente_Click(object sender, EventArgs e)
        {

            var result = await clienteService.BajaCliente(id);
            CargarComboCliente();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
        }
    }
}
