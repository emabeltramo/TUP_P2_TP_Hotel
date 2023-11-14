namespace HotelForm.View.Clientes
{
    partial class frmEliminar
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
            cboCliente = new ComboBox();
            label8 = new Label();
            btnCargarCliente = new Button();
            SuspendLayout();
            // 
            // cboCliente
            // 
            cboCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.ItemHeight = 15;
            cboCliente.Location = new Point(178, 181);
            cboCliente.MaxDropDownItems = 35;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(289, 23);
            cboCliente.TabIndex = 85;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(83, 184);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 84;
            label8.Text = "Cliente:";
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Anchor = AnchorStyles.Bottom;
            btnCargarCliente.Location = new Point(567, 184);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(75, 23);
            btnCargarCliente.TabIndex = 86;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = true;
            btnCargarCliente.Click += btnCargarCliente_Click;
            // 
            // frmEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarCliente);
            Controls.Add(cboCliente);
            Controls.Add(label8);
            Name = "frmEliminar";
            Text = "frmEliminar";
            Load += frmEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCliente;
        private Label label8;
        private Button btnCargarCliente;
    }
}