namespace HotelForm.View.Reportes
{
    partial class frmConsultas
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
            label1 = new Label();
            label2 = new Label();
            cboConsulta = new ComboBox();
            lblConsulta = new Label();
            lblEnunciado = new Label();
            txtSentencia = new TextBox();
            txtEnunciado = new TextBox();
            lblAño = new Label();
            txtAño = new TextBox();
            lblPorcentaje = new Label();
            txtPorcentaje = new TextBox();
            btnEjecutar = new Button();
            lblTipoCliente = new Label();
            lblNroPiso = new Label();
            txtNroPiso = new TextBox();
            label4 = new Label();
            cboTipoCliente = new ComboBox();
            txtNroFactura = new TextBox();
            lblNroFactura = new Label();
            dgvResultado = new DataGridView();
            lblResultado = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(291, 28);
            label1.Name = "label1";
            label1.Size = new Size(158, 45);
            label1.TabIndex = 0;
            label1.Text = "Consultas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 91);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 1;
            label2.Text = "Seleccionar consulta:";
            // 
            // cboConsulta
            // 
            cboConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsulta.FormattingEnabled = true;
            cboConsulta.Location = new Point(396, 91);
            cboConsulta.Name = "cboConsulta";
            cboConsulta.Size = new Size(180, 23);
            cboConsulta.TabIndex = 0;
            cboConsulta.SelectedIndexChanged += cboConsulta_SelectedIndexChanged;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsulta.Location = new Point(310, 249);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(110, 21);
            lblConsulta.TabIndex = 4;
            lblConsulta.Text = "Sentencia SQL";
            lblConsulta.Click += lblConsulta_Click;
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnunciado.Location = new Point(316, 143);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(82, 21);
            lblEnunciado.TabIndex = 10;
            lblEnunciado.Text = "Enunciado";
            // 
            // txtSentencia
            // 
            txtSentencia.Location = new Point(55, 273);
            txtSentencia.Multiline = true;
            txtSentencia.Name = "txtSentencia";
            txtSentencia.ReadOnly = true;
            txtSentencia.ScrollBars = ScrollBars.Vertical;
            txtSentencia.Size = new Size(668, 130);
            txtSentencia.TabIndex = 11;
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(55, 167);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.ReadOnly = true;
            txtEnunciado.ScrollBars = ScrollBars.Vertical;
            txtEnunciado.Size = new Size(668, 70);
            txtEnunciado.TabIndex = 12;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAño.Location = new Point(209, 499);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(41, 21);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(256, 499);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(67, 23);
            txtAño.TabIndex = 4;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorcentaje.Location = new Point(348, 499);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(85, 21);
            lblPorcentaje.TabIndex = 15;
            lblPorcentaje.Text = "Porcentaje:";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(439, 497);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(67, 23);
            txtPorcentaje.TabIndex = 5;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(307, 548);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(110, 23);
            btnEjecutar.TabIndex = 6;
            btnEjecutar.Text = "Ejecutar Consulta";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(220, 459);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(99, 21);
            lblTipoCliente.TabIndex = 18;
            lblTipoCliente.Text = "Tipo Cliente: ";
            // 
            // lblNroPiso
            // 
            lblNroPiso.AutoSize = true;
            lblNroPiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroPiso.Location = new Point(52, 461);
            lblNroPiso.Name = "lblNroPiso";
            lblNroPiso.Size = new Size(73, 21);
            lblNroPiso.TabIndex = 19;
            lblNroPiso.Text = "Nro Piso:";
            lblNroPiso.Click += lblNroPiso_Click;
            // 
            // txtNroPiso
            // 
            txtNroPiso.Location = new Point(131, 457);
            txtNroPiso.Name = "txtNroPiso";
            txtNroPiso.Size = new Size(67, 23);
            txtNroPiso.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(316, 416);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 23;
            label4.Text = "Parametros";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(325, 459);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(121, 23);
            cboTipoCliente.TabIndex = 2;
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(580, 459);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(121, 23);
            txtNroFactura.TabIndex = 3;
            // 
            // lblNroFactura
            // 
            lblNroFactura.AutoSize = true;
            lblNroFactura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroFactura.Location = new Point(475, 461);
            lblNroFactura.Name = "lblNroFactura";
            lblNroFactura.Size = new Size(94, 21);
            lblNroFactura.TabIndex = 25;
            lblNroFactura.Text = "Nro Factura:";
            // 
            // dgvResultado
            // 
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(39, 621);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultado.Size = new Size(704, 176);
            dgvResultado.TabIndex = 11;
            dgvResultado.CellContentClick += dgvResultado_CellContentClick;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(325, 597);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(79, 21);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(316, 815);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 849);
            Controls.Add(txtNroFactura);
            Controls.Add(lblNroFactura);
            Controls.Add(cboTipoCliente);
            Controls.Add(label4);
            Controls.Add(txtNroPiso);
            Controls.Add(lblNroPiso);
            Controls.Add(lblTipoCliente);
            Controls.Add(btnEjecutar);
            Controls.Add(txtPorcentaje);
            Controls.Add(lblPorcentaje);
            Controls.Add(txtAño);
            Controls.Add(lblAño);
            Controls.Add(txtEnunciado);
            Controls.Add(txtSentencia);
            Controls.Add(lblEnunciado);
            Controls.Add(btnSalir);
            Controls.Add(lblResultado);
            Controls.Add(lblConsulta);
            Controls.Add(dgvResultado);
            Controls.Add(cboConsulta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConsultas";
            Text = "Reportes";
            Load += frmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboConsulta;
        private Label lblConsulta;
        private Label lblEnunciado;
        private TextBox txtSentencia;
        private TextBox txtEnunciado;
        private Label lblAño;
        private TextBox txtAño;
        private Label lblPorcentaje;
        private TextBox txtPorcentaje;
        private Button btnEjecutar;
        private Label lblTipoCliente;
        private Label lblNroPiso;
        private TextBox txtNroPiso;
        private Label label4;
        private ComboBox cboTipoCliente;
        private TextBox txtNroFactura;
        private Label lblNroFactura;
        private DataGridView dgvResultado;
        private Label lblResultado;
        private Button btnSalir;
    }
}