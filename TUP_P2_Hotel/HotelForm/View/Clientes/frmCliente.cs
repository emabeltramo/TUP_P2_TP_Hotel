using HotelBackEnd.DAO.Helper;
using HotelBackEnd.DAO.Interface;
using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Implementation;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.Load += FrmCliente_Load;
            dgvClientes.CellContentClick += DgvClientes_CellContentClick;
            btnBuscar.Click += BtnBuscar_Click;
            btnAtras.Click += BtnAtras_Click;
        }

        private void BtnAtras_Click(object? sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void BtnBuscar_Click(object? sender, EventArgs e)
        {
            await CargarDgvClientesAsync();
        }

        private void DgvClientes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["ColModificar"].Index && e.RowIndex != -1)
            {
                ClienteModel c = new ClienteModel();
                c.Id_Cliente = int.Parse(dgvClientes.CurrentRow.Cells["ID"].Value.ToString());
                c.Nombre = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                c.Apellido = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                c.Email = dgvClientes.CurrentRow.Cells["EMAIL"].Value.ToString();
                c.Celular = dgvClientes.CurrentRow.Cells["CELULAR"].Value.ToString();
                c.RazonSocial = dgvClientes.CurrentRow.Cells["razon social"].Value.ToString();

                string tipoDocumento = dgvClientes.CurrentRow.Cells["Tipo Documento"].Value?.ToString();
                string tipoCliente = dgvClientes.CurrentRow.Cells["Tipo Cliente"].Value?.ToString();

                if (tipoDocumento == "DNI")
                {
                    c.TDoc.Id = 1;
                    c.DNI = dgvClientes.CurrentRow.Cells["DNI"].Value.ToString();
                    c.CUIL = dgvClientes.CurrentRow.Cells["Cuil"].Value.ToString();
                }
                else if (tipoDocumento == "Pasaporte")
                {
                    c.TDoc.Id = 2;
                    c.CUIL = dgvClientes.CurrentRow.Cells["Cuil"].Value.ToString();
                }

                if (tipoCliente == "Personas")
                {
                    c.TCliente.Id = 1;
                    c.TCliente.Descri = "Personas";
                }
                else if (tipoCliente == "Empresas")
                {
                    c.TCliente.Id = 2;
                    c.TCliente.Descri = "Empresas";
                }
                new frmModificarCliente(factory, c).ShowDialog();
                btnBuscar.PerformClick();
            }
        }

        private async void FrmCliente_Load(object? sender, EventArgs e)
        {
           await CargarDgvClientesAsync();
        }



        private async Task CargarDgvClientesAsync()
        {
            DataTable dtClientes = new DataTable();

            try
            {
                var result = await clienteService.GetClientesListaAsync();

                if (result != null && result.Count > 0)
                {
                    // Agrega las columnas que deseas en el DataTable
                    dtClientes.Columns.Add("ID", typeof(int));
                    dtClientes.Columns.Add("Nombre", typeof(string));
                    dtClientes.Columns.Add("Apellido", typeof(string));
                    dtClientes.Columns.Add("Tipo Documento", typeof(string));
                    dtClientes.Columns.Add("DNI", typeof(string));
                    dtClientes.Columns.Add("CUIL", typeof(string));
                    dtClientes.Columns.Add("Email", typeof(string));
                    dtClientes.Columns.Add("Celular", typeof(string));
                    dtClientes.Columns.Add("Tipo Cliente", typeof(string));
                    dtClientes.Columns.Add("Razon Social", typeof(string));

                    foreach (var item in result)
                    {
                        DataRow row = dtClientes.NewRow();

                        // Mapea manualmente las propiedades que quieres incluir
                        row["ID"] = item.Id_Cliente;
                        row["Nombre"] = item.Nombre;
                        row["Apellido"] = item.Apellido;
                        row["Tipo Documento"] = item.TDoc.Descri;
                        row["DNI"] = item.DNI;
                        row["CUIL"] = item.CUIL;
                        row["Email"] = item.Email;
                        row["Celular"] = item.Celular;
                        row["Tipo Cliente"] = item.TCliente.Descri;
                        row["Razon Social"] = item.RazonSocial;

                        dtClientes.Rows.Add(row);
                    }

                    //// Agregar la columna "ColEliminar" como un botón
                    //DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
                    //colEliminar.Name = "ColEliminar";
                    //colEliminar.Text = "Eliminar";
                    //colEliminar.UseColumnTextForButtonValue = true;
                    //dgvClientes.Columns.Add(colEliminar);

                    int columnas = dtClientes.Columns.Count;
                    dgvClientes.DataSource = dtClientes;
                    dgvClientes.Columns["ColModificar"].DisplayIndex = 10; // Ajusta la posición de "ColModificar" si es necesario
                    
                }
                else
                {
                    MessageBox.Show("No se encontraron datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}