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


        public frmModificarCliente(IFactoryService factory)
        {
            this.factory = factory;
            clienteService = factory.CreateClienteService();
            InitializeComponent();

        }
        private async void frmModificarCliente_Load(object sender, EventArgs e)
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

        private async void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem != null)
            {
                ClienteModel c = (ClienteModel)cboCliente.SelectedItem;
                txtApellido.Text = c.Apellido;
                txtNombre.Text = c.Nombre;
                TipoClienteModel tipoClienteModel = c.TCliente;
                if (tipoClienteModel != null && tipoClienteModel.Id.Equals(1))
                {


                    txtNroDocumento.Text = c.DNI;

                }
                else
                {
                    txtNroDocumento.Text = c.CUIL.ToString();
                }



                txtRazonSocial.Text = c.RazonSocial;
                txtTelefono.Text = c.Celular;
                txtEmail.Text = c.Celular;
            }


        }

        private async void btnCargarCliente_Click(object sender, EventArgs e)
        {
            ClienteModel c = (ClienteModel)cboCliente.SelectedItem;

            
            var result = await clienteService.ActualizarCliente(c);
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

}

