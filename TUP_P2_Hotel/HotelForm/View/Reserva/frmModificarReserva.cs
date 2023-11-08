using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Reserva
{
    public partial class frmModificarReserva : Form
    {
        public frmModificarReserva()
        {
            InitializeComponent();
        }

        private void btnFiltroReserva_Click(object sender, EventArgs e)
        {
            panelFiltrado.Visible = true;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelFiltrado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOcultarPanel_Click(object sender, EventArgs e)
        {
            panelFiltrado.Visible = false;
        }

        private void lblModFP_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
