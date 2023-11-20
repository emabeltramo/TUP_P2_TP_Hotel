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
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarDgvClientesAsync();
        }

        private async void CargarDgvClientesAsync()
        {
            DataTable dtClientes = new DataTable();

            try
            {
                var result = await clienteService.GetClientesListaAsync();

                if (result != null && result.Count > 0)
                {
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
                    int columnas = dtClientes.Columns.Count;
                    dgvClientes.DataSource = dtClientes;
                    dgvClientes.Columns["ColModificar"].DisplayIndex = 11; 
                    dgvClientes.Columns["ColEliminar"].DisplayIndex = 11; 
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



        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                this.Close();

            }

            if (e.ColumnIndex == dgvClientes.Columns["ColEliminar"].Index && e.RowIndex != -1)
            {
                try
                {

                    int Id_Cliente = int.Parse(dgvClientes.CurrentRow.Cells["ID"].Value.ToString());


                    bool clienteTieneRegistros = HelperDao.GetInstance().VerificarClienteExistente(Id_Cliente);
                    if (clienteTieneRegistros == false)
                    {

                        MessageBox.Show("El cliente tiene reservas o facturas y no se puede eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Desea eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (clienteTieneRegistros == true)
                            {

                                clienteService.BajaCliente(Id_Cliente);
                            }
                            else
                            {

                            }

                            dgvClientes.Refresh();
                        }
                    }
                }
                catch (SqlException ex)
                {

                    Console.WriteLine($"Error de SQL Server: {ex.Message}");
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }


            }
        }
            // Método para verificar si el cliente tiene registros en reservas o facturas
          

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            CargarDgvClientesAsync();


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}