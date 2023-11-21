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
        public frmCliente(IFactoryService factory)
        {
            this.factory = factory;
            clienteService = factory.CreateClienteService();
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
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

                                await clienteService.BajaCliente(Id_Cliente);
                            }
                            else
                            {

                            }
                            CargarDgvClientesAsync();
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
        private async void CargarDgvClientesAsync(List<ClienteModel> listaFiltrada)
        {
            DataTable dtClientes = new DataTable();

            try
            {

                if (listaFiltrada != null && listaFiltrada.Count > 0)
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

                    foreach (var item in listaFiltrada)
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
                    OcultarColumna();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumna()
        {
            dgvClientes.Columns["ID"].Visible = false;
            dgvClientes.Columns["Tipo Cliente"].Visible = false;
            dgvClientes.Columns["Tipo Documento"].Visible = false;
        }

        private void Activar()
        {
            cbxDni.Enabled = true;
            cbxCuil.Enabled = true;
            cbxNom.Enabled = true;
            cbxApe.Enabled = true;
            cbxRazSoc.Enabled = true;

        }

        private void Desactivar()
        {
            txtBuscar.Clear();
            if (cbxDni.Checked)
            {
                cbxCuil.Enabled = false;
                cbxNom.Enabled = false;
                cbxApe.Enabled = false;
                cbxRazSoc.Enabled = false;
                txtBuscar.Enabled = true;
            }
            else if (cbxCuil.Checked)
            {
                cbxDni.Enabled = false;
                cbxNom.Enabled = false;
                cbxApe.Enabled = false;
                cbxRazSoc.Enabled = false;
                txtBuscar.Enabled = true;
            }
            else if (cbxNom.Checked)
            {
                cbxApe.Enabled = false;
                cbxCuil.Enabled = false;
                cbxDni.Enabled = false;
                cbxRazSoc.Enabled = false;
                txtBuscar.Enabled = true;
            }
            else if (cbxApe.Checked)
            {
                cbxNom.Enabled = false;
                cbxCuil.Enabled = false;
                cbxDni.Enabled = false;
                cbxRazSoc.Enabled = false;
                txtBuscar.Enabled = true;
            }
            else if (cbxRazSoc.Checked)
            {

                cbxCuil.Enabled = false;
                cbxNom.Enabled = false;
                cbxApe.Enabled = false;
                cbxDni.Enabled = false;
                txtBuscar.Enabled = true;
            }
            else
            {
                cbxCuil.Checked = false;
                cbxDni.Checked = false;
                cbxNom.Checked = false;
                cbxApe.Checked = false;
                cbxRazSoc.Checked = false;
                txtBuscar.Enabled = false; 
                cbxCuil.Enabled = true;
                cbxDni.Enabled = true;
                cbxNom.Enabled = true;
                cbxApe.Enabled = true;
                cbxRazSoc.Enabled = true;
                txtBuscar.Enabled = false;

            }
        }
        private void cbxRazSoc_CheckedChanged(object sender, EventArgs e)
        {
            Desactivar();
        }

        private void cbxDni_CheckedChanged(object sender, EventArgs e)
        {
            Desactivar();
        }

        private void cbxNom_CheckedChanged(object sender, EventArgs e)
        {
            Desactivar();
        }
        private void cbxApe_CheckedChanged(object sender, EventArgs e)
        {
            Desactivar();
        }
        private void cbxCuil_CheckedChanged(object sender, EventArgs e)
        {
            Desactivar();
        }
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            List<ClienteModel> lClientes = new List<ClienteModel>();
            lClientes = await clienteService.GetClientesListaAsync();


            List<ClienteModel> listaFiltrada;
            Activar();
            if (cbxDni.Checked)
            {

                string numero = txtBuscar.Text;
                listaFiltrada = lClientes.FindAll(y => y.DNI.Contains(numero));
                dgvClientes.DataSource = listaFiltrada;

                CargarDgvClientesAsync(listaFiltrada);
                Desactivar();

            }
            else if (cbxCuil.Checked)
            {
                string numero = txtBuscar.Text;
                listaFiltrada = lClientes.FindAll(y => y.CUIL.Contains(numero));
                dgvClientes.DataSource = listaFiltrada;
                CargarDgvClientesAsync(listaFiltrada);
                Desactivar();

            }
            if (cbxNom.Checked)
            {
                string nombre = txtBuscar.Text.Trim().ToLower();

                listaFiltrada = lClientes.FindAll(y =>
                    y.Nombre.Trim().ToLower().Contains(nombre)
                );

                dgvClientes.DataSource = listaFiltrada;
                CargarDgvClientesAsync(listaFiltrada);
                Desactivar();
            }
            else if (cbxApe.Checked)
            {
                string apellido = txtBuscar.Text.Trim().ToLower();

                listaFiltrada = lClientes.FindAll(y =>
                    y.Apellido.Trim().ToLower().Contains(apellido)
                );

                dgvClientes.DataSource = listaFiltrada;
                CargarDgvClientesAsync(listaFiltrada);
                Desactivar();
            }
            else if (cbxRazSoc.Checked)
            {
                string razon = txtBuscar.Text.Trim().ToLower();
                listaFiltrada = lClientes.FindAll(y => y.RazonSocial.Trim().ToLower().Contains(razon));
                dgvClientes.DataSource = listaFiltrada;
                CargarDgvClientesAsync(listaFiltrada);
                Desactivar();
            }
            if (cbxApe.Checked == false && cbxNom.Checked == false && cbxDni.Checked == false && cbxCuil.Checked == false && cbxRazSoc.Checked == false)
            {
                txtBuscar.Clear();
                CargarDgvClientesAsync();

            }
               
            



        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.Enabled = false;
            CargarDgvClientesAsync();
          
            Activar();
            Desactivar();

        }
    }
}