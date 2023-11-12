using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Clientes
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

            }
        }

        private bool Validar()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox combo)
                {

                    if (combo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una opcion de cada menu.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            foreach (Char c in txtNroDocumento.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Solo se pueden ingresar numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                break;
            }

            foreach (Char c in txtTelefono.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Solo se pueden ingresar numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                break;
            }

            return true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de cancelar el alta?","Atencion",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
