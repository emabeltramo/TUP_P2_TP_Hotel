using HotelBackEnd.DAO.Helper;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Reportes
{
    public partial class frmConsultas : Form
    {
        HelperDao helper;
        public frmConsultas()
        {
            helper = HelperDao.GetInstance();
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {

            cboConsulta.DataSource = helper.GetSp("SP_CONSULTAS");
            cboConsulta.DisplayMember = "nombre";
            cboConsulta.ValueMember = "id";

            cboTipoCliente.DataSource = helper.GetSp("SP_CLIENTES");
            cboTipoCliente.DisplayMember = "Descripcion";
            cboTipoCliente.ValueMember = "ID";
        }

        private void cboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Parametro> parametros = new List<Parametro>();
            string nomConsulta = cboConsulta.Text;
            Desactivar();
            DataTable tabla = new DataTable();
            switch (nomConsulta)
            {
                case "CONSULTA 1":
                    txtNroPiso.Enabled = true;
                    lblNroPiso.Enabled = true;
                    dgvResultado.DataSource = null;
                    cboConsulta.Enabled = false;
                    txtNroPiso.Clear();
                    txtNroFactura.Clear();
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    break;
                case "CONSULTA 3":
                    lblNroFactura.Enabled = true;
                    txtNroFactura.Enabled = true;
                    cboTipoCliente.Enabled = true;
                    cboConsulta.Enabled = false;
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = null;
                    txtNroPiso.Clear();
                    txtNroFactura.Clear();
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    break;
                case "CONSULTA 5":
                    lblAño.Enabled = true;
                    lblPorcentaje.Enabled = true;
                    txtPorcentaje.Enabled = true;
                    txtAño.Enabled = true;
                    dgvResultado.DataSource = null;
                    cboConsulta.Enabled = false;
                    txtNroPiso.Clear();
                    txtNroFactura.Clear();
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    break;
                case "CONSULTA 9":

                    lblAño.Enabled = true;
                    txtAño.Enabled = true;
                    dgvResultado.DataSource = null;
                    cboConsulta.Enabled = false;
                    txtNroPiso.Clear();
                    txtNroFactura.Clear();
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    break;

            }
            parametros.Clear();
            parametros.Add(new Parametro("@nombre", nomConsulta));
            tabla = helper.Consultar("SP_CONSULTA_TXT", parametros);
            foreach (DataRow row in tabla.Rows)
            {
                txtEnunciado.Text = row[0].ToString();
                txtSentencia.Text = row[1].ToString();
            }

        }

        private void AjustarColumnas()
        {
            foreach (DataGridViewColumn c in dgvResultado.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void Desactivar()
        {
            lblNroPiso.Enabled = false;
            lblTipoCliente.Enabled = false;
            lblNroFactura.Enabled = false;
            lblAño.Enabled = false;
            lblPorcentaje.Enabled = false;

            cboTipoCliente.Enabled = false;

            txtNroPiso.Enabled = false;
            txtNroFactura.Enabled = false;
            txtAño.Enabled = false;
            txtPorcentaje.Enabled = false;

        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int tipoClie;
            List<Parametro> parametros = new List<Parametro>();
            string nomConsulta = cboConsulta.Text;
            Desactivar();
            DataTable tabla = new DataTable();
            switch (nomConsulta)
            {
                case "CONSULTA 1":
                    parametros.Add(new Parametro("@piso", Convert.ToInt32(txtNroPiso.Text)));
                    dgvResultado.DataSource = helper.Consultar("SP_CONSULTA_1", parametros);
                    AjustarColumnas();
                    break;
                case "CONSULTA 3":
                    if (cboConsulta.Text == "Personas")
                        tipoClie = 1;
                    else
                        tipoClie = 2;
                    parametros.Add(new Parametro("@tipo_cliente", tipoClie));
                    parametros.Add(new Parametro("@nro_factura", Convert.ToInt32(txtNroFactura.Text)));
                    dgvResultado.DataSource = helper.Consultar("SP_CONSULTA_3", parametros);
                    break;
                case "CONSULTA 5":
                    parametros.Add(new Parametro("@año", Convert.ToInt32(txtAño.Text)));
                    parametros.Add(new Parametro("@porcen", Convert.ToDouble(txtPorcentaje.Text)));
                    dgvResultado.DataSource = helper.Consultar("SP_CONSULTA_5", parametros);
                    AjustarColumnas();
                    break;
                case "CONSULTA 9":
                    parametros.Add(new Parametro("@año", Convert.ToInt32(txtAño.Text)));
                    dgvResultado.DataSource = helper.Consultar("SP_CONSULTA_9", parametros);
                    AjustarColumnas();
                    break;
            }
            cboConsulta.Enabled = true;
            parametros.Clear();

        }


        private void lblNroPiso_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
