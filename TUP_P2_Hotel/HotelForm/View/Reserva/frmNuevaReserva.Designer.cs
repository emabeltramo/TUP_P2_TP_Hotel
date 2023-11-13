namespace HotelForm.View.Reserva
{
    partial class frmNuevaReserva
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
            cboClienteReserva = new ComboBox();
            btnCargarReserva = new Button();
            btnSalirReserva = new Button();
            btnCancelarReserva = new Button();
            lblCliente = new Label();
            gbFechas = new GroupBox();
            txbNoches = new TextBox();
            lblNoches = new Label();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            tab = new TabControl();
            tbpHabitacion = new TabPage();
            dgvNuevaReserva = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            CamaMax = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Reservar = new DataGridViewCheckBoxColumn();
            tbpServicio = new TabPage();
            dgvServicios = new DataGridView();
            IdSrv = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioSrv = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Bonificado = new DataGridViewCheckBoxColumn();
            gbHotel = new GroupBox();
            lblHotel = new Label();
            cboHotel = new ComboBox();
            lblLocalidad = new Label();
            cboLocalidad = new ComboBox();
            lblProvincias = new Label();
            cboProvincia = new ComboBox();
            btnBuscar = new Button();
            btnReiniciar = new Button();
            txbTotal = new TextBox();
            lblTotal = new Label();
            gbFechas.SuspendLayout();
            tab.SuspendLayout();
            tbpHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevaReserva).BeginInit();
            tbpServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            gbHotel.SuspendLayout();
            SuspendLayout();
            // 
            // cboClienteReserva
            // 
            cboClienteReserva.Anchor = AnchorStyles.None;
            cboClienteReserva.FormattingEnabled = true;
            cboClienteReserva.Location = new Point(67, 2);
            cboClienteReserva.Name = "cboClienteReserva";
            cboClienteReserva.Size = new Size(559, 23);
            cboClienteReserva.TabIndex = 0;
            // 
            // btnCargarReserva
            // 
            btnCargarReserva.Anchor = AnchorStyles.None;
            btnCargarReserva.Location = new Point(208, 443);
            btnCargarReserva.Name = "btnCargarReserva";
            btnCargarReserva.Size = new Size(75, 23);
            btnCargarReserva.TabIndex = 9;
            btnCargarReserva.Text = "Cargar";
            btnCargarReserva.UseVisualStyleBackColor = true;
            // 
            // btnSalirReserva
            // 
            btnSalirReserva.Anchor = AnchorStyles.None;
            btnSalirReserva.Location = new Point(325, 443);
            btnSalirReserva.Name = "btnSalirReserva";
            btnSalirReserva.Size = new Size(75, 23);
            btnSalirReserva.TabIndex = 10;
            btnSalirReserva.Text = "Salir";
            btnSalirReserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.Anchor = AnchorStyles.None;
            btnCancelarReserva.Location = new Point(435, 443);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(75, 23);
            btnCancelarReserva.TabIndex = 11;
            btnCancelarReserva.Text = "Cancelar";
            btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.None;
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(14, 5);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Cliente:";
            // 
            // gbFechas
            // 
            gbFechas.Controls.Add(txbNoches);
            gbFechas.Controls.Add(lblNoches);
            gbFechas.Controls.Add(lblHasta);
            gbFechas.Controls.Add(dtpHasta);
            gbFechas.Controls.Add(lblDesde);
            gbFechas.Controls.Add(dtpDesde);
            gbFechas.Location = new Point(330, 35);
            gbFechas.Name = "gbFechas";
            gbFechas.Size = new Size(310, 143);
            gbFechas.TabIndex = 29;
            gbFechas.TabStop = false;
            gbFechas.Text = "Fechas de la Reserva";
            // 
            // txbNoches
            // 
            txbNoches.Location = new Point(61, 92);
            txbNoches.Name = "txbNoches";
            txbNoches.Size = new Size(100, 23);
            txbNoches.TabIndex = 73;
            // 
            // lblNoches
            // 
            lblNoches.Anchor = AnchorStyles.None;
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(5, 97);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(50, 15);
            lblNoches.TabIndex = 72;
            lblNoches.Text = "Noches:";
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.None;
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(5, 69);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 21;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.None;
            dtpHasta.Location = new Point(52, 63);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(240, 23);
            dtpHasta.TabIndex = 20;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.None;
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(5, 40);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 19;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.None;
            dtpDesde.Location = new Point(52, 34);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(240, 23);
            dtpDesde.TabIndex = 18;
            // 
            // tab
            // 
            tab.Controls.Add(tbpHabitacion);
            tab.Controls.Add(tbpServicio);
            tab.Location = new Point(14, 179);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(713, 230);
            tab.TabIndex = 38;
            // 
            // tbpHabitacion
            // 
            tbpHabitacion.Controls.Add(dgvNuevaReserva);
            tbpHabitacion.Location = new Point(4, 24);
            tbpHabitacion.Name = "tbpHabitacion";
            tbpHabitacion.Padding = new Padding(3);
            tbpHabitacion.Size = new Size(705, 202);
            tbpHabitacion.TabIndex = 0;
            tbpHabitacion.Text = "Habitaciones";
            tbpHabitacion.UseVisualStyleBackColor = true;
            // 
            // dgvNuevaReserva
            // 
            dgvNuevaReserva.AllowUserToAddRows = false;
            dgvNuevaReserva.AllowUserToDeleteRows = false;
            dgvNuevaReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevaReserva.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Categoria, CamaMax, Precio, Reservar });
            dgvNuevaReserva.Dock = DockStyle.Fill;
            dgvNuevaReserva.Location = new Point(3, 3);
            dgvNuevaReserva.Name = "dgvNuevaReserva";
            dgvNuevaReserva.RowTemplate.Height = 25;
            dgvNuevaReserva.Size = new Size(699, 196);
            dgvNuevaReserva.TabIndex = 39;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // CamaMax
            // 
            CamaMax.HeaderText = "Cama Max";
            CamaMax.Name = "CamaMax";
            CamaMax.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Reservar
            // 
            Reservar.HeaderText = "Reservar";
            Reservar.Name = "Reservar";
            // 
            // tbpServicio
            // 
            tbpServicio.Controls.Add(dgvServicios);
            tbpServicio.Location = new Point(4, 24);
            tbpServicio.Name = "tbpServicio";
            tbpServicio.Padding = new Padding(3);
            tbpServicio.Size = new Size(705, 202);
            tbpServicio.TabIndex = 1;
            tbpServicio.Text = "Servicios";
            tbpServicio.UseVisualStyleBackColor = true;
            // 
            // dgvServicios
            // 
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Columns.AddRange(new DataGridViewColumn[] { IdSrv, Descripcion, PrecioSrv, Cantidad, Bonificado });
            dgvServicios.Dock = DockStyle.Fill;
            dgvServicios.Location = new Point(3, 3);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowTemplate.Height = 25;
            dgvServicios.Size = new Size(699, 196);
            dgvServicios.TabIndex = 0;
            // 
            // IdSrv
            // 
            IdSrv.HeaderText = "Id";
            IdSrv.Name = "IdSrv";
            IdSrv.ReadOnly = true;
            IdSrv.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // PrecioSrv
            // 
            PrecioSrv.HeaderText = "Precio";
            PrecioSrv.Name = "PrecioSrv";
            PrecioSrv.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Bonificado
            // 
            Bonificado.HeaderText = "Bonificado";
            Bonificado.Name = "Bonificado";
            Bonificado.Resizable = DataGridViewTriState.True;
            Bonificado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // gbHotel
            // 
            gbHotel.Controls.Add(lblHotel);
            gbHotel.Controls.Add(cboHotel);
            gbHotel.Controls.Add(lblLocalidad);
            gbHotel.Controls.Add(cboLocalidad);
            gbHotel.Controls.Add(lblProvincias);
            gbHotel.Controls.Add(cboProvincia);
            gbHotel.Location = new Point(14, 35);
            gbHotel.Name = "gbHotel";
            gbHotel.Size = new Size(310, 143);
            gbHotel.TabIndex = 39;
            gbHotel.TabStop = false;
            gbHotel.Text = "Hotel";
            // 
            // lblHotel
            // 
            lblHotel.Anchor = AnchorStyles.None;
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(62, 97);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(39, 15);
            lblHotel.TabIndex = 71;
            lblHotel.Text = "Hotel:";
            // 
            // cboHotel
            // 
            cboHotel.Anchor = AnchorStyles.None;
            cboHotel.FormattingEnabled = true;
            cboHotel.Location = new Point(107, 89);
            cboHotel.Name = "cboHotel";
            cboHotel.Size = new Size(162, 23);
            cboHotel.TabIndex = 70;
            // 
            // lblLocalidad
            // 
            lblLocalidad.Anchor = AnchorStyles.None;
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(42, 63);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 69;
            lblLocalidad.Text = "Localidad:";
            // 
            // cboLocalidad
            // 
            cboLocalidad.Anchor = AnchorStyles.None;
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(107, 60);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(162, 23);
            cboLocalidad.TabIndex = 68;
            // 
            // lblProvincias
            // 
            lblProvincias.Anchor = AnchorStyles.None;
            lblProvincias.AutoSize = true;
            lblProvincias.Location = new Point(42, 34);
            lblProvincias.Name = "lblProvincias";
            lblProvincias.Size = new Size(59, 15);
            lblProvincias.TabIndex = 67;
            lblProvincias.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            cboProvincia.Anchor = AnchorStyles.None;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(107, 31);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(162, 23);
            cboProvincia.TabIndex = 66;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Location = new Point(658, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(61, 23);
            btnBuscar.TabIndex = 74;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.None;
            btnReiniciar.Location = new Point(658, 104);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(61, 23);
            btnReiniciar.TabIndex = 75;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // txbTotal
            // 
            txbTotal.Location = new Point(616, 407);
            txbTotal.Name = "txbTotal";
            txbTotal.ReadOnly = true;
            txbTotal.Size = new Size(100, 23);
            txbTotal.TabIndex = 77;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(560, 412);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 76;
            lblTotal.Text = "Total:";
            // 
            // frmNuevaReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(txbTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnReiniciar);
            Controls.Add(btnBuscar);
            Controls.Add(gbHotel);
            Controls.Add(tab);
            Controls.Add(gbFechas);
            Controls.Add(lblCliente);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnSalirReserva);
            Controls.Add(btnCargarReserva);
            Controls.Add(cboClienteReserva);
            Name = "frmNuevaReserva";
            Text = "NuevaReserva";
            Load += frmNuevaReserva_Load_1;
            gbFechas.ResumeLayout(false);
            gbFechas.PerformLayout();
            tab.ResumeLayout(false);
            tbpHabitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNuevaReserva).EndInit();
            tbpServicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            gbHotel.ResumeLayout(false);
            gbHotel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboClienteReserva;
        private Button btnCargarReserva;
        private Button btnSalirReserva;
        private Button btnCancelarReserva;
        private Label lblCliente;
        private GroupBox gbFechas;
        private TabControl tab;
        private TabPage tbpHabitacion;
        private DataGridView dgvNuevaReserva;
        private TabPage tbpServicio;
        private GroupBox gbHotel;
        private Label lblNoches;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHotel;
        private ComboBox cboHotel;
        private Label lblLocalidad;
        private ComboBox cboLocalidad;
        private Label lblProvincias;
        private ComboBox cboProvincia;
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
    }
}