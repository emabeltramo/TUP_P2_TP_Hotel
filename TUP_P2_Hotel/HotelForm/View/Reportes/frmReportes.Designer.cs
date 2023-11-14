namespace HotelForm.View.Reportes
{
    partial class frmReportes
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
            label1 = new Label();
            label2 = new Label();
            cboConsulta = new ComboBox();
            dgvResultado = new DataGridView();
            lblConsulta = new Label();
            lblResultado = new Label();
            button2 = new Button();
            lblString = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(291, 28);
            label1.Name = "label1";
            label1.Size = new Size(165, 45);
            label1.TabIndex = 0;
            label1.Text = "REPORTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 91);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 1;
            label2.Text = "Seleccionar consulta:";
            // 
            // cboConsulta
            // 
            cboConsulta.FormattingEnabled = true;
            cboConsulta.Location = new Point(413, 89);
            cboConsulta.Name = "cboConsulta";
            cboConsulta.Size = new Size(180, 23);
            cboConsulta.TabIndex = 2;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(35, 322);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(704, 176);
            dgvResultado.TabIndex = 3;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsulta.Location = new Point(326, 133);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(71, 21);
            lblConsulta.TabIndex = 4;
            lblConsulta.Text = "Consulta";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(330, 298);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(79, 21);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // button2
            // 
            button2.Location = new Point(309, 523);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 8;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblString.Location = new Point(113, 186);
            lblString.Name = "lblString";
            lblString.Size = new Size(71, 21);
            lblString.TabIndex = 9;
            lblString.Text = "Consulta";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 558);
            Controls.Add(lblString);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Controls.Add(lblConsulta);
            Controls.Add(dgvResultado);
            Controls.Add(cboConsulta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmReportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboConsulta;
        private DataGridView dgvResultado;
        private Label lblConsulta;
        private Label lblResultado;
        private Button button2;
        private Label lblString;
    }
}