namespace HotelForm.View.Reserva
{
    partial class frmUpdateReserva
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
            this.btnCargarReserva = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbNoches = new System.Windows.Forms.TextBox();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.tab = new System.Windows.Forms.TabControl();
            this.tbpHabitacion = new System.Windows.Forms.TabPage();
            this.dgvNuevaReserva = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CamaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpServicio = new System.Windows.Forms.TabPage();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.IdSrv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioSrv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbHotel = new System.Windows.Forms.TextBox();
            this.tab.SuspendLayout();
            this.tbpHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaReserva)).BeginInit();
            this.tbpServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarReserva
            // 
            this.btnCargarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarReserva.Location = new System.Drawing.Point(382, 443);
            this.btnCargarReserva.Name = "btnCargarReserva";
            this.btnCargarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCargarReserva.TabIndex = 9;
            this.btnCargarReserva.Text = "Cargar";
            this.btnCargarReserva.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(14, 5);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            // 
            // txbNoches
            // 
            this.txbNoches.Location = new System.Drawing.Point(526, 65);
            this.txbNoches.Name = "txbNoches";
            this.txbNoches.Size = new System.Drawing.Size(100, 23);
            this.txbNoches.TabIndex = 73;
            // 
            // lblNoches
            // 
            this.lblNoches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(470, 70);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(50, 15);
            this.lblNoches.TabIndex = 72;
            this.lblNoches.Text = "Noches:";
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(336, 40);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 15);
            this.lblHasta.TabIndex = 21;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHasta.Location = new System.Drawing.Point(382, 36);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(244, 23);
            this.dtpHasta.TabIndex = 1;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tbpHabitacion);
            this.tab.Controls.Add(this.tbpServicio);
            this.tab.Location = new System.Drawing.Point(14, 94);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(713, 304);
            this.tab.TabIndex = 6;
            // 
            // tbpHabitacion
            // 
            this.tbpHabitacion.Controls.Add(this.dgvNuevaReserva);
            this.tbpHabitacion.Location = new System.Drawing.Point(4, 24);
            this.tbpHabitacion.Name = "tbpHabitacion";
            this.tbpHabitacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHabitacion.Size = new System.Drawing.Size(705, 276);
            this.tbpHabitacion.TabIndex = 0;
            this.tbpHabitacion.Text = "Habitaciones";
            this.tbpHabitacion.UseVisualStyleBackColor = true;
            // 
            // dgvNuevaReserva
            // 
            this.dgvNuevaReserva.AllowUserToAddRows = false;
            this.dgvNuevaReserva.AllowUserToDeleteRows = false;
            this.dgvNuevaReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuevaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevaReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Categoria,
            this.CamaMax,
            this.Precio,
            this.Reservar});
            this.dgvNuevaReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNuevaReserva.Location = new System.Drawing.Point(3, 3);
            this.dgvNuevaReserva.Name = "dgvNuevaReserva";
            this.dgvNuevaReserva.RowTemplate.Height = 25;
            this.dgvNuevaReserva.Size = new System.Drawing.Size(699, 270);
            this.dgvNuevaReserva.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // CamaMax
            // 
            this.CamaMax.HeaderText = "Cama Max";
            this.CamaMax.Name = "CamaMax";
            this.CamaMax.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Reservar
            // 
            this.Reservar.HeaderText = "Reservar";
            this.Reservar.Name = "Reservar";
            // 
            // tbpServicio
            // 
            this.tbpServicio.Controls.Add(this.dgvServicios);
            this.tbpServicio.Location = new System.Drawing.Point(4, 24);
            this.tbpServicio.Name = "tbpServicio";
            this.tbpServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpServicio.Size = new System.Drawing.Size(705, 202);
            this.tbpServicio.TabIndex = 1;
            this.tbpServicio.Text = "Servicios";
            this.tbpServicio.UseVisualStyleBackColor = true;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSrv,
            this.Descripcion,
            this.PrecioSrv,
            this.Cantidad,
            this.Bonificado});
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(3, 3);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowTemplate.Height = 25;
            this.dgvServicios.Size = new System.Drawing.Size(699, 196);
            this.dgvServicios.TabIndex = 0;
            // 
            // IdSrv
            // 
            this.IdSrv.HeaderText = "Id";
            this.IdSrv.Name = "IdSrv";
            this.IdSrv.ReadOnly = true;
            this.IdSrv.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioSrv
            // 
            this.PrecioSrv.HeaderText = "Precio";
            this.PrecioSrv.Name = "PrecioSrv";
            this.PrecioSrv.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Bonificado
            // 
            this.Bonificado.HeaderText = "Bonificado";
            this.Bonificado.Name = "Bonificado";
            this.Bonificado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bonificado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(646, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReiniciar.Location = new System.Drawing.Point(646, 17);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(61, 23);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(620, 404);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(100, 23);
            this.txbTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(575, 407);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 76;
            this.lblTotal.Text = "Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(249, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblHotel
            // 
            this.lblHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(336, 5);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(39, 15);
            this.lblHotel.TabIndex = 78;
            this.lblHotel.Text = "Hotel:";
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(19, 46);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 15);
            this.lblDesde.TabIndex = 80;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDesde.Location = new System.Drawing.Point(66, 40);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(244, 23);
            this.dtpDesde.TabIndex = 79;
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(67, 2);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(243, 23);
            this.txbCliente.TabIndex = 81;
            // 
            // txbHotel
            // 
            this.txbHotel.Location = new System.Drawing.Point(383, 2);
            this.txbHotel.Name = "txbHotel";
            this.txbHotel.Size = new System.Drawing.Size(243, 23);
            this.txbHotel.TabIndex = 82;
            // 
            // frmUpdateReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 478);
            this.Controls.Add(this.txbHotel);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.txbNoches);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCargarReserva);
            this.Name = "frmUpdateReserva";
            this.Text = "NuevaReserva";
            this.tab.ResumeLayout(false);
            this.tbpHabitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaReserva)).EndInit();
            this.tbpServicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCargarReserva;
        private Label lblCliente;
        private TabControl tab;
        private TabPage tbpHabitacion;
        private DataGridView dgvNuevaReserva;
        private TabPage tbpServicio;
        private Label lblNoches;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private TextBox txbNoches;
        private Button btnBuscar;
        private Button btnReiniciar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn CamaMax;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewCheckBoxColumn Reservar;
        private DataGridView dgvServicios;
        private DataGridViewTextBoxColumn IdSrv;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioSrv;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewCheckBoxColumn Bonificado;
        private TextBox txbTotal;
        private Label lblTotal;
        private Button btnCancelar;
        private Label lblHotel;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private TextBox txbCliente;
        private TextBox txbHotel;
    }
}