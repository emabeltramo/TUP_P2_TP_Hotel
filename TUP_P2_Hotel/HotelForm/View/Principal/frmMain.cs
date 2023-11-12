using HotelForm.View.Login;
using HotelForm.View.Reserva;
using HotelForm.View.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Principal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void OcultarSubmenu()
        {
            if (panelMedio1.Visible == true)
            { panelMedio1.Visible = false; }
            if (panelMedio2.Visible == true)
            { panelMedio2.Visible = false; }
            if (panelMedio3.Visible == true)
            { panelMedio3.Visible = false; }
        }


        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        #region submenu Reservas
        private void btnReservas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMedio1);
        }


        private Form activarForm = null;
        private void AbrirFormHijo(Form FormHijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(FormHijo);
            panelFormHijo.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }
        private void btnNvaReserv_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new frmNuevaReserva());
            //...
            OcultarSubmenu();
        }

        private void btnConsultarReserva_Click(object sender, EventArgs e)
        {

            //...
            OcultarSubmenu();
        }

        private void btnModificarReserv_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmModificarReserva());
            //...
            OcultarSubmenu();
        }
        #endregion

        #region submenu Clientes
        private void btnCLIENTES_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMedio2);

        }

        private void btnNvoCliente_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubmenu();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubmenu();
        }
        #endregion

        #region submenu Servicio

        private void btnServicio_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMedio3);
        }

        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        #endregion


        private void panelFormHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultasSubenu_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmConsultarReserva());
            OcultarSubmenu();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //hay q cinfigurar esto
            DialogResult result = MessageBox.Show("Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                AbrirFormHijo(new frmLogin());

            }
        }

        private void btnNvoCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAltaCliente());
            OcultarSubmenu();
        }
    }
}