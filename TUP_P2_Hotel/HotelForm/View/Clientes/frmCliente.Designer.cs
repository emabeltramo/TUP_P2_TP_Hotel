namespace HotelForm.View.Clientes
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColTipoCliente = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColDoc = new DataGridViewTextBoxColumn();
            ColCuil = new DataGridViewTextBoxColumn();
            ColTipoRazonSocial = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColModificar = new DataGridViewButtonColumn();
            ColEliminar = new DataGridViewButtonColumn();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColId, ColTipoCliente, ColNombre, ColDoc, ColCuil, ColTipoRazonSocial, ColEmail, ColModificar, ColEliminar });
            dgvClientes.Location = new Point(48, 84);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(626, 246);
            dgvClientes.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColTipoCliente
            // 
            ColTipoCliente.HeaderText = "Tipo Cliente";
            ColTipoCliente.Name = "ColTipoCliente";
            ColTipoCliente.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre Cliente";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColDoc
            // 
            ColDoc.HeaderText = "Documento";
            ColDoc.Name = "ColDoc";
            ColDoc.ReadOnly = true;
            // 
            // ColCuil
            // 
            ColCuil.HeaderText = "CUIL";
            ColCuil.Name = "ColCuil";
            ColCuil.ReadOnly = true;
            // 
            // ColTipoRazonSocial
            // 
            ColTipoRazonSocial.HeaderText = "Razon Social";
            ColTipoRazonSocial.Name = "ColTipoRazonSocial";
            ColTipoRazonSocial.ReadOnly = true;
            // 
            // ColEmail
            // 
            ColEmail.HeaderText = "Email";
            ColEmail.Name = "ColEmail";
            ColEmail.ReadOnly = true;
            // 
            // ColModificar
            // 
            ColModificar.HeaderText = "Modificar";
            ColModificar.Name = "ColModificar";
            ColModificar.ReadOnly = true;
            ColModificar.ToolTipText = "Modificar";
            ColModificar.UseColumnTextForButtonValue = true;
            // 
            // ColEliminar
            // 
            ColEliminar.HeaderText = "Eliminar";
            ColEliminar.Name = "ColEliminar";
            ColEliminar.ReadOnly = true;
            ColEliminar.Text = "Eliminar";
            ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(443, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(88, 38);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(255, 23);
            txtBuscar.TabIndex = 6;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(296, 365);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(btnAtras);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvClientes);
            Name = "frmCliente";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColTipoCliente;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColDoc;
        private DataGridViewTextBoxColumn ColCuil;
        private DataGridViewTextBoxColumn ColTipoRazonSocial;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewButtonColumn ColModificar;
        private DataGridViewButtonColumn ColEliminar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnAtras;
    }
}