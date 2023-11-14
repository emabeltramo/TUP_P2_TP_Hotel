﻿using HotelBackEnd.Model;
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


                    txtNroDocumento.Text = c.DNI;

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
                if (cboCliente.SelectedItem != null )
                {
                    ClienteModel cliente = new ClienteModel();
                    ClienteModel c = (ClienteModel)cboCliente.SelectedItem;
                    cliente.RazonSocial = txtRazonSocial.Text;
                    cliente.CUIL = txtNroDocumento.Text; 
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.DNI = txtNroDocumento.Text; 
                    cliente.Email = txtEmail.Text;
                    cliente.Celular = txtTelefono.Text;

                    var result = await clienteService.ActualizarCliente(cliente);

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
        }
    }
}


    

