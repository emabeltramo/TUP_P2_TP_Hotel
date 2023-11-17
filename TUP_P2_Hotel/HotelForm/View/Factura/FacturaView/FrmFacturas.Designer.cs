namespace HotelForm.View.Factura.FacturaView
{
    partial class FrmFacturas
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
            groupBox1 = new GroupBox();
            btnFiltrar = new Button();
            label4 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            cboReserva = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cboCliente = new ComboBox();
            dgvFacturas = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFactura = new DataGridViewTextBoxColumn();
            Colfecha = new DataGridViewTextBoxColumn();
            ColTipoFactura = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            Colver = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.Controls.Add(cboReserva);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboCliente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(599, 22);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(110, 52);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 55);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Reserva: ";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(355, 22);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(238, 23);
            dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(60, 22);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(227, 23);
            dtpDesde.TabIndex = 2;
            // 
            // cboReserva
            // 
            cboReserva.FormattingEnabled = true;
            cboReserva.Location = new Point(355, 52);
            cboReserva.Name = "cboReserva";
            cboReserva.Size = new Size(238, 23);
            cboReserva.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 28);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 55);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Cliente: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(60, 52);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(227, 23);
            cboCliente.TabIndex = 5;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Columns.AddRange(new DataGridViewColumn[] { IdCol, ColCliente, ColFactura, Colfecha, ColTipoFactura, ColTotal, Colver });
            dgvFacturas.Location = new Point(12, 120);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.RowTemplate.Height = 25;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(715, 346);
            dgvFacturas.TabIndex = 1;
            dgvFacturas.CellContentClick += dgvFacturas_CellContentClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "Id";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 155;
            // 
            // ColFactura
            // 
            ColFactura.HeaderText = "N° Factura";
            ColFactura.Name = "ColFactura";
            ColFactura.ReadOnly = true;
            ColFactura.Width = 86;
            // 
            // Colfecha
            // 
            Colfecha.HeaderText = "Fecha";
            Colfecha.Name = "Colfecha";
            Colfecha.ReadOnly = true;
            Colfecha.Width = 110;
            // 
            // ColTipoFactura
            // 
            ColTipoFactura.HeaderText = "Tipo de Factura";
            ColTipoFactura.Name = "ColTipoFactura";
            ColTipoFactura.ReadOnly = true;
            ColTipoFactura.Width = 111;
            // 
            // ColTotal
            // 
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            ColTotal.Width = 110;
            // 
            // Colver
            // 
            Colver.HeaderText = "Ver";
            Colver.Name = "Colver";
            Colver.ReadOnly = true;
            Colver.Text = "Ver";
            Colver.UseColumnTextForButtonValue = true;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(dgvFacturas);
            Controls.Add(groupBox1);
            Name = "FrmFacturas";
            Text = "ModificarFacturas";
            Load += FrmFacturas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label label3;
        private ComboBox cboCliente;
        private Button btnFiltrar;
        private DataGridView dgvFacturas;
        private ComboBox cboReserva;
        private Label label4;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFactura;
        private DataGridViewTextBoxColumn Colfecha;
        private DataGridViewTextBoxColumn ColTipoFactura;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewButtonColumn Colver;
    }
}