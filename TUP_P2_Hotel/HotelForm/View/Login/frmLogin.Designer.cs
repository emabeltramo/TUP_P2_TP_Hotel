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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSingIn
            // 
            this.btnSingIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSingIn.AutoSize = true;
            this.btnSingIn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSingIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSingIn.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSingIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSingIn.Location = new System.Drawing.Point(414, 410);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(143, 26);
            this.btnSingIn.TabIndex = 1;
            this.btnSingIn.Text = "Inciar Sesión";
            this.btnSingIn.UseVisualStyleBackColor = false;
            this.btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // cboUsuario
            // 
            this.cboUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Items.AddRange(new object[] {
            "mateo",
            "delfi",
            "ema",
            "claudio",
            "fede",
            "mati"});
            this.cboUsuario.Location = new System.Drawing.Point(371, 349);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(224, 24);
            this.cboUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(370, 253);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(154, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "INGRESE SU USUARIO";
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblObligatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblObligatorio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblObligatorio.Location = new System.Drawing.Point(521, 251);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(15, 20);
            this.lblObligatorio.TabIndex = 4;
            this.lblObligatorio.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(370, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Este campo es obligatorio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblObligatorio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1000, 651);
            this.Name = "Form1";
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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