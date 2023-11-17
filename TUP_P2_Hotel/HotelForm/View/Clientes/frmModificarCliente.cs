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
             actualizado= new ClienteModel();
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

                    break;

                case "Empresas":
                    cboTipoCliente.SelectedValue = 2;
                    txtRazonSocial.Text= cliente.RazonSocial;
                    break;

                default:
                    cboTipoCliente.SelectedValue = cboTipoCliente.Items.Count;
                    break;
            }

            switch (tipoDocumento)
            {
                case "DNI":
                    cboTipoDocumento.SelectedValue = 1;
                    txtNroDocumento.Text = cliente.DNI;
                    break;

                case "Pasaporte":
                    cboTipoDocumento.SelectedValue =2;
                    txtNroDocumento.Text = cliente.CUIL;
                    break;

                default:
                    cboTipoDocumento.SelectedValue = cboTipoDocumento.Items.Count;
                    break;
            }
           
            txtEmail.Text = cliente.Email.ToString();
            txtTelefono.Text=cliente.Celular.ToString();

            MessageBox.Show($"Tipo Documento: {tipoDocumento}, Tipo Cliente: {tipoCliente}");
        }

        

        private async void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private async void btnCargarCliente_Click(object sender, EventArgs e)
        {

            try { 
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
                            $"\nDNI/CUIL: {actualizado.DNI}, { actualizado.CUIL}"+
                            $"\nTipo Documento: {actualizado.TDoc.Id}, {actualizado.TDoc.Descri}" +
                            $"\nTipo Cliente: {actualizado.TCliente.Id}, {actualizado.TCliente.Descri}");

               await clienteService.ActualizarCliente( actualizado );
                MessageBox.Show("cargado");
            }

           catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
                return;
            }
            
          
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

        private async void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}




