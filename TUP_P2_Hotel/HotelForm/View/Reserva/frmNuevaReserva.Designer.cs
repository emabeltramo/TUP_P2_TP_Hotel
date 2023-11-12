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
            dtpDesde = new DateTimePicker();
            btnCargarReserva = new Button();
            btnSalirReserva = new Button();
            btnCancelarReserva = new Button();
            lblCliente = new Label();
            lblDesde = new Label();
            lblAdvertencia = new Label();
            gbFechas = new GroupBox();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblHabReserv = new Label();
            lblHabDisp = new Label();
            lblHotel = new Label();
            cboHotel = new ComboBox();
            lblLocalidad = new Label();
            cboLocalidad = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnAgregarResumen = new Button();
            lblProvincias = new Label();
            dgvNuevaReserva = new DataGridView();
            cboProvincia = new ComboBox();
            tabPage2 = new TabPage();
            gbFechas.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNuevaReserva).BeginInit();
            SuspendLayout();
            // 
            // cboClienteReserva
            // 
            cboClienteReserva.Anchor = AnchorStyles.None;
            cboClienteReserva.FormattingEnabled = true;
            cboClienteReserva.Location = new Point(67, 41);
            cboClienteReserva.Name = "cboClienteReserva";
            cboClienteReserva.Size = new Size(381, 23);
            cboClienteReserva.TabIndex = 0;
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.None;
            dtpDesde.Location = new Point(53, 31);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(240, 23);
            dtpDesde.TabIndex = 6;
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
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Cliente:";
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.None;
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(6, 37);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 15;
            lblDesde.Text = "Desde:";
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
            // gbFechas
            // 
            gbFechas.Controls.Add(lblHasta);
            gbFechas.Controls.Add(dtpHasta);
            gbFechas.Controls.Add(lblDesde);
            gbFechas.Controls.Add(dtpDesde);
            gbFechas.Location = new Point(14, 79);
            gbFechas.Name = "gbFechas";
            gbFechas.Size = new Size(713, 85);
            gbFechas.TabIndex = 29;
            gbFechas.TabStop = false;
            gbFechas.Text = "Fechas de la Reserva";
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.None;
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(337, 35);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 17;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.None;
            dtpHasta.Location = new Point(384, 29);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(240, 23);
            dtpHasta.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 170);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(713, 267);
            tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblHabReserv);
            tabPage1.Controls.Add(lblHabDisp);
            tabPage1.Controls.Add(lblHotel);
            tabPage1.Controls.Add(cboHotel);
            tabPage1.Controls.Add(lblLocalidad);
            tabPage1.Controls.Add(cboLocalidad);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnAgregarResumen);
            tabPage1.Controls.Add(lblProvincias);
            tabPage1.Controls.Add(dgvNuevaReserva);
            tabPage1.Controls.Add(cboProvincia);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(705, 239);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblHabReserv
            // 
            lblHabReserv.Anchor = AnchorStyles.None;
            lblHabReserv.AutoSize = true;
            lblHabReserv.Location = new Point(389, 40);
            lblHabReserv.Name = "lblHabReserv";
            lblHabReserv.Size = new Size(140, 15);
            lblHabReserv.TabIndex = 49;
            lblHabReserv.Text = "Habitaciones Reservadas:";
            // 
            // lblHabDisp
            // 
            lblHabDisp.Anchor = AnchorStyles.None;
            lblHabDisp.AutoSize = true;
            lblHabDisp.Location = new Point(6, 40);
            lblHabDisp.Name = "lblHabDisp";
            lblHabDisp.Size = new Size(143, 15);
            lblHabDisp.TabIndex = 48;
            lblHabDisp.Text = "Habitaciones Disponibles:";
            // 
            // lblHotel
            // 
            lblHotel.Anchor = AnchorStyles.None;
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(473, 15);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(39, 15);
            lblHotel.TabIndex = 47;
            lblHotel.Text = "Hotel:";
            // 
            // cboHotel
            // 
            cboHotel.Anchor = AnchorStyles.None;
            cboHotel.FormattingEnabled = true;
            cboHotel.Location = new Point(518, 7);
            cboHotel.Name = "cboHotel";
            cboHotel.Size = new Size(162, 23);
            cboHotel.TabIndex = 46;
            // 
            // lblLocalidad
            // 
            lblLocalidad.Anchor = AnchorStyles.None;
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(240, 10);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 45;
            lblLocalidad.Text = "Localidad:";
            // 
            // cboLocalidad
            // 
            cboLocalidad.Anchor = AnchorStyles.None;
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(305, 7);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(162, 23);
            cboLocalidad.TabIndex = 44;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(322, 146);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 43;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(389, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(310, 173);
            dataGridView1.TabIndex = 42;
            // 
            // btnAgregarResumen
            // 
            btnAgregarResumen.Anchor = AnchorStyles.None;
            btnAgregarResumen.Location = new Point(322, 86);
            btnAgregarResumen.Name = "btnAgregarResumen";
            btnAgregarResumen.Size = new Size(61, 23);
            btnAgregarResumen.TabIndex = 41;
            btnAgregarResumen.Text = ">";
            btnAgregarResumen.UseVisualStyleBackColor = true;
            // 
            // lblProvincias
            // 
            lblProvincias.Anchor = AnchorStyles.None;
            lblProvincias.AutoSize = true;
            lblProvincias.Location = new Point(-4, 10);
            lblProvincias.Name = "lblProvincias";
            lblProvincias.Size = new Size(59, 15);
            lblProvincias.TabIndex = 40;
            lblProvincias.Text = "Provincia:";
            // 
            // dgvNuevaReserva
            // 
            dgvNuevaReserva.Anchor = AnchorStyles.None;
            dgvNuevaReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevaReserva.Location = new Point(6, 58);
            dgvNuevaReserva.Name = "dgvNuevaReserva";
            dgvNuevaReserva.RowTemplate.Height = 25;
            dgvNuevaReserva.Size = new Size(310, 173);
            dgvNuevaReserva.TabIndex = 39;
            // 
            // cboProvincia
            // 
            cboProvincia.Anchor = AnchorStyles.None;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(61, 7);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(162, 23);
            cboProvincia.TabIndex = 38;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(705, 239);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmNuevaReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(tabControl1);
            Controls.Add(gbFechas);
            Controls.Add(lblAdvertencia);
            Controls.Add(lblCliente);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnSalirReserva);
            Controls.Add(btnCargarReserva);
            Controls.Add(cboClienteReserva);
            Name = "frmNuevaReserva";
            Text = "NuevaReserva";
            Load += frmNuevaReserva_Load_2;
            gbFechas.ResumeLayout(false);
            gbFechas.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNuevaReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboClienteReserva;
        private DateTimePicker dtpDesde;
        private Button btnCargarReserva;
        private Button btnSalirReserva;
        private Button btnCancelarReserva;
        private Label lblCliente;
        private Label lblDesde;
        private Label lblAdvertencia;
        private GroupBox gbFechas;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblHabReserv;
        private Label lblHabDisp;
        private Label lblHotel;
        private ComboBox cboHotel;
        private Label lblLocalidad;
        private ComboBox cboLocalidad;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnAgregarResumen;
        private Label lblProvincias;
        private DataGridView dgvNuevaReserva;
        private ComboBox cboProvincia;
        private TabPage tabPage2;
    }
}