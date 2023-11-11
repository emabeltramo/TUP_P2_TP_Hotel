using HotelForm.Factory.Interface;
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

namespace HotelForm.View.Reserva
{
    public partial class frmNuevaReserva : Form
    {
        IFactoryService factory;
        IReservaService service;
        public frmNuevaReserva(IFactoryService factory)
        {
            this.factory = factory;
            service = factory.CreateReservaService();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAlternativaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
