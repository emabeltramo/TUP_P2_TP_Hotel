using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using Microsoft.Extensions.Logging;
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


                    txtNroDocumento.Text = c.DNI.ToString();

                }
                else
                {
                    txtNroDocumento.Text = c.CUIL.ToString();
                }



                txtRazonSocial.Text = c.RazonSocial;
                txtTelefono.Text = c.Celular;
                txtEmail.Text = c.Celular;


                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            control.Text = "-";

                        }
                    }
                }

            }


        }

        private async void btnCargarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteModel c = (ClienteModel)cboCliente.SelectedItem;
                
                if (cboCliente.SelectedItem != null )
                {
  
                    c.Id_Cliente = c.Id_Cliente; // aca deberia estar el error
                    c.RazonSocial = txtRazonSocial.Text;
                    c.CUIL = txtNroDocumento.Text;
                    c.Nombre = txtNombre.Text;
                    c.Apellido = txtApellido.Text;
                    c.DNI = txtNroDocumento.Text;
                    c.Email = txtEmail.Text;
                    c.Celular = txtTelefono.Text;
                    
                    var result = await clienteService.ActualizarCliente(c);
                    
                    if (result.SuccessStatus)
                    {
                        MessageBox.Show("Cliente actualizado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error al cargar cliente: {result.Data}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarComboCliente();
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


            }
        }
    }
}




