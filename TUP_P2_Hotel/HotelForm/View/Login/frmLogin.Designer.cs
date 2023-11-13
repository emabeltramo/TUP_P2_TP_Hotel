namespace HotelForm.View.Login
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            btnSingIn = new Button();
            cboUsuario = new ComboBox();
            lblUsuario = new Label();
            lblObligatorio = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 574);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnSingIn
            // 
            btnSingIn.Anchor = AnchorStyles.None;
            btnSingIn.AutoSize = true;
            btnSingIn.BackColor = Color.Gainsboro;
            btnSingIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnSingIn.Font = new Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSingIn.ImageAlign = ContentAlignment.TopCenter;
            btnSingIn.Location = new Point(414, 384);
            btnSingIn.Name = "btnSingIn";
            btnSingIn.Size = new Size(143, 24);
            btnSingIn.TabIndex = 1;
            btnSingIn.Text = "Inciar Sesión";
            btnSingIn.UseVisualStyleBackColor = false;
            btnSingIn.Click += btnSingIn_Click;
            // 
            // cboUsuario
            // 
            cboUsuario.Anchor = AnchorStyles.None;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Items.AddRange(new object[] { "mateo", "delfi", "ema", "claudio", "fede", "mati" });
            cboUsuario.Location = new Point(371, 327);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(224, 23);
            cboUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Eras Medium ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(370, 237);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(154, 18);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "INGRESE SU USUARIO";
            // 
            // lblObligatorio
            // 
            lblObligatorio.Anchor = AnchorStyles.None;
            lblObligatorio.AutoSize = true;
            lblObligatorio.BackColor = Color.Transparent;
            lblObligatorio.FlatStyle = FlatStyle.Flat;
            lblObligatorio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblObligatorio.ForeColor = Color.Firebrick;
            lblObligatorio.Location = new Point(521, 235);
            lblObligatorio.Name = "lblObligatorio";
            lblObligatorio.Size = new Size(15, 20);
            lblObligatorio.TabIndex = 4;
            lblObligatorio.Text = "*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(370, 257);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 5;
            label1.Text = "Este campo es obligatorio";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 574);
            Controls.Add(label1);
            Controls.Add(lblObligatorio);
            Controls.Add(lblUsuario);
            Controls.Add(cboUsuario);
            Controls.Add(btnSingIn);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(1000, 613);
            Name = "frmLogin";
            Text = "Iniciar Sesion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        private Button btnSingIn;
        private ComboBox cboUsuario;
        private Label lblUsuario;
        private Label lblObligatorio;
        private Label label1;
    }
}