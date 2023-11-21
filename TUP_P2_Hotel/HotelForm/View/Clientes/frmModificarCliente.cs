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

            this.Load += FrmModificarCliente_Load;
            btnCargarCliente.Click += BtnCargarCliente_Click;
            btnSalirCliente.Click += BtnSalirCliente_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            btnSalirCliente.Click += BtnSalirCliente_Click1;
            btnBorrar.Click += BtnBorrar_Click;
        }

        private async void BtnBorrar_Click(object? sender, EventArgs e)
        {
            int id = cliente.Id_Cliente;
            DialogResult result = MessageBox.Show("Desea BORRAR el CLIENTE?, ESTO BORRRARA TODOS LOS REGISTROS DE ESTE", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var quest = await clienteService.BajaCliente(id);
                if (quest.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se borro exitosamente","Borrar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void BtnSalirCliente_Click1(object? sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Limpiar?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void BtnSalirCliente_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnCargarCliente_Click(object? sender, EventArgs e)
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

                // Muestra todos los campos de actualizado en el MessageBox
                MessageBox.Show($"Apellido: {actualizado.Apellido}, Nombre: {actualizado.Nombre}" +
                                $"\nEmail: {actualizado.Email}, Celular: {actualizado.Celular}" +
                                $"\nRazonSocial: {actualizado.RazonSocial}" +
                                $"\nDNI/CUIL: {actualizado.DNI}, {actualizado.CUIL}" +
                                $"\nTipo Documento: {actualizado.TDoc.Id}, {actualizado.TDoc.Descri}" +
                                $"\nTipo Cliente: {actualizado.TCliente.Id}, {actualizado.TCliente.Descri}");

                await clienteService.ActualizarCliente(actualizado);
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private async void FrmModificarCliente_Load(object? sender, EventArgs e)
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



        

    }
}




