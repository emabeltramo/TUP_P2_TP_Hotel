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
            cboCategoriaHabitacion = new ComboBox();
            cboHabitacionDisponible = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dgvNuevaReserva = new DataGridView();
            btnCargarReserva = new Button();
            btnSalirReserva = new Button();
            btnCancelarReserva = new Button();
            lblCliente = new Label();
            lblAdultos = new Label();
            lblNiños = new Label();
            lblFechaReserva = new Label();
            lblCategoriaHabitacion = new Label();
            lblHabitacionDisponible = new Label();
            btnAgregarResumen = new Button();
            panelPagoReserva = new Panel();
            lblIMPUESTOS = new Label();
            lblTOTAL = new Label();
            lblADELANTO = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            cboAlternativaPago = new ComboBox();
            chbPagoAlterReserva = new CheckBox();
            cboFormaPago = new ComboBox();
            lblPagoReserva = new Label();
            btnvistapreviaReserva = new Button();
            lblAdvertencia = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            cboEstadoReserva = new ComboBox();
            lblEstadoReserva = new Label();
            lblSUBTOTAL = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNuevaReserva).BeginInit();
            panelPagoReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // cboClienteReserva
            // 
            cboClienteReserva.Anchor = AnchorStyles.None;
            cboClienteReserva.FormattingEnabled = true;
            cboClienteReserva.Location = new Point(14, 62);
            cboClienteReserva.Name = "cboClienteReserva";
            cboClienteReserva.Size = new Size(181, 23);
            cboClienteReserva.TabIndex = 0;
            cboClienteReserva.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboCategoriaHabitacion
            // 
            cboCategoriaHabitacion.Anchor = AnchorStyles.None;
            cboCategoriaHabitacion.FormattingEnabled = true;
            cboCategoriaHabitacion.Location = new Point(264, 119);
            cboCategoriaHabitacion.Name = "cboCategoriaHabitacion";
            cboCategoriaHabitacion.Size = new Size(184, 23);
            cboCategoriaHabitacion.TabIndex = 3;
            // 
            // cboHabitacionDisponible
            // 
            cboHabitacionDisponible.Anchor = AnchorStyles.None;
            cboHabitacionDisponible.FormattingEnabled = true;
            cboHabitacionDisponible.Location = new Point(14, 185);
            cboHabitacionDisponible.Name = "cboHabitacionDisponible";
            cboHabitacionDisponible.Size = new Size(162, 23);
            cboHabitacionDisponible.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(14, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dgvNuevaReserva
            // 
            dgvNuevaReserva.Anchor = AnchorStyles.None;
            dgvNuevaReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevaReserva.Location = new Point(14, 250);
            dgvNuevaReserva.Name = "dgvNuevaReserva";
            dgvNuevaReserva.RowTemplate.Height = 25;
            dgvNuevaReserva.Size = new Size(434, 173);
            dgvNuevaReserva.TabIndex = 7;
            // 
            // btnCargarReserva
            // 
            btnCargarReserva.Anchor = AnchorStyles.None;
            btnCargarReserva.Location = new Point(232, 443);
            btnCargarReserva.Name = "btnCargarReserva";
            btnCargarReserva.Size = new Size(75, 23);
            btnCargarReserva.TabIndex = 9;
            btnCargarReserva.Text = "Cargar";
            btnCargarReserva.UseVisualStyleBackColor = true;
            // 
            // btnSalirReserva
            // 
            btnSalirReserva.Anchor = AnchorStyles.None;
            btnSalirReserva.Location = new Point(349, 443);
            btnSalirReserva.Name = "btnSalirReserva";
            btnSalirReserva.Size = new Size(75, 23);
            btnSalirReserva.TabIndex = 10;
            btnSalirReserva.Text = "Salir";
            btnSalirReserva.UseVisualStyleBackColor = true;
            btnSalirReserva.Click += btnSalirReserva_Click;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.Anchor = AnchorStyles.None;
            btnCancelarReserva.Location = new Point(459, 443);
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
            lblCliente.Location = new Point(14, 44);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(110, 15);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Seleccionar Cliente:";
            // 
            // lblAdultos
            // 
            lblAdultos.Anchor = AnchorStyles.None;
            lblAdultos.AutoSize = true;
            lblAdultos.Location = new Point(216, 46);
            lblAdultos.Name = "lblAdultos";
            lblAdultos.Size = new Size(118, 15);
            lblAdultos.TabIndex = 13;
            lblAdultos.Text = "Cantidad de Adultos:";
            
            // 
            // lblNiños
            // 
            lblNiños.Anchor = AnchorStyles.None;
            lblNiños.AutoSize = true;
            lblNiños.Location = new Point(340, 46);
            lblNiños.Name = "lblNiños";
            lblNiños.Size = new Size(108, 15);
            lblNiños.TabIndex = 14;
            lblNiños.Text = "Cantidad de Niños:";
            // 
            // lblFechaReserva
            // 
            lblFechaReserva.Anchor = AnchorStyles.None;
            lblFechaReserva.AutoSize = true;
            lblFechaReserva.Location = new Point(14, 101);
            lblFechaReserva.Name = "lblFechaReserva";
            lblFechaReserva.Size = new Size(102, 15);
            lblFechaReserva.TabIndex = 15;
            lblFechaReserva.Text = "Seleccionar fecha:";
            // 
            // lblCategoriaHabitacion
            // 
            lblCategoriaHabitacion.Anchor = AnchorStyles.None;
            lblCategoriaHabitacion.AutoSize = true;
            lblCategoriaHabitacion.Location = new Point(264, 101);
            lblCategoriaHabitacion.Name = "lblCategoriaHabitacion";
            lblCategoriaHabitacion.Size = new Size(138, 15);
            lblCategoriaHabitacion.TabIndex = 16;
            lblCategoriaHabitacion.Text = "Categoria de Habitacion:";
            // 
            // lblHabitacionDisponible
            // 
            lblHabitacionDisponible.Anchor = AnchorStyles.None;
            lblHabitacionDisponible.AutoSize = true;
            lblHabitacionDisponible.Location = new Point(14, 167);
            lblHabitacionDisponible.Name = "lblHabitacionDisponible";
            lblHabitacionDisponible.Size = new Size(127, 15);
            lblHabitacionDisponible.TabIndex = 18;
            lblHabitacionDisponible.Text = "Habitacion Disponible:";
            // 
            // btnAgregarResumen
            // 
            btnAgregarResumen.Anchor = AnchorStyles.None;
            btnAgregarResumen.Location = new Point(202, 221);
            btnAgregarResumen.Name = "btnAgregarResumen";
            btnAgregarResumen.Size = new Size(75, 23);
            btnAgregarResumen.TabIndex = 19;
            btnAgregarResumen.Text = "Agregar ";
            btnAgregarResumen.UseVisualStyleBackColor = true;
            // 
            // panelPagoReserva
            // 
            panelPagoReserva.Anchor = AnchorStyles.None;
            panelPagoReserva.BackColor = SystemColors.ActiveCaption;
            panelPagoReserva.Controls.Add(lblSUBTOTAL);
            panelPagoReserva.Controls.Add(lblIMPUESTOS);
            panelPagoReserva.Controls.Add(lblTOTAL);
            panelPagoReserva.Controls.Add(lblADELANTO);
            panelPagoReserva.Controls.Add(label10);
            panelPagoReserva.Controls.Add(label9);
            panelPagoReserva.Controls.Add(label8);
            panelPagoReserva.Controls.Add(label7);
            panelPagoReserva.Controls.Add(label6);
            panelPagoReserva.Controls.Add(label5);
            panelPagoReserva.Controls.Add(label4);
            panelPagoReserva.Controls.Add(label3);
            panelPagoReserva.Controls.Add(label2);
            panelPagoReserva.Controls.Add(textBox1);
            panelPagoReserva.Controls.Add(label1);
            panelPagoReserva.Controls.Add(cboAlternativaPago);
            panelPagoReserva.Controls.Add(chbPagoAlterReserva);
            panelPagoReserva.Controls.Add(cboFormaPago);
            panelPagoReserva.Controls.Add(lblPagoReserva);
            panelPagoReserva.Controls.Add(btnvistapreviaReserva);
            panelPagoReserva.Location = new Point(476, 26);
            panelPagoReserva.Name = "panelPagoReserva";
            panelPagoReserva.Size = new Size(251, 397);
            panelPagoReserva.TabIndex = 20;
            // 
            // lblIMPUESTOS
            // 
            lblIMPUESTOS.AutoSize = true;
            lblIMPUESTOS.Location = new Point(167, 291);
            lblIMPUESTOS.Name = "lblIMPUESTOS";
            lblIMPUESTOS.Size = new Size(43, 15);
            lblIMPUESTOS.TabIndex = 37;
            lblIMPUESTOS.Text = "$$$$$$";
            // 
            // lblTOTAL
            // 
            lblTOTAL.AutoSize = true;
            lblTOTAL.Location = new Point(167, 276);
            lblTOTAL.Name = "lblTOTAL";
            lblTOTAL.Size = new Size(43, 15);
            lblTOTAL.TabIndex = 36;
            lblTOTAL.Text = "$$$$$$";
            // 
            // lblADELANTO
            // 
            lblADELANTO.AutoSize = true;
            lblADELANTO.Location = new Point(167, 306);
            lblADELANTO.Name = "lblADELANTO";
            lblADELANTO.Size = new Size(43, 15);
            lblADELANTO.TabIndex = 35;
            lblADELANTO.Text = "$$$$$$";
           
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 341);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 34;
            label10.Text = "$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 321);
            label9.Name = "label9";
            label9.Size = new Size(217, 15);
            label9.TabIndex = 33;
            label9.Text = "__________________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 341);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 27;
            label8.Text = "SUBTOTAL";
        
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 306);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 32;
            label7.Text = "Adelanto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 291);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 31;
            label6.Text = "Impuestos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 276);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 27;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 244);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 30;
            label4.Text = "Resumen de Pagos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 29;
            label3.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 28;
            label2.Text = "Adelanto de Pago";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 152);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 24;
            label1.Text = "Forma de pago alternativa";

            // 
            // cboAlternativaPago
            // 
            cboAlternativaPago.FormattingEnabled = true;
            cboAlternativaPago.Location = new Point(18, 170);
            cboAlternativaPago.Name = "cboAlternativaPago";
            cboAlternativaPago.Size = new Size(115, 23);
            cboAlternativaPago.TabIndex = 23;
            cboAlternativaPago.SelectedIndexChanged += cboAlternativaPago_SelectedIndexChanged;
            // 
            // chbPagoAlterReserva
            // 
            chbPagoAlterReserva.AutoSize = true;
            chbPagoAlterReserva.Location = new Point(19, 120);
            chbPagoAlterReserva.Name = "chbPagoAlterReserva";
            chbPagoAlterReserva.Size = new Size(114, 19);
            chbPagoAlterReserva.TabIndex = 21;
            chbPagoAlterReserva.Text = "Pago Alternativo";
            chbPagoAlterReserva.UseVisualStyleBackColor = true;
            // 
            // cboFormaPago
            // 
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(18, 36);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(114, 23);
            cboFormaPago.TabIndex = 22;
            // 
            // lblPagoReserva
            // 
            lblPagoReserva.AutoSize = true;
            lblPagoReserva.Location = new Point(18, 18);
            lblPagoReserva.Name = "lblPagoReserva";
            lblPagoReserva.Size = new Size(87, 15);
            lblPagoReserva.TabIndex = 21;
            lblPagoReserva.Text = "Forma de pago";
            // 
            // btnvistapreviaReserva
            // 
            btnvistapreviaReserva.Anchor = AnchorStyles.None;
            btnvistapreviaReserva.Location = new Point(45, 208);
            btnvistapreviaReserva.Name = "btnvistapreviaReserva";
            btnvistapreviaReserva.Size = new Size(155, 23);
            btnvistapreviaReserva.TabIndex = 8;
            btnvistapreviaReserva.Text = "Mostrar Resumen";
            btnvistapreviaReserva.UseVisualStyleBackColor = true;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.BackColor = Color.Transparent;
            lblAdvertencia.ForeColor = Color.Red;
            lblAdvertencia.Location = new Point(14, 9);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(217, 15);
            lblAdvertencia.TabIndex = 21;
            lblAdvertencia.Text = "INGRESE LOS DATOS POR HABITACION*";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(216, 63);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.None;
            numericUpDown2.Location = new Point(340, 62);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(49, 23);
            numericUpDown2.TabIndex = 26;
            // 
            // cboEstadoReserva
            // 
            cboEstadoReserva.FormattingEnabled = true;
            cboEstadoReserva.Location = new Point(327, 185);
            cboEstadoReserva.Name = "cboEstadoReserva";
            cboEstadoReserva.Size = new Size(121, 23);
            cboEstadoReserva.TabIndex = 27;
            // 
            // lblEstadoReserva
            // 
            lblEstadoReserva.AutoSize = true;
            lblEstadoReserva.Location = new Point(327, 167);
            lblEstadoReserva.Name = "lblEstadoReserva";
            lblEstadoReserva.Size = new Size(45, 15);
            lblEstadoReserva.TabIndex = 28;
            lblEstadoReserva.Text = "Estado:";
            // 
            // lblSUBTOTAL
            // 
            lblSUBTOTAL.AutoSize = true;
            lblSUBTOTAL.Location = new Point(160, 341);
            lblSUBTOTAL.Name = "lblSUBTOTAL";
            lblSUBTOTAL.Size = new Size(50, 15);
            lblSUBTOTAL.TabIndex = 38;
            lblSUBTOTAL.Text = "subtotal";
            // 
            // NuevaReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(lblEstadoReserva);
            Controls.Add(cboEstadoReserva);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(lblAdvertencia);
            Controls.Add(panelPagoReserva);
            Controls.Add(btnAgregarResumen);
            Controls.Add(lblHabitacionDisponible);
            Controls.Add(lblCategoriaHabitacion);
            Controls.Add(lblFechaReserva);
            Controls.Add(lblNiños);
            Controls.Add(lblAdultos);
            Controls.Add(lblCliente);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnSalirReserva);
            Controls.Add(btnCargarReserva);
            Controls.Add(dgvNuevaReserva);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboHabitacionDisponible);
            Controls.Add(cboCategoriaHabitacion);
            Controls.Add(cboClienteReserva);
            Name = "NuevaReserva";
            Text = "NuevaReserva";
            Load += NuevaReserva_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNuevaReserva).EndInit();
            panelPagoReserva.ResumeLayout(false);
            panelPagoReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboClienteReserva;
        private ComboBox cboCategoriaHabitacion;
        private ComboBox cboHabitacionDisponible;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvNuevaReserva;
        private Button btnCargarReserva;
        private Button btnSalirReserva;
        private Button btnCancelarReserva;
        private Label lblCliente;
        private Label lblAdultos;
        private Label lblNiños;
        private Label lblFechaReserva;
        private Label lblCategoriaHabitacion;
        private Label lblHabitacionDisponible;
        private Button btnAgregarResumen;
        private Panel panelPagoReserva;
        private Label lblPagoReserva;
        private ComboBox cboAlternativaPago;
        private CheckBox chbPagoAlterReserva;
        private ComboBox cboFormaPago;
        private Label lblAdvertencia;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnvistapreviaReserva;
        private Label lblADELANTO;
        private Label label10;
        private Label label9;
        private Label lblIMPUESTOS;
        private Label lblTOTAL;
        private ComboBox cboEstadoReserva;
        private Label lblEstadoReserva;
        private Label lblSUBTOTAL;
    }
}