namespace HotelForm.View.Reserva
{
    partial class frmViewReserva
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
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbHNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbHabitaciones = new System.Windows.Forms.GroupBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.gbServico = new System.Windows.Forms.GroupBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CamaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente.SuspendLayout();
            this.gbHotel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.gbServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
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
            this.gbCliente.Size = new System.Drawing.Size(715, 109);
            this.gbCliente.TabIndex = 0;
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
            // gbHotel
            // 
            this.gbHotel.Controls.Add(this.txbDireccion);
            this.gbHotel.Controls.Add(this.label5);
            this.gbHotel.Controls.Add(this.txbHNombre);
            this.gbHotel.Controls.Add(this.label6);
            this.gbHotel.Location = new System.Drawing.Point(12, 127);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Size = new System.Drawing.Size(355, 107);
            this.gbHotel.TabIndex = 1;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(70, 61);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(252, 23);
            this.txbDireccion.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Direccion:";
            // 
            // txbHNombre
            // 
            this.txbHNombre.Location = new System.Drawing.Point(70, 25);
            this.txbHNombre.Name = "txbHNombre";
            this.txbHNombre.Size = new System.Drawing.Size(252, 23);
            this.txbHNombre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(372, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 107);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(55, 61);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(252, 23);
            this.dtpHasta.TabIndex = 21;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(55, 25);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(252, 23);
            this.dtpDesde.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Desde:";
            // 
            // gbHabitaciones
            // 
            this.gbHabitaciones.Controls.Add(this.dgvHabitaciones);
            this.gbHabitaciones.Location = new System.Drawing.Point(12, 240);
            this.gbHabitaciones.Name = "gbHabitaciones";
            this.gbHabitaciones.Size = new System.Drawing.Size(355, 183);
            this.gbHabitaciones.TabIndex = 17;
            this.gbHabitaciones.TabStop = false;
            this.gbHabitaciones.Text = "Habitaciones";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Categoria,
            this.CamaMax,
            this.Monto});
            this.dgvHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHabitaciones.Location = new System.Drawing.Point(3, 19);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowTemplate.Height = 25;
            this.dgvHabitaciones.Size = new System.Drawing.Size(349, 161);
            this.dgvHabitaciones.TabIndex = 0;
            // 
            // gbServico
            // 
            this.gbServico.Controls.Add(this.dgvServicios);
            this.gbServico.Location = new System.Drawing.Point(372, 240);
            this.gbServico.Name = "gbServico";
            this.gbServico.Size = new System.Drawing.Size(355, 183);
            this.gbServico.TabIndex = 18;
            this.gbServico.TabStop = false;
            this.gbServico.Text = "Servicios";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.Bonificado,
            this.dataGridViewTextBoxColumn1});
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(3, 19);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowTemplate.Height = 25;
            this.dgvServicios.Size = new System.Drawing.Size(349, 161);
            this.dgvServicios.TabIndex = 0;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(310, 447);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(111, 23);
            this.btnAnular.TabIndex = 19;
            this.btnAnular.Text = "Anular Reserva";
            this.btnAnular.UseVisualStyleBackColor = true;
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
            this.CamaMax.HeaderText = "CamaMax";
            this.CamaMax.Name = "CamaMax";
            this.CamaMax.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Bonificado
            // 
            this.Bonificado.HeaderText = "Bonificado";
            this.Bonificado.Name = "Bonificado";
            this.Bonificado.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmViewReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.gbServico);
            this.Controls.Add(this.gbHabitaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHotel);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmViewReserva";
            this.Text = "frmViewReserva";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbHotel.ResumeLayout(false);
            this.gbHotel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHabitaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.gbServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

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
        private GroupBox gbHotel;
        private TextBox txbDireccion;
        private Label label5;
        private TextBox txbHNombre;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private GroupBox gbHabitaciones;
        private DataGridView dgvHabitaciones;
        private GroupBox gbServico;
        private DataGridView dgvServicios;
        private Button btnAnular;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn CamaMax;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewCheckBoxColumn Bonificado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}