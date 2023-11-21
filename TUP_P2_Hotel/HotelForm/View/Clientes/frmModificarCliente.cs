using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using System.Data;

namespace HotelForm.View.Clientes
{
    public partial class frmModificarCliente : Form
    {
        private IFactoryService factory;
        private IClienteService clienteService;
        private ClienteModel cliente;
        private ClienteModel actualizado;

        public frmModificarCliente(IFactoryService factory, ClienteModel c)
        {
            this.factory = factory;
            this.clienteService = factory.CreateClienteService();
            InitializeComponent();
            this.cliente = c;
            actualizado = new ClienteModel();
        }
        private async Task<(string tipoDocumento, string tipoCliente)> ObtenerTipoDocumentoYClienteAsync(int idTipoDocumento, int idTipoCliente)
        {
            string tipoDocumento = "";
            string tipoCliente = "";

            List<TipoDocumentoModel> tdoc = await clienteService.GetTipoDocumentosAsync();
            cboTipoDocumento.DataSource = tdoc;
            cboTipoDocumento.DisplayMember = "Descri";
            cboTipoDocumento.ValueMember = "Id";

            List<TipoClienteModel> tcli = await clienteService.GetTipoClientesAsync();
            cboTipoCliente.DataSource = tcli;
            cboTipoCliente.DisplayMember = "Descri";
            cboTipoCliente.ValueMember = "Id";

            TipoDocumentoModel tipoDoc = tdoc.FirstOrDefault(t => t.Id == idTipoDocumento);
            if (tipoDoc != null)
            {
                tipoDocumento = tipoDoc.Descri;
            }

            TipoClienteModel tipoCli = tcli.FirstOrDefault(t => t.Id == idTipoCliente);
            if (tipoCli != null)
            {
                tipoCliente = tipoCli.Descri;
            }

            return (tipoDocumento, tipoCliente);
        }


        private async void frmModificarCliente_Load(object sender, EventArgs e)
        {
            int idTipoDocumento = cliente.TDoc.Id;
            int idTipoCliente = cliente.TCliente.Id;

            var (tipoDocumento, tipoCliente) = await ObtenerTipoDocumentoYClienteAsync(idTipoDocumento, idTipoCliente);


            cboTipoDocumento.SelectedValue = idTipoDocumento;

            switch (tipoCliente)
            {
                case "Personas":
                    cboTipoCliente.SelectedValue = 1;
                    txtApellido.Text = cliente.Apellido.ToString();
                    txtNombre.Text = cliente.Nombre.ToString();
                    txtNroDocumento.Text = cliente.CUIL.ToString();

                    break;

                case "Empresas":
                    cboTipoCliente.SelectedValue = 2;
                    txtRazonSocial.Text = cliente.RazonSocial;
                    break;

                default:
                    cboTipoCliente.SelectedValue = cboTipoCliente.Items.Count;
                    break;
            }

            switch (tipoDocumento)
            {
                case "DNI":
                    cboTipoDocumento.SelectedValue = 1;
                    txtNroDocumento.Text = cliente.DNI.ToString();
                    break;

                case "Pasaporte":
                    cboTipoDocumento.SelectedValue = 2;
                    txtNroDocumento.Text = cliente.CUIL.ToString();
                    break;

                default:
                    cboTipoDocumento.SelectedValue = cboTipoDocumento.Items.Count;
                    break;
            }

            txtEmail.Text = cliente.Email.ToString();
            txtTelefono.Text = cliente.Celular.ToString();

            MessageBox.Show($"Tipo Documento: {tipoDocumento}, Tipo Cliente: {tipoCliente}");
        }




        private async void btnCargarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                actualizado.Id_Cliente = cliente.Id_Cliente;
                actualizado.Apellido = txtApellido.Text;
                actualizado.Nombre = txtNombre.Text;
                actualizado.Email = txtEmail.Text;
                actualizado.Celular = txtTelefono.Text;
                actualizado.RazonSocial = txtRazonSocial.Text;

                switch (cboTipoDocumento.SelectedValue)
                {
                    case 1:
                        actualizado.TDoc.Id = 1;
                        actualizado.TDoc.Descri = "DNI";
                        actualizado.TCliente.Id = 1;
                        actualizado.TCliente.Descri = "Personas";
                        actualizado.DNI = txtNroDocumento.Text;
                        actualizado.CUIL = ("20" + txtNroDocumento.Text + "1");
                        break;

                    case 2:
                        actualizado.TDoc.Id = 2;
                        actualizado.TDoc.Descri = "Pasaporte";

                        if (actualizado.TCliente.Descri != "Personas")
                        {
                            actualizado.TCliente.Id = 2;
                            actualizado.TCliente.Descri = "Empresas";
                            actualizado.CUIL = txtNroDocumento.Text;
                        }


                        break;
                }

                await clienteService.ActualizarCliente(actualizado);
                MessageBox.Show("Cliente Modificado");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }


        }


        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = cliente.Id_Cliente;
                MessageBox.Show(id.ToString());
                DialogResult result = MessageBox.Show("Desea BORRAR el CLIENTE?, ESTO BORRRARA TODOS LOS REGISTROS DE ESTE", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await clienteService.BajaCliente(id);
                    MessageBox.Show("borrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}




