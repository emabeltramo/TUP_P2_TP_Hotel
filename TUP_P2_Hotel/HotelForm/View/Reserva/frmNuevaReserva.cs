using HotelBackEnd.Model;
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
            this.Load += FrmNuevaReserva_Load;

           

        }

        

        private void FrmNuevaReserva_Load(object? sender, EventArgs e)
        {
            cboClienteReserva.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarCombos();
        }
        private async void CargarCombos()
        {
            cboClienteReserva.DataSource = new List<ClienteModel>();
            cboClienteReserva.DisplayMember = "NombreCompleto";
            cboClienteReserva.ValueMember = "Id_Cliente";
            List<ClienteModel> clients = await service.GetClientesAsync();
            cboClienteReserva.DataSource = clients;

        }
        private void btnSalirReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
