using HotelBackEnd.Model;
using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using HotelForm.View.Principal;
using System.Windows.Forms;

namespace HotelForm.View.Login
{
    public partial class frmLogin : Form
    {
        private IFactoryService factory;
        private ILoginService service;
        public frmLogin(IFactoryService factory)
        {
            this.factory = factory;
            service=factory.CreateLoginService();
            InitializeComponent();
            InitComp();
            this.Load += FrmLogin_Load;
        }
        private void InitComp()
        {
            cboUsuario.DataSource = new List<EmpleadoModel>();
            cboUsuario.DisplayMember = "NombreCompleto";
            cboUsuario.ValueMember = "Legajo";
        }
        private async void FrmLogin_Load(object? sender, EventArgs e)
        {
            await ObtenerEmpleados();
        }
        private async Task ObtenerEmpleados()
        {
            var lista = await service.GetEmpleados();
            cboUsuario.DataSource = lista;

        }
        private void btnSingIn_Click(object sender, EventArgs e)
        {
            if (cboUsuario.SelectedIndex >= 0)
            {
                factory.SetSesion((EmpleadoModel)cboUsuario.SelectedItem);
                frmMain formGestion = new frmMain(factory);
                formGestion.Show();
                this.Hide();
            }
            else
            {
                string caption = "Advertencia";
                MessageBox.Show("Necesita Ingresar un Usuario", caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
        }

        

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // frmLogin
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "frmLogin";
        //    this.Load += new System.EventHandler(this.frmLogin_Load);
        //    this.ResumeLayout(false);

        //}

        
    }
}