namespace HotelForm.View.Clientes
{
    partial class frmAltaCliente
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
            lblCliente = new Label();
            btnCancelar = new Button();
            btnSalirCliente = new Button();
            btnCargarCliente = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboTipoCliente = new ComboBox();
            label4 = new Label();
            txtNroDocumento = new TextBox();
            txtRazonSocial = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cboTipoDocumento = new ComboBox();
            txtEmail = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(81, 108);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 15);
            lblCliente.TabIndex = 43;
            lblCliente.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Location = new Point(426, 446);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalirCliente
            // 
            btnSalirCliente.Anchor = AnchorStyles.Bottom;
            btnSalirCliente.Location = new Point(316, 446);
            btnSalirCliente.Name = "btnSalirCliente";
            btnSalirCliente.Size = new Size(75, 23);
            btnSalirCliente.TabIndex = 9;
            btnSalirCliente.Text = "Salir";
            btnSalirCliente.UseVisualStyleBackColor = true;
            btnSalirCliente.Click += btnSalirCliente_Click;
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Anchor = AnchorStyles.Bottom;
            btnCargarCliente.Location = new Point(199, 446);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(75, 23);
            btnCargarCliente.TabIndex = 8;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = true;
            btnCargarCliente.Click += btnCargarCliente_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(141, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(471, 100);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(163, 23);
            txtApellido.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(402, 108);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 46;
            label1.Text = "Apellido:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(345, 258);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 48;
            label2.Text = "Numero Documento:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(383, 180);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 50;
            label3.Text = "Tipo de Documento:";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(176, 180);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(121, 23);
            cboTipoCliente.TabIndex = 0;
            cboTipoCliente.SelectedIndexChanged += cboTipoCliente_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(81, 183);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 52;
            label4.Text = "Tipo de Cliente:";
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNroDocumento.Location = new Point(471, 255);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(163, 23);
            txtNroDocumento.TabIndex = 4;
            txtNroDocumento.TextChanged += txtNroDocumento_TextChanged;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRazonSocial.Location = new Point(141, 252);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(163, 23);
            txtRazonSocial.TabIndex = 5;
            txtRazonSocial.TextChanged += txtRazonSocial_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(50, 255);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 55;
            label5.Text = "Razon Social:";
            label5.Click += label5_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(471, 333);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(163, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(349, 336);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 59;
            label6.Text = "Telefono Contacto:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(176, 30);
            label7.Name = "label7";
            label7.Size = new Size(373, 25);
            label7.TabIndex = 61;
            label7.Text = "CARGA DE CLIENTES DEL HOTEL SHIBUYA";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(513, 180);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(121, 23);
            cboTipoDocumento.TabIndex = 3;
            cboTipoDocumento.SelectedIndexChanged += cboTipoDocumento_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(141, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(81, 333);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 63;
            label8.Text = "E-Mail:";
            label8.Click += label8_Click;
            // 
            // frmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(cboTipoDocumento);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtRazonSocial);
            Controls.Add(label5);
            Controls.Add(txtNroDocumento);
            Controls.Add(cboTipoCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalirCliente);
            Controls.Add(btnCargarCliente);
            Name = "frmAltaCliente";
            Text = "Agregar Cliente";
            Load += frmAgregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Button btnCancelar;
        private Button btnSalirCliente;
        private Button btnCargarCliente;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboTipoCliente;
        private Label label4;
        private TextBox txtNroDocumento;
        private TextBox txtRazonSocial;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private Label label7;
        private ComboBox cboTipoDocumento;
        private TextBox txtEmail;
        private Label label8;
    }
}