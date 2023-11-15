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

        }

        private void cboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Parametro> parametros = new List<Parametro>();
            string nomConsulta = cboConsulta.Text;
            Desactivar();
            DataTable tabla = new DataTable();
            switch (nomConsulta)
            {
                case "CONSULTA 4":
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = helper.GetSp("SP_CONSULTA_4");
                    break;
                case "CONSULTA 5":
                    Activar();
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    dgvResultado.DataSource = null;
                    cboConsulta.Enabled = false;
                    break;
                case "CONSULTA 7":
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = helper.GetSp("SP_CONSULTA_7");
                    break;
                case "CONSULTA 9":
                    Activar();
                    txtAño.Clear();
                    txtPorcentaje.Clear();
                    lblPorcentaje.Enabled = false;
                    txtPorcentaje.Enabled = false;
                    dgvResultado.DataSource = null;
                    cboConsulta.Enabled = false;
                    break;
                default:
                    dgvResultado.DataSource = null;
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

        private void Activar()
        {

            lblAño.Enabled = true;
            lblPorcentaje.Enabled = true;
            txtPorcentaje.Enabled = true;
            txtAño.Enabled = true;
            btnEjecutar.Enabled = true;
        }

        private void Desactivar()
        {
            lblAño.Enabled = false;
            lblPorcentaje.Enabled = false;
            txtPorcentaje.Enabled = false;
            txtAño.Enabled = false;
            btnEjecutar.Enabled = false;
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            string nomConsulta = cboConsulta.Text;
            Desactivar();
            DataTable tabla = new DataTable();
            switch (nomConsulta)
            {
                case "CONSULTA 5":
                    parametros.Add(new Parametro("@año", Convert.ToInt32(txtAño.Text)));
                    parametros.Add(new Parametro("@porcen", Convert.ToDouble(txtPorcentaje.Text)));
                    dgvResultado.DataSource = helper.Consultar("SP_CONSULTA_5", parametros);


                    break;
                case "CONSULTA 9":
                    parametros.Add(new Parametro("@año", Convert.ToInt32(txtAño.Text)));
                    dgvResultado.DataSource = helper.Consultar("SP_CONSULTA_9", parametros);

                    break;
            }
            cboConsulta.Enabled = true;
            parametros.Clear();

        }
    }
}
