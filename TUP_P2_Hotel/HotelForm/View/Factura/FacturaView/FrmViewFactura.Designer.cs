namespace HotelForm.View.Factura.FacturaView
{
    partial class FrmViewFactura
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
            gbCliente = new GroupBox();
            txbTelefono = new TextBox();
            label4 = new Label();
            txbMail = new TextBox();
            label3 = new Label();
            txbDni = new TextBox();
            label2 = new Label();
            txbNombre = new TextBox();
            label1 = new Label();
            gbFactura = new GroupBox();
            txtTipoFactura = new TextBox();
            label11 = new Label();
            dtpFecha = new DateTimePicker();
            dgvFormaPago = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            btnCerrar = new Button();
            gbReserva = new GroupBox();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            txtIdReserva = new TextBox();
            txtEstado = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            dgvDetalle = new DataGridView();
            ColIdDetalle = new DataGridViewTextBoxColumn();
            ColServicio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColMonto = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            label12 = new Label();
            ColFormPago = new DataGridViewTextBoxColumn();
            gbCliente.SuspendLayout();
            gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormaPago).BeginInit();
            gbReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(txbTelefono);
            gbCliente.Controls.Add(label4);
            gbCliente.Controls.Add(txbMail);
            gbCliente.Controls.Add(label3);
            gbCliente.Controls.Add(txbDni);
            gbCliente.Controls.Add(label2);
            gbCliente.Controls.Add(txbNombre);
            gbCliente.Controls.Add(label1);
            gbCliente.Location = new Point(12, 12);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(713, 98);
            gbCliente.TabIndex = 1;
            gbCliente.TabStop = false;
            gbCliente.Text = "Cliente";
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(400, 60);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(252, 23);
            txbTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 64);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefono:";
            // 
            // txbMail
            // 
            txbMail.Location = new Point(70, 60);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(252, 23);
            txbMail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 63);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Mail:";
            // 
            // txbDni
            // 
            txbDni.Location = new Point(400, 21);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(252, 23);
            txbDni.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 25);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "DNI/CUIT:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(70, 21);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(252, 23);
            txbNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // gbFactura
            // 
            gbFactura.Controls.Add(txtTipoFactura);
            gbFactura.Controls.Add(label11);
            gbFactura.Controls.Add(dtpFecha);
            gbFactura.Controls.Add(dgvFormaPago);
            gbFactura.Controls.Add(label7);
            gbFactura.Controls.Add(label6);
            gbFactura.Location = new Point(12, 116);
            gbFactura.Name = "gbFactura";
            gbFactura.Size = new Size(425, 140);
            gbFactura.TabIndex = 2;
            gbFactura.TabStop = false;
            gbFactura.Text = "Factura";
            // 
            // txtTipoFactura
            // 
            txtTipoFactura.Location = new Point(91, 106);
            txtTipoFactura.Name = "txtTipoFactura";
            txtTipoFactura.Size = new Size(112, 23);
            txtTipoFactura.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 19);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 22;
            label11.Text = "Forma de Pago: ";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(91, 77);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(112, 23);
            dtpFecha.TabIndex = 21;
            // 
            // dgvFormaPago
            // 
            dgvFormaPago.AllowUserToAddRows = false;
            dgvFormaPago.AllowUserToDeleteRows = false;
            dgvFormaPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormaPago.Columns.AddRange(new DataGridViewColumn[] { ColFormPago });
            dgvFormaPago.Location = new Point(209, 19);
            dgvFormaPago.Name = "dgvFormaPago";
            dgvFormaPago.ReadOnly = true;
            dgvFormaPago.RowTemplate.Height = 25;
            dgvFormaPago.Size = new Size(210, 110);
            dgvFormaPago.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 83);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 2;
            label7.Text = "Fecha: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 114);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 1;
            label6.Text = "Factura Tipo: ";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(332, 460);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gbReserva
            // 
            gbReserva.Controls.Add(dtpHasta);
            gbReserva.Controls.Add(dtpDesde);
            gbReserva.Controls.Add(txtIdReserva);
            gbReserva.Controls.Add(txtEstado);
            gbReserva.Controls.Add(label10);
            gbReserva.Controls.Add(label9);
            gbReserva.Controls.Add(label5);
            gbReserva.Controls.Add(label8);
            gbReserva.Location = new Point(443, 116);
            gbReserva.Name = "gbReserva";
            gbReserva.Size = new Size(282, 140);
            gbReserva.TabIndex = 4;
            gbReserva.TabStop = false;
            gbReserva.Text = "Reserva";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(64, 109);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(210, 23);
            dtpHasta.TabIndex = 22;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(64, 80);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(210, 23);
            dtpDesde.TabIndex = 21;
            // 
            // txtIdReserva
            // 
            txtIdReserva.Location = new Point(64, 22);
            txtIdReserva.Name = "txtIdReserva";
            txtIdReserva.Size = new Size(210, 23);
            txtIdReserva.TabIndex = 6;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(64, 51);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(210, 23);
            txtEstado.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 114);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 4;
            label10.Text = "Salida: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 86);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 3;
            label9.Text = "Ingreso: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 25);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 2;
            label5.Text = "N°: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 54);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 1;
            label8.Text = "Estado: ";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { ColIdDetalle, ColServicio, ColCantidad, ColMonto });
            dgvDetalle.Location = new Point(12, 262);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(713, 163);
            dgvDetalle.TabIndex = 5;
            // 
            // ColIdDetalle
            // 
            ColIdDetalle.HeaderText = "Id";
            ColIdDetalle.Name = "ColIdDetalle";
            ColIdDetalle.ReadOnly = true;
            ColIdDetalle.Visible = false;
            // 
            // ColServicio
            // 
            ColServicio.HeaderText = "Servicio";
            ColServicio.Name = "ColServicio";
            ColServicio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColMonto
            // 
            ColMonto.HeaderText = "Monto";
            ColMonto.Name = "ColMonto";
            ColMonto.ReadOnly = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(601, 431);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(124, 23);
            txtTotal.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(536, 430);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 7;
            label12.Text = "Total$";
            // 
            // ColFormPago
            // 
            ColFormPago.HeaderText = "Forma de Pago";
            ColFormPago.Name = "ColFormPago";
            ColFormPago.ReadOnly = true;
            ColFormPago.Width = 167;
            // 
            // FrmViewFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 495);
            Controls.Add(label12);
            Controls.Add(txtTotal);
            Controls.Add(dgvDetalle);
            Controls.Add(gbReserva);
            Controls.Add(btnCerrar);
            Controls.Add(gbFactura);
            Controls.Add(gbCliente);
            Name = "FrmViewFactura";
            Text = "Factura N°";
            Load += FrmViewFactura_Load;
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbFactura.ResumeLayout(false);
            gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormaPago).EndInit();
            gbReserva.ResumeLayout(false);
            gbReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCliente;
        private TextBox txbTelefono;
        private Label label4;
        private TextBox txbMail;
        private Label label3;
        private TextBox txbDni;
        private Label label2;
        private TextBox txbNombre;
        private Label label1;
        private GroupBox gbFactura;
        private Button btnCerrar;
        private Label label7;
        private Label label6;
        private GroupBox gbReserva;
        private Label label5;
        private Label label8;
        private DataGridView dgvDetalle;
        private TextBox txtIdReserva;
        private TextBox txtEstado;
        private Label label10;
        private Label label9;
        private DataGridView dgvFormaPago;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private TextBox txtTipoFactura;
        private Label label11;
        private DateTimePicker dtpFecha;
        private DataGridViewTextBoxColumn ColIdDetalle;
        private DataGridViewTextBoxColumn ColServicio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColMonto;
        private TextBox txtTotal;
        private Label label12;
        private DataGridViewTextBoxColumn ColFormPago;
    }
}