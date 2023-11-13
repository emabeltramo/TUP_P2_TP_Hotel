namespace HotelForm.View.Factura
{
    partial class frmNuevaFactura
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
            dgvDetalles = new DataGridView();
            idDetalle = new DataGridViewTextBoxColumn();
            colServicio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            cboServicio = new ComboBox();
            cboCliente = new ComboBox();
            btnCargar = new Button();
            btnSalir = new Button();
            btnCancelar = new Button();
            gbDetalle = new GroupBox();
            txtCantidad = new TextBox();
            txtMonto = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            txtTotal = new TextBox();
            dtpFecha = new DateTimePicker();
            cboReserva = new ComboBox();
            cboTipoFactura = new ComboBox();
            lblNroFactura = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvFormasPago = new DataGridView();
            IdFormaPago = new DataGridViewTextBoxColumn();
            colFormaPago = new DataGridViewTextBoxColumn();
            actionCol = new DataGridViewButtonColumn();
            btnAgregarFormaPago = new Button();
            cboFormaPago = new ComboBox();
            label7 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormasPago).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AllowUserToResizeColumns = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { idDetalle, colServicio, colCantidad, colPrecio, colAcciones });
            dgvDetalles.Location = new Point(6, 68);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(764, 150);
            dgvDetalles.TabIndex = 0;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // idDetalle
            // 
            idDetalle.HeaderText = "colId";
            idDetalle.Name = "idDetalle";
            idDetalle.ReadOnly = true;
            idDetalle.Visible = false;
            // 
            // colServicio
            // 
            colServicio.HeaderText = "Servicio";
            colServicio.Name = "colServicio";
            colServicio.ReadOnly = true;
            colServicio.Width = 295;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 150;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 150;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "Quitar";
            colAcciones.UseColumnTextForButtonValue = true;
            colAcciones.Width = 125;
            // 
            // cboServicio
            // 
            cboServicio.FormattingEnabled = true;
            cboServicio.Location = new Point(6, 39);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(360, 23);
            cboServicio.TabIndex = 1;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(129, 90);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(260, 23);
            cboCliente.TabIndex = 2;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(248, 506);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(363, 506);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(482, 506);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(txtCantidad);
            gbDetalle.Controls.Add(txtMonto);
            gbDetalle.Controls.Add(label10);
            gbDetalle.Controls.Add(label9);
            gbDetalle.Controls.Add(label8);
            gbDetalle.Controls.Add(label6);
            gbDetalle.Controls.Add(btnAgregar);
            gbDetalle.Controls.Add(txtTotal);
            gbDetalle.Controls.Add(dgvDetalles);
            gbDetalle.Controls.Add(cboServicio);
            gbDetalle.Location = new Point(12, 246);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(776, 254);
            gbDetalle.TabIndex = 7;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(372, 39);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(131, 23);
            txtCantidad.TabIndex = 11;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(509, 39);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(138, 23);
            txtMonto.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(509, 21);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 9;
            label10.Text = "Monto $:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 21);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 8;
            label9.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 21);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Servicio: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(600, 223);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Total $";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(653, 39);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(670, 224);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(129, 61);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(212, 23);
            dtpFecha.TabIndex = 8;
            // 
            // cboReserva
            // 
            cboReserva.FormattingEnabled = true;
            cboReserva.Location = new Point(129, 131);
            cboReserva.Name = "cboReserva";
            cboReserva.Size = new Size(353, 23);
            cboReserva.TabIndex = 9;
            // 
            // cboTipoFactura
            // 
            cboTipoFactura.FormattingEnabled = true;
            cboTipoFactura.Location = new Point(129, 188);
            cboTipoFactura.Name = "cboTipoFactura";
            cboTipoFactura.Size = new Size(146, 23);
            cboTipoFactura.TabIndex = 10;
            // 
            // lblNroFactura
            // 
            lblNroFactura.AutoSize = true;
            lblNroFactura.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroFactura.Location = new Point(12, 21);
            lblNroFactura.Name = "lblNroFactura";
            lblNroFactura.Size = new Size(112, 26);
            lblNroFactura.TabIndex = 11;
            lblNroFactura.Text = "Factura N°: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 12;
            label2.Text = "Cliente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 67);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Fecha: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 191);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo de Factura: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 134);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Reserva: ";
            // 
            // dgvFormasPago
            // 
            dgvFormasPago.AllowUserToAddRows = false;
            dgvFormasPago.AllowUserToDeleteRows = false;
            dgvFormasPago.AllowUserToResizeColumns = false;
            dgvFormasPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormasPago.Columns.AddRange(new DataGridViewColumn[] { IdFormaPago, colFormaPago, actionCol });
            dgvFormasPago.Location = new Point(488, 55);
            dgvFormasPago.Name = "dgvFormasPago";
            dgvFormasPago.ReadOnly = true;
            dgvFormasPago.RowTemplate.Height = 25;
            dgvFormasPago.Size = new Size(300, 185);
            dgvFormasPago.TabIndex = 16;
            dgvFormasPago.CellContentClick += dgvFormasPago_CellContentClick;
            // 
            // IdFormaPago
            // 
            IdFormaPago.HeaderText = "ID";
            IdFormaPago.Name = "IdFormaPago";
            IdFormaPago.ReadOnly = true;
            IdFormaPago.Visible = false;
            // 
            // colFormaPago
            // 
            colFormaPago.HeaderText = "Forma de Pago";
            colFormaPago.Name = "colFormaPago";
            colFormaPago.ReadOnly = true;
            colFormaPago.Width = 157;
            // 
            // actionCol
            // 
            actionCol.HeaderText = "Acciones";
            actionCol.Name = "actionCol";
            actionCol.ReadOnly = true;
            actionCol.Resizable = DataGridViewTriState.True;
            actionCol.Text = "Quitar";
            actionCol.UseColumnTextForButtonValue = true;
            // 
            // btnAgregarFormaPago
            // 
            btnAgregarFormaPago.Location = new Point(395, 217);
            btnAgregarFormaPago.Name = "btnAgregarFormaPago";
            btnAgregarFormaPago.Size = new Size(87, 23);
            btnAgregarFormaPago.TabIndex = 17;
            btnAgregarFormaPago.Text = "Agregar";
            btnAgregarFormaPago.UseVisualStyleBackColor = true;
            btnAgregarFormaPago.Click += btnAgregarFormaPago_Click;
            // 
            // cboFormaPago
            // 
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(129, 217);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(260, 23);
            cboFormaPago.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 220);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 19;
            label7.Text = "Forma de Pago: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(395, 89);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(87, 23);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(cboFormaPago);
            Controls.Add(btnAgregarFormaPago);
            Controls.Add(dgvFormasPago);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNroFactura);
            Controls.Add(cboTipoFactura);
            Controls.Add(cboReserva);
            Controls.Add(dtpFecha);
            Controls.Add(gbDetalle);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(cboCliente);
            Name = "frmNuevaFactura";
            Text = "NuevaFactura";
            Load += frmNuevaFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormasPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalles;
        private ComboBox cboServicio;
        private ComboBox cboCliente;
        private Button btnCargar;
        private Button btnSalir;
        private Button btnCancelar;
        private GroupBox gbDetalle;
        private Button btnAgregar;
        private TextBox txtTotal;
        private DateTimePicker dtpFecha;
        private Label label6;
        private ComboBox cboReserva;
        private ComboBox cboTipoFactura;
        private Label lblNroFactura;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvFormasPago;
        private DataGridViewTextBoxColumn idDetalle;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewButtonColumn colAcciones;
        private DataGridViewTextBoxColumn IdFormaPago;
        private DataGridViewTextBoxColumn colFormaPago;
        private DataGridViewButtonColumn actionCol;
        private Button btnAgregarFormaPago;
        private ComboBox cboFormaPago;
        private Label label7;
        private TextBox txtCantidad;
        private TextBox txtMonto;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnBuscar;
    }
}