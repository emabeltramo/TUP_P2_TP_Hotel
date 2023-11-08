namespace HotelForm.View.Reserva
{
    partial class frmModificarReserva
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
            cboModReserva = new ComboBox();
            cboModEstado = new ComboBox();
            btnFiltroReserva = new Button();
            lblModSeleccion = new Label();
            lblModEstado = new Label();
            panelFiltrado = new Panel();
            btnAceptarPanel = new Button();
            btnOcultarPanel = new Button();
            dataGridView1 = new DataGridView();
            btnMostrardgv = new Button();
            cboModCliente = new ComboBox();
            lblModCliente = new Label();
            lblModFP = new Label();
            cboFPMod = new ComboBox();
            btnModificarReserva = new Button();
            btnSalirModificar = new Button();
            cboxModificar = new CheckBox();
            btnEliminar = new Button();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboModReserva
            // 
            cboModReserva.FormattingEnabled = true;
            cboModReserva.Location = new Point(12, 90);
            cboModReserva.Name = "cboModReserva";
            cboModReserva.Size = new Size(181, 23);
            cboModReserva.TabIndex = 0;
            // 
            // cboModEstado
            // 
            cboModEstado.FormattingEnabled = true;
            cboModEstado.Location = new Point(12, 183);
            cboModEstado.Name = "cboModEstado";
            cboModEstado.Size = new Size(144, 23);
            cboModEstado.TabIndex = 1;
            // 
            // btnFiltroReserva
            // 
            btnFiltroReserva.Location = new Point(12, 12);
            btnFiltroReserva.Name = "btnFiltroReserva";
            btnFiltroReserva.Size = new Size(57, 45);
            btnFiltroReserva.TabIndex = 2;
            btnFiltroReserva.Text = "Filtrar";
            btnFiltroReserva.UseVisualStyleBackColor = true;
            btnFiltroReserva.Click += btnFiltroReserva_Click;
            // 
            // lblModSeleccion
            // 
            lblModSeleccion.AutoSize = true;
            lblModSeleccion.Location = new Point(12, 72);
            lblModSeleccion.Name = "lblModSeleccion";
            lblModSeleccion.Size = new Size(113, 15);
            lblModSeleccion.TabIndex = 3;
            lblModSeleccion.Text = "Seleccionar Reserva:";
            // 
            // lblModEstado
            // 
            lblModEstado.AutoSize = true;
            lblModEstado.Location = new Point(12, 165);
            lblModEstado.Name = "lblModEstado";
            lblModEstado.Size = new Size(104, 15);
            lblModEstado.TabIndex = 5;
            lblModEstado.Text = "Estado de Reserva:";
            // 
            // panelFiltrado
            // 
            panelFiltrado.BackColor = SystemColors.AppWorkspace;
            panelFiltrado.Controls.Add(btnAceptarPanel);
            panelFiltrado.Controls.Add(btnOcultarPanel);
            panelFiltrado.Location = new Point(275, 12);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(441, 179);
            panelFiltrado.TabIndex = 6;
            panelFiltrado.Visible = false;
            panelFiltrado.Paint += panelFiltrado_Paint;
            // 
            // btnAceptarPanel
            // 
            btnAceptarPanel.Location = new Point(347, 153);
            btnAceptarPanel.Name = "btnAceptarPanel";
            btnAceptarPanel.Size = new Size(75, 23);
            btnAceptarPanel.TabIndex = 1;
            btnAceptarPanel.Text = "Aceptar";
            btnAceptarPanel.UseVisualStyleBackColor = true;
            // 
            // btnOcultarPanel
            // 
            btnOcultarPanel.Location = new Point(3, 3);
            btnOcultarPanel.Name = "btnOcultarPanel";
            btnOcultarPanel.Size = new Size(108, 23);
            btnOcultarPanel.TabIndex = 0;
            btnOcultarPanel.Text = "Ocultar Panel";
            btnOcultarPanel.UseVisualStyleBackColor = true;
            btnOcultarPanel.Click += btnOcultarPanel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(441, 187);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnMostrardgv
            // 
            btnMostrardgv.Location = new Point(83, 416);
            btnMostrardgv.Name = "btnMostrardgv";
            btnMostrardgv.Size = new Size(119, 23);
            btnMostrardgv.TabIndex = 8;
            btnMostrardgv.Text = "Mostrar Cambios";
            btnMostrardgv.UseVisualStyleBackColor = true;
            // 
            // cboModCliente
            // 
            cboModCliente.FormattingEnabled = true;
            cboModCliente.Location = new Point(12, 249);
            cboModCliente.Name = "cboModCliente";
            cboModCliente.Size = new Size(181, 23);
            cboModCliente.TabIndex = 9;
            // 
            // lblModCliente
            // 
            lblModCliente.AutoSize = true;
            lblModCliente.Location = new Point(12, 231);
            lblModCliente.Name = "lblModCliente";
            lblModCliente.Size = new Size(110, 15);
            lblModCliente.TabIndex = 10;
            lblModCliente.Text = "Seleccionar Cliente:";
            // 
            // lblModFP
            // 
            lblModFP.AutoSize = true;
            lblModFP.Location = new Point(12, 305);
            lblModFP.Name = "lblModFP";
            lblModFP.Size = new Size(90, 15);
            lblModFP.TabIndex = 11;
            lblModFP.Text = "Forma de Pago:";
            lblModFP.Click += lblModFP_Click;
            // 
            // cboFPMod
            // 
            cboFPMod.FormattingEnabled = true;
            cboFPMod.Location = new Point(12, 323);
            cboFPMod.Name = "cboFPMod";
            cboFPMod.Size = new Size(144, 23);
            cboFPMod.TabIndex = 12;
            // 
            // btnModificarReserva
            // 
            btnModificarReserva.Location = new Point(166, 378);
            btnModificarReserva.Name = "btnModificarReserva";
            btnModificarReserva.Size = new Size(82, 23);
            btnModificarReserva.TabIndex = 13;
            btnModificarReserva.Text = "Modificar";
            btnModificarReserva.UseVisualStyleBackColor = true;
            // 
            // btnSalirModificar
            // 
            btnSalirModificar.Location = new Point(326, 443);
            btnSalirModificar.Name = "btnSalirModificar";
            btnSalirModificar.Size = new Size(75, 23);
            btnSalirModificar.TabIndex = 14;
            btnSalirModificar.Text = "Salir";
            btnSalirModificar.UseVisualStyleBackColor = true;
            btnSalirModificar.Click += btnSalirModificar_Click;
            // 
            // cboxModificar
            // 
            cboxModificar.AutoSize = true;
            cboxModificar.Location = new Point(12, 131);
            cboxModificar.Name = "cboxModificar";
            cboxModificar.Size = new Size(77, 19);
            cboxModificar.TabIndex = 15;
            cboxModificar.Text = "Modificar";
            cboxModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(40, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Quitar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ModificarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(btnEliminar);
            Controls.Add(cboxModificar);
            Controls.Add(btnSalirModificar);
            Controls.Add(btnModificarReserva);
            Controls.Add(cboFPMod);
            Controls.Add(lblModFP);
            Controls.Add(lblModCliente);
            Controls.Add(cboModCliente);
            Controls.Add(btnMostrardgv);
            Controls.Add(dataGridView1);
            Controls.Add(panelFiltrado);
            Controls.Add(lblModEstado);
            Controls.Add(lblModSeleccion);
            Controls.Add(btnFiltroReserva);
            Controls.Add(cboModEstado);
            Controls.Add(cboModReserva);
            Name = "ModificarReserva";
            Text = "ModificarReserva";
            panelFiltrado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboModReserva;
        private ComboBox cboModEstado;
        private Button btnFiltroReserva;
        private Label lblModSeleccion;
        private Label lblModEstado;
        private Panel panelFiltrado;
        private DataGridView dataGridView1;
        private Button btnMostrardgv;
        private ComboBox cboModCliente;
        private Label lblModCliente;
        private Label lblModFP;
        private ComboBox cboFPMod;
        private Button btnModificarReserva;
        private Button btnOcultarPanel;
        private Button btnAceptarPanel;
        private Button btnSalirModificar;
        private CheckBox cboxModificar;
        private Button btnEliminar;
    }
}