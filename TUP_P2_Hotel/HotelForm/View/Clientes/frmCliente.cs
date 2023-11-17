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

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        c.DNI = dgvClientes.CurrentRow.Cells["Numero Documento"].Value.ToString();
                        c.CUIL = dgvClientes.CurrentRow.Cells["Numero Cuil"].Value.ToString();
                    }
                    else if (tipoDocumento == "Pasaporte")
                    {
                        c.TDoc.Id = 2;
                        c.CUIL = dgvClientes.CurrentRow.Cells["Numero Cuil"].Value.ToString();
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

                    MessageBox.Show($"Cliente numero {c.Id_Cliente}, Tipo Cliente: {c.TCliente.Id} - {c.TCliente.Descri}");

                    new frmModificarCliente(factory, c).ShowDialog();
                
            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvClientes.Rows.Clear();
            DataTable dtClientes = HelperDao.GetInstance().GetSp("SP_LISTA_CLIENTES");
            int columnas = dtClientes.Columns.Count;
            dgvClientes.DataSource = dtClientes;
            dgvClientes.Columns["ColModificar"].DisplayIndex = columnas;


        }
    }
}
