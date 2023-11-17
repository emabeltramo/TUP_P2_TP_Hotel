namespace HotelForm.View.Clientes
{
    partial class frmModificarCliente
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
            label7 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtRazonSocial = new TextBox();
            label5 = new Label();
            txtNroDocumento = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lblCliente = new Label();
            btnLimpiar = new Button();
            btnSalirCliente = new Button();
            btnCargarCliente = new Button();
            cboTipoDocumento = new ComboBox();
            cboTipoCliente = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(148, 38);
            label7.Name = "label7";
            label7.Size = new Size(450, 25);
            label7.TabIndex = 81;
            label7.Text = "MODIFICACION DE CLIENTES DEL HOTEL SHIBUYA";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(460, 296);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(163, 23);
            txtTelefono.TabIndex = 80;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(338, 299);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 79;
            label6.Text = "Telefono Contacto:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(136, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 78;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 296);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 77;
            lblEmail.Text = "E-mail:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRazonSocial.Location = new Point(460, 227);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(163, 23);
            txtRazonSocial.TabIndex = 76;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(369, 230);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 75;
            label5.Text = "Razon Social:";
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNroDocumento.Location = new Point(163, 227);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(163, 23);
            txtNroDocumento.TabIndex = 74;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(37, 230);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 69;
            label2.Text = "Numero Documento:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(460, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(163, 23);
            txtApellido.TabIndex = 68;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(391, 154);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 67;
            label1.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(163, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 66;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(103, 146);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 15);
            lblCliente.TabIndex = 65;
            lblCliente.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom;
            btnLimpiar.Location = new Point(381, 436);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 64;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalirCliente
            // 
            btnSalirCliente.Anchor = AnchorStyles.Bottom;
            btnSalirCliente.Location = new Point(279, 436);
            btnSalirCliente.Name = "btnSalirCliente";
            btnSalirCliente.Size = new Size(75, 23);
            btnSalirCliente.TabIndex = 63;
            btnSalirCliente.Text = "Salir";
            btnSalirCliente.UseVisualStyleBackColor = true;
            btnSalirCliente.Click += btnSalirCliente_Click_1;
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Anchor = AnchorStyles.Bottom;
            btnCargarCliente.Location = new Point(103, 391);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(75, 23);
            btnCargarCliente.TabIndex = 62;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = true;
            btnCargarCliente.Click += btnCargarCliente_Click;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(502, 80);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(121, 23);
            cboTipoDocumento.TabIndex = 85;
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(165, 80);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(121, 23);
            cboTipoCliente.TabIndex = 84;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(70, 83);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 87;
            label4.Text = "Tipo de Cliente:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(381, 80);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 86;
            label3.Text = "Tipo de Documento:";
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom;
            btnBorrar.Location = new Point(548, 391);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 88;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(btnBorrar);
            Controls.Add(cboTipoDocumento);
            Controls.Add(cboTipoCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtRazonSocial);
            Controls.Add(label5);
            Controls.Add(txtNroDocumento);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalirCliente);
            Controls.Add(btnCargarCliente);
            Name = "frmModificarCliente";
            Text = "Modificar Cliente";
            Load += frmModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtRazonSocial;
        private Label label5;
        private TextBox txtNroDocumento;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private Label lblCliente;
        private Button btnLimpiar;
        private Button btnSalirCliente;
        private Button btnCargarCliente;
        private ComboBox cboTipoDocumento;
        private ComboBox cboTipoCliente;
        private Label label4;
        private Label label3;
        private Button btnBorrar;
    }
}