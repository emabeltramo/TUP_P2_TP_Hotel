namespace HotelForm.View.Reserva
{
    partial class frmReservas
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
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblModSeleccion = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblModCliente = new System.Windows.Forms.Label();
            this.lblModFP = new System.Windows.Forms.Label();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHotel
            // 
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(48, 18);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(181, 23);
            this.cboHotel.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(598, 51);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblModSeleccion
            // 
            this.lblModSeleccion.AutoSize = true;
            this.lblModSeleccion.Location = new System.Drawing.Point(2, 21);
            this.lblModSeleccion.Name = "lblModSeleccion";
            this.lblModSeleccion.Size = new System.Drawing.Size(39, 15);
            this.lblModSeleccion.TabIndex = 3;
            this.lblModSeleccion.Text = "Hotel:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(290, 18);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(181, 23);
            this.cboCliente.TabIndex = 9;
            // 
            // lblModCliente
            // 
            this.lblModCliente.AutoSize = true;
            this.lblModCliente.Location = new System.Drawing.Point(236, 21);
            this.lblModCliente.Name = "lblModCliente";
            this.lblModCliente.Size = new System.Drawing.Size(47, 15);
            this.lblModCliente.TabIndex = 10;
            this.lblModCliente.Text = "Cliente:";
            // 
            // lblModFP
            // 
            this.lblModFP.AutoSize = true;
            this.lblModFP.Location = new System.Drawing.Point(2, 57);
            this.lblModFP.Name = "lblModFP";
            this.lblModFP.Size = new System.Drawing.Size(45, 15);
            this.lblModFP.TabIndex = 11;
            this.lblModFP.Text = "Desde: ";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.dtpHasta);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.dtpDesde);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.cboEstado);
            this.gbFiltro.Controls.Add(this.cboHotel);
            this.gbFiltro.Controls.Add(this.lblModSeleccion);
            this.gbFiltro.Controls.Add(this.lblModCliente);
            this.gbFiltro.Controls.Add(this.btnFiltrar);
            this.gbFiltro.Controls.Add(this.cboCliente);
            this.gbFiltro.Controls.Add(this.lblModFP);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(715, 87);
            this.gbFiltro.TabIndex = 17;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(335, 51);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(235, 23);
            this.dtpHasta.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Desde: ";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(48, 51);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(235, 23);
            this.dtpDesde.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(530, 18);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(181, 23);
            this.cboEstado.TabIndex = 11;
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Reserva,
            this.Estado,
            this.Desde,
            this.Hasta,
            this.Ver});
            this.dgvReserva.Location = new System.Drawing.Point(14, 116);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.RowTemplate.Height = 25;
            this.dgvReserva.Size = new System.Drawing.Size(713, 350);
            this.dgvReserva.TabIndex = 18;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Reserva
            // 
            this.Reserva.HeaderText = "Reserva";
            this.Reserva.Name = "Reserva";
            this.Reserva.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            this.Desde.ReadOnly = true;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 478);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.gbFiltro);
            this.Name = "frmReservas";
            this.Text = "ModificarReserva";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboHotel;
        private Button btnFiltrar;
        private Label lblModSeleccion;
        private ComboBox cboCliente;
        private Label lblModCliente;
        private Label lblModFP;
        private GroupBox gbFiltro;
        private DateTimePicker dtpHasta;
        private Label label2;
        private DateTimePicker dtpDesde;
        private Label label1;
        private ComboBox cboEstado;
        private DataGridView dgvReserva;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Reserva;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Desde;
        private DataGridViewTextBoxColumn Hasta;
        private DataGridViewButtonColumn Ver;
    }
}