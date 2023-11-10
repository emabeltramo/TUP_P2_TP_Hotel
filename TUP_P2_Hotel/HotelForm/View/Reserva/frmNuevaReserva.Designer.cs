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
            this.cboClienteReserva = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnCargarReserva = new System.Windows.Forms.Button();
            this.btnSalirReserva = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblHabReserv = new System.Windows.Forms.Label();
            this.lblHabDisp = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarResumen = new System.Windows.Forms.Button();
            this.lblProvincias = new System.Windows.Forms.Label();
            this.dgvNuevaReserva = new System.Windows.Forms.DataGridView();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.gbFechas.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClienteReserva
            // 
            this.cboClienteReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboClienteReserva.FormattingEnabled = true;
            this.cboClienteReserva.Location = new System.Drawing.Point(67, 41);
            this.cboClienteReserva.Name = "cboClienteReserva";
            this.cboClienteReserva.Size = new System.Drawing.Size(381, 23);
            this.cboClienteReserva.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDesde.Location = new System.Drawing.Point(53, 31);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(240, 23);
            this.dtpDesde.TabIndex = 6;
            // 
            // btnCargarReserva
            // 
            this.btnCargarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarReserva.Location = new System.Drawing.Point(232, 443);
            this.btnCargarReserva.Name = "btnCargarReserva";
            this.btnCargarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCargarReserva.TabIndex = 9;
            this.btnCargarReserva.Text = "Cargar";
            this.btnCargarReserva.UseVisualStyleBackColor = true;
            // 
            // btnSalirReserva
            // 
            this.btnSalirReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirReserva.Location = new System.Drawing.Point(349, 443);
            this.btnSalirReserva.Name = "btnSalirReserva";
            this.btnSalirReserva.Size = new System.Drawing.Size(75, 23);
            this.btnSalirReserva.TabIndex = 10;
            this.btnSalirReserva.Text = "Salir";
            this.btnSalirReserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarReserva.Location = new System.Drawing.Point(459, 443);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 11;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(14, 44);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 37);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 15);
            this.lblDesde.TabIndex = 15;
            this.lblDesde.Text = "Desde:";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(14, 9);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(217, 15);
            this.lblAdvertencia.TabIndex = 21;
            this.lblAdvertencia.Text = "INGRESE LOS DATOS POR HABITACION*";
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.lblHasta);
            this.gbFechas.Controls.Add(this.dtpHasta);
            this.gbFechas.Controls.Add(this.lblDesde);
            this.gbFechas.Controls.Add(this.dtpDesde);
            this.gbFechas.Location = new System.Drawing.Point(14, 79);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(713, 85);
            this.gbFechas.TabIndex = 29;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Fechas de la Reserva";
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(337, 35);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 15);
            this.lblHasta.TabIndex = 17;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHasta.Location = new System.Drawing.Point(384, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(240, 23);
            this.dtpHasta.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 267);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblHabReserv);
            this.tabPage1.Controls.Add(this.lblHabDisp);
            this.tabPage1.Controls.Add(this.lblHotel);
            this.tabPage1.Controls.Add(this.cboHotel);
            this.tabPage1.Controls.Add(this.lblLocalidad);
            this.tabPage1.Controls.Add(this.cboLocalidad);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnAgregarResumen);
            this.tabPage1.Controls.Add(this.lblProvincias);
            this.tabPage1.Controls.Add(this.dgvNuevaReserva);
            this.tabPage1.Controls.Add(this.cboProvincia);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblHabReserv
            // 
            this.lblHabReserv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHabReserv.AutoSize = true;
            this.lblHabReserv.Location = new System.Drawing.Point(389, 40);
            this.lblHabReserv.Name = "lblHabReserv";
            this.lblHabReserv.Size = new System.Drawing.Size(140, 15);
            this.lblHabReserv.TabIndex = 49;
            this.lblHabReserv.Text = "Habitaciones Reservadas:";
            // 
            // lblHabDisp
            // 
            this.lblHabDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHabDisp.AutoSize = true;
            this.lblHabDisp.Location = new System.Drawing.Point(6, 40);
            this.lblHabDisp.Name = "lblHabDisp";
            this.lblHabDisp.Size = new System.Drawing.Size(143, 15);
            this.lblHabDisp.TabIndex = 48;
            this.lblHabDisp.Text = "Habitaciones Disponibles:";
            // 
            // lblHotel
            // 
            this.lblHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(473, 15);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(39, 15);
            this.lblHotel.TabIndex = 47;
            this.lblHotel.Text = "Hotel:";
            // 
            // cboHotel
            // 
            this.cboHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(518, 7);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(162, 23);
            this.cboHotel.TabIndex = 46;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(240, 10);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(61, 15);
            this.lblLocalidad.TabIndex = 45;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(305, 7);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(162, 23);
            this.cboLocalidad.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(322, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(310, 173);
            this.dataGridView1.TabIndex = 42;
            // 
            // btnAgregarResumen
            // 
            this.btnAgregarResumen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarResumen.Location = new System.Drawing.Point(322, 86);
            this.btnAgregarResumen.Name = "btnAgregarResumen";
            this.btnAgregarResumen.Size = new System.Drawing.Size(61, 23);
            this.btnAgregarResumen.TabIndex = 41;
            this.btnAgregarResumen.Text = ">";
            this.btnAgregarResumen.UseVisualStyleBackColor = true;
            // 
            // lblProvincias
            // 
            this.lblProvincias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProvincias.AutoSize = true;
            this.lblProvincias.Location = new System.Drawing.Point(-4, 10);
            this.lblProvincias.Name = "lblProvincias";
            this.lblProvincias.Size = new System.Drawing.Size(59, 15);
            this.lblProvincias.TabIndex = 40;
            this.lblProvincias.Text = "Provincia:";
            // 
            // dgvNuevaReserva
            // 
            this.dgvNuevaReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNuevaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevaReserva.Location = new System.Drawing.Point(6, 58);
            this.dgvNuevaReserva.Name = "dgvNuevaReserva";
            this.dgvNuevaReserva.RowTemplate.Height = 25;
            this.dgvNuevaReserva.Size = new System.Drawing.Size(310, 173);
            this.dgvNuevaReserva.TabIndex = 39;
            // 
            // cboProvincia
            // 
            this.cboProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(61, 7);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(162, 23);
            this.cboProvincia.TabIndex = 38;
            // 
            // frmNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 478);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbFechas);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnSalirReserva);
            this.Controls.Add(this.btnCargarReserva);
            this.Controls.Add(this.cboClienteReserva);
            this.Name = "frmNuevaReserva";
            this.Text = "NuevaReserva";
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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