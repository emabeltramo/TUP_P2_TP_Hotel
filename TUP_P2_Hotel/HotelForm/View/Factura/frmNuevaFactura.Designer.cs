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
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboReserva = new System.Windows.Forms.ComboBox();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.colServicio,
            this.colCantidad,
            this.colPrecio});
            this.dgvDetalles.Location = new System.Drawing.Point(6, 22);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowTemplate.Height = 25;
            this.dgvDetalles.Size = new System.Drawing.Size(703, 264);
            this.dgvDetalles.TabIndex = 0;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(87, 90);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(212, 23);
            this.cboCliente.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(218, 450);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(333, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(452, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.label1);
            this.gbDetalle.Controls.Add(this.txtFinal);
            this.gbDetalle.Controls.Add(this.dgvDetalles);
            this.gbDetalle.Location = new System.Drawing.Point(12, 123);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(715, 321);
            this.gbDetalle.TabIndex = 7;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(539, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total $";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(609, 292);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 23);
            this.txtFinal.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(80, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(212, 23);
            this.dtpFecha.TabIndex = 8;
            // 
            // cboReserva
            // 
            this.cboReserva.FormattingEnabled = true;
            this.cboReserva.Location = new System.Drawing.Point(461, 94);
            this.cboReserva.Name = "cboReserva";
            this.cboReserva.Size = new System.Drawing.Size(260, 23);
            this.cboReserva.TabIndex = 9;
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(398, 58);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(48, 23);
            this.cboTipoFactura.TabIndex = 10;
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroFactura.Location = new System.Drawing.Point(12, 21);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(112, 26);
            this.lblNroFactura.TabIndex = 11;
            this.lblNroFactura.Text = "Factura N°: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Factura: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reserva: ";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(551, 58);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(163, 23);
            this.cboFormaPago.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Forma de Pago: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(305, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // idDetalle
            // 
            this.idDetalle.HeaderText = "colId";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // colServicio
            // 
            this.colServicio.HeaderText = "Servicio";
            this.colServicio.Name = "colServicio";
            this.colServicio.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // frmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 478);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.cboReserva);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cboCliente);
            this.Name = "frmNuevaFactura";
            this.Text = "NuevaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDetalles;
        private ComboBox cboCliente;
        private Button btnCargar;
        private Button btnSalir;
        private Button btnCancelar;
        private GroupBox gbDetalle;
        private DateTimePicker dtpFecha;
        private ComboBox cboReserva;
        private ComboBox cboTipoFactura;
        private Label lblNroFactura;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboFormaPago;
        private Label label7;
        private Button btnBuscar;
        private Label label1;
        private TextBox txtFinal;
        private DataGridViewTextBoxColumn idDetalle;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
    }
}