using HotelForm.Factory.Interface;
using HotelForm.View.Factura;
using HotelForm.View.Factura.FacturaView;
using HotelForm.View.Clientes;
using HotelForm.View.Login;
using HotelForm.View.Reporte;
using HotelForm.View.Reserva;
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
        private IFactoryService factory;
        public frmMain(IFactoryService factory)
        {
            this.factory = factory;
            InitializeComponent();
            this.Load += FrmMain_Load;
            btnCargarServicio.Click += BtnCargarServicio_Click;
            btnNvoCliente.Click += BtnNvoCliente_Click;
            btnModificarCliente.Click += BtnModificarCliente_Click;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void BtnModificarCliente_Click(object? sender, EventArgs e)
        {
            AbrirFormHijo(new frmCliente(factory));

            OcultarSubmenu();
        }

        private void BtnNvoCliente_Click(object? sender, EventArgs e)
        {
            AbrirFormHijo(new frmAltaCliente(factory));
            OcultarSubmenu();
        }

        private void BtnCargarServicio_Click(object? sender, EventArgs e)
        {
            AbrirFormHijo(new frmReporte(factory));
            //...
            OcultarSubmenu();
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {
            var empleado = factory.GetSesion();
            this.Text = $"Bienvenido {empleado.Apellido} {empleado.Nombre}";
            btnServicio.Text = "REPORTES";
            btnCargarServicio.Text = "Clientes Anuales";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void OcultarSubmenu()
        {
            if (panelMedio1.Visible == true)
            { panelMedio1.Visible = false; }
            if (panelMedio2.Visible == true)
            { panelMedio2.Visible = false; }
            if (panelMedio3.Visible == true)
            { panelMedio3.Visible = false; }
            if (panelMedio4.Visible == true)
            { panelMedio4.Visible = false; }
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

        #region submenu Facturas
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            
            MostrarSubmenu(panelMedio4);
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmNuevaFactura(factory));
            //...
            OcultarSubmenu();
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmFacturas(factory));
            //...
            OcultarSubmenu();
        }
        #endregion

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

            AbrirFormHijo(new frmNuevaReserva(factory));
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
            AbrirFormHijo(new frmReservas(factory));
            //...
            OcultarSubmenu();
        }
        #endregion

        #region submenu Clientes
        private void btnCLIENTES_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMedio2);

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
                this.Close();
                this.Dispose();
                

            }
        }
    }
}