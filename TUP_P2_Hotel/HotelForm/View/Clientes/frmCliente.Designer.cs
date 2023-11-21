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
            ColModificar = new DataGridViewButtonColumn();
            ColEliminar = new DataGridViewButtonColumn();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnAtras = new Button();
            gpxFiltros = new GroupBox();
            cbxApe = new CheckBox();
            cbxRazSoc = new CheckBox();
            cbxCuil = new CheckBox();
            cbxDni = new CheckBox();
            cbxNom = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gpxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColModificar, ColEliminar });
            dgvClientes.Location = new Point(27, 163);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(626, 246);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // ColModificar
            // 
            ColModificar.HeaderText = "Modificar";
            ColModificar.Name = "ColModificar";
            ColModificar.ReadOnly = true;
            ColModificar.Text = "Modificar";
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
            btnBuscar.Click += btnBuscar_Click;
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
            btnAtras.Location = new Point(285, 415);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // gpxFiltros
            // 
            gpxFiltros.Controls.Add(cbxApe);
            gpxFiltros.Controls.Add(cbxRazSoc);
            gpxFiltros.Controls.Add(cbxCuil);
            gpxFiltros.Controls.Add(cbxDni);
            gpxFiltros.Controls.Add(cbxNom);
            gpxFiltros.Location = new Point(45, 78);
            gpxFiltros.Name = "gpxFiltros";
            gpxFiltros.Size = new Size(542, 67);
            gpxFiltros.TabIndex = 8;
            gpxFiltros.TabStop = false;
            gpxFiltros.Text = "Filtros";
            // 
            // cbxApe
            // 
            cbxApe.AutoSize = true;
            cbxApe.Location = new Point(151, 33);
            cbxApe.Name = "cbxApe";
            cbxApe.Size = new Size(70, 19);
            cbxApe.TabIndex = 4;
            cbxApe.Text = "Apellido";
            cbxApe.UseVisualStyleBackColor = true;
            cbxApe.CheckedChanged += cbxApe_CheckedChanged;
            // 
            // cbxRazSoc
            // 
            cbxRazSoc.AutoSize = true;
            cbxRazSoc.Location = new Point(413, 33);
            cbxRazSoc.Name = "cbxRazSoc";
            cbxRazSoc.Size = new Size(92, 19);
            cbxRazSoc.TabIndex = 3;
            cbxRazSoc.Text = "Razon Social";
            cbxRazSoc.UseVisualStyleBackColor = true;
            cbxRazSoc.CheckedChanged += cbxRazSoc_CheckedChanged;
            // 
            // cbxCuil
            // 
            cbxCuil.AutoSize = true;
            cbxCuil.Location = new Point(323, 33);
            cbxCuil.Name = "cbxCuil";
            cbxCuil.Size = new Size(51, 19);
            cbxCuil.TabIndex = 2;
            cbxCuil.Text = "CUIL";
            cbxCuil.UseVisualStyleBackColor = true;
            cbxCuil.CheckedChanged += cbxCuil_CheckedChanged;
            // 
            // cbxDni
            // 
            cbxDni.AutoSize = true;
            cbxDni.Location = new Point(240, 33);
            cbxDni.Name = "cbxDni";
            cbxDni.Size = new Size(46, 19);
            cbxDni.TabIndex = 1;
            cbxDni.Text = "DNI";
            cbxDni.UseVisualStyleBackColor = true;
            cbxDni.CheckedChanged += cbxDni_CheckedChanged;
            // 
            // cbxNom
            // 
            cbxNom.AutoSize = true;
            cbxNom.Location = new Point(19, 33);
            cbxNom.Name = "cbxNom";
            cbxNom.Size = new Size(73, 19);
            cbxNom.TabIndex = 0;
            cbxNom.Text = "Nombre ";
            cbxNom.UseVisualStyleBackColor = true;
            cbxNom.CheckedChanged += cbxNom_CheckedChanged;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(gpxFiltros);
            Controls.Add(btnAtras);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvClientes);
            Name = "frmCliente";
            Text = "Clientes";
            Load += frmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gpxFiltros.ResumeLayout(false);
            gpxFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnAtras;
        private DataGridViewButtonColumn ColModificar;
        private DataGridViewButtonColumn ColEliminar;
        private GroupBox gpxFiltros;
        private CheckBox cbxRazSoc;
        private CheckBox cbxCuil;
        private CheckBox cbxDni;
        private CheckBox cbxNom;
        private CheckBox cbxApe;
    }
}