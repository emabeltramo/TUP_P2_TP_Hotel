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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ColModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColModificar,
            this.ColEliminar});
            this.dgvClientes.Location = new System.Drawing.Point(37, 97);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(626, 246);
            this.dgvClientes.TabIndex = 0;
            // 
            // ColModificar
            // 
            this.ColModificar.HeaderText = "Modificar";
            this.ColModificar.Name = "ColModificar";
            this.ColModificar.ReadOnly = true;
            this.ColModificar.Text = "Modificar";
            this.ColModificar.UseColumnTextForButtonValue = true;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Text = "Eliminar";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(443, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(88, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 23);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(296, 365);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnAtras;
        private DataGridViewButtonColumn ColModificar;
        private DataGridViewButtonColumn ColEliminar;
    }
}