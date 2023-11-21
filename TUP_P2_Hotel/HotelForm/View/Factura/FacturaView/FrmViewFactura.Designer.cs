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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.txtTipoFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvFormaPago = new System.Windows.Forms.DataGridView();
            this.ColFormPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbReserva = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColIdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).BeginInit();
            this.gbReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txbTelefono);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.txbMail);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.txbDni);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.txbNombre);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(713, 98);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(400, 60);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(252, 23);
            this.txbTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(70, 60);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(252, 23);
            this.txbMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(400, 21);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(252, 23);
            this.txbDni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI/CUIT:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(70, 21);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(252, 23);
            this.txbNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.txtTipoFactura);
            this.gbFactura.Controls.Add(this.dtpFecha);
            this.gbFactura.Controls.Add(this.dgvFormaPago);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Controls.Add(this.label6);
            this.gbFactura.Location = new System.Drawing.Point(12, 116);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(425, 140);
            this.gbFactura.TabIndex = 2;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura.Location = new System.Drawing.Point(279, 25);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(112, 23);
            this.txtTipoFactura.TabIndex = 23;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(70, 25);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(112, 23);
            this.dtpFecha.TabIndex = 21;
            // 
            // dgvFormaPago
            // 
            this.dgvFormaPago.AllowUserToAddRows = false;
            this.dgvFormaPago.AllowUserToDeleteRows = false;
            this.dgvFormaPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFormPago});
            this.dgvFormaPago.Location = new System.Drawing.Point(20, 54);
            this.dgvFormaPago.Name = "dgvFormaPago";
            this.dgvFormaPago.ReadOnly = true;
            this.dgvFormaPago.RowTemplate.Height = 25;
            this.dgvFormaPago.Size = new System.Drawing.Size(375, 75);
            this.dgvFormaPago.TabIndex = 3;
            // 
            // ColFormPago
            // 
            this.ColFormPago.HeaderText = "Forma de Pago";
            this.ColFormPago.Name = "ColFormPago";
            this.ColFormPago.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Factura Tipo: ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(332, 460);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // gbReserva
            // 
            this.gbReserva.Controls.Add(this.dtpHasta);
            this.gbReserva.Controls.Add(this.dtpDesde);
            this.gbReserva.Controls.Add(this.txtIdReserva);
            this.gbReserva.Controls.Add(this.txtEstado);
            this.gbReserva.Controls.Add(this.label10);
            this.gbReserva.Controls.Add(this.label9);
            this.gbReserva.Controls.Add(this.label5);
            this.gbReserva.Controls.Add(this.label8);
            this.gbReserva.Location = new System.Drawing.Point(443, 116);
            this.gbReserva.Name = "gbReserva";
            this.gbReserva.Size = new System.Drawing.Size(282, 140);
            this.gbReserva.TabIndex = 4;
            this.gbReserva.TabStop = false;
            this.gbReserva.Text = "Reserva";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(64, 109);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(210, 23);
            this.dtpHasta.TabIndex = 22;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(64, 80);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(210, 23);
            this.dtpDesde.TabIndex = 21;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(64, 22);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(210, 23);
            this.txtIdReserva.TabIndex = 6;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(64, 51);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(210, 23);
            this.txtEstado.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Salida: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ingreso: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "N°: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Estado: ";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdDetalle,
            this.ColServicio,
            this.ColCantidad,
            this.ColMonto});
            this.dgvDetalle.Location = new System.Drawing.Point(12, 262);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowTemplate.Height = 25;
            this.dgvDetalle.Size = new System.Drawing.Size(713, 163);
            this.dgvDetalle.TabIndex = 5;
            // 
            // ColIdDetalle
            // 
            this.ColIdDetalle.HeaderText = "Id";
            this.ColIdDetalle.Name = "ColIdDetalle";
            this.ColIdDetalle.ReadOnly = true;
            this.ColIdDetalle.Visible = false;
            // 
            // ColServicio
            // 
            this.ColServicio.HeaderText = "Servicio";
            this.ColServicio.Name = "ColServicio";
            this.ColServicio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColMonto
            // 
            this.ColMonto.HeaderText = "Monto";
            this.ColMonto.Name = "ColMonto";
            this.ColMonto.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(601, 431);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 23);
            this.txtTotal.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(536, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Total$";
            // 
            // FrmViewFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.gbReserva);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbCliente);
            this.Name = "FrmViewFactura";
            this.Text = "Factura N°";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).EndInit();
            this.gbReserva.ResumeLayout(false);
            this.gbReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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