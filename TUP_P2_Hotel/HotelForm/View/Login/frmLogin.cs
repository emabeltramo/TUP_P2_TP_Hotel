using HotelForm.Factory.Interface;
using HotelForm.View.Principal;
using System.Windows.Forms;

namespace HotelForm.View.Login
{
    public partial class frmLogin : Form
    {
        private IFactoryService factory;
        public frmLogin(IFactoryService factory)
        {
            this.factory = factory;
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            if (cboUsuario.SelectedIndex >= 0)
            {
                frmMain formGestion = new frmMain(factory);
                formGestion.Show();
            }
            else
            {
                string caption = "Advertencia";
                MessageBox.Show("Necesita Ingresar un Usuario", caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}