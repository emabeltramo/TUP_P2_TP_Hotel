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
            cboServicio = new ComboBox();
            cboCliente = new ComboBox();
            btnCargar = new Button();
            btnSalir = new Button();
            btnCancelar = new Button();
            gbDetalle = new GroupBox();
            txtTotal = new TextBox();
            btnAgregar = new Button();
            dtpFecha = new DateTimePicker();
            cboReserva = new ComboBox();
            cboTipoFactura = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numCantidad = new NumericUpDown();
            dgvFormasPago = new DataGridView();
            btnAgregarFormaPago = new Button();
            cboFormaPago = new ComboBox();
            label7 = new Label();
            IdFormaPago = new DataGridViewTextBoxColumn();
            colFormaPago = new DataGridViewTextBoxColumn();
            actionCol = new DataGridViewButtonColumn();
            idDetalle = new DataGridViewTextBoxColumn();
            colServicio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
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
            dgvDetalles.Location = new Point(6, 55);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(764, 150);
            dgvDetalles.TabIndex = 0;
            // 
            // cboServicio
            // 
            cboServicio.FormattingEnabled = true;
            cboServicio.Location = new Point(6, 26);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(413, 23);
            cboServicio.TabIndex = 1;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(123, 91);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(353, 23);
            cboCliente.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(248, 506);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(363, 506);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(482, 506);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(numCantidad);
            gbDetalle.Controls.Add(label6);
            gbDetalle.Controls.Add(btnAgregar);
            gbDetalle.Controls.Add(txtTotal);
            gbDetalle.Controls.Add(dgvDetalles);
            gbDetalle.Controls.Add(cboServicio);
            gbDetalle.Location = new Point(12, 247);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(776, 253);
            gbDetalle.TabIndex = 7;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(670, 211);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(653, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(123, 62);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(212, 23);
            dtpFecha.TabIndex = 8;
            // 
            // cboReserva
            // 
            cboReserva.FormattingEnabled = true;
            cboReserva.Location = new Point(123, 120);
            cboReserva.Name = "cboReserva";
            cboReserva.Size = new Size(353, 23);
            cboReserva.TabIndex = 9;
            // 
            // cboTipoFactura
            // 
            cboTipoFactura.FormattingEnabled = true;
            cboTipoFactura.Location = new Point(123, 170);
            cboTipoFactura.Name = "cboTipoFactura";
            cboTipoFactura.Size = new Size(146, 23);
            cboTipoFactura.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 26);
            label1.TabIndex = 11;
            label1.Text = "Factura N°: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 94);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 12;
            label2.Text = "Cliente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 68);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Fecha: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 173);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo de Factura: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 123);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Reserva: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(600, 210);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Total $";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(425, 27);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(222, 23);
            numCantidad.TabIndex = 6;
            // 
            // dgvFormasPago
            // 
            dgvFormasPago.AllowUserToAddRows = false;
            dgvFormasPago.AllowUserToDeleteRows = false;
            dgvFormasPago.AllowUserToResizeColumns = false;
            dgvFormasPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormasPago.Columns.AddRange(new DataGridViewColumn[] { IdFormaPago, colFormaPago, actionCol });
            dgvFormasPago.Location = new Point(482, 56);
            dgvFormasPago.Name = "dgvFormasPago";
            dgvFormasPago.ReadOnly = true;
            dgvFormasPago.RowTemplate.Height = 25;
            dgvFormasPago.Size = new Size(300, 185);
            dgvFormasPago.TabIndex = 16;
            // 
            // btnAgregarFormaPago
            // 
            btnAgregarFormaPago.Location = new Point(389, 218);
            btnAgregarFormaPago.Name = "btnAgregarFormaPago";
            btnAgregarFormaPago.Size = new Size(87, 23);
            btnAgregarFormaPago.TabIndex = 17;
            btnAgregarFormaPago.Text = "Agregar";
            btnAgregarFormaPago.UseVisualStyleBackColor = true;
            // 
            // cboFormaPago
            // 
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(123, 218);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(260, 23);
            cboFormaPago.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 221);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 19;
            label7.Text = "Forma de Pago: ";
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
            // frmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(label7);
            Controls.Add(cboFormaPago);
            Controls.Add(btnAgregarFormaPago);
            Controls.Add(dgvFormasPago);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numCantidad;
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
    }
}