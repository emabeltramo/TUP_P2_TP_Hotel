namespace HotelForm.View.Principal
{
    partial class frmConsultarReserva
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
            cboSeleccionar = new ComboBox();
            lblSeleccionar = new Label();
            btnConsultar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboSeleccionar
            // 
            cboSeleccionar.FormattingEnabled = true;
            cboSeleccionar.Location = new Point(12, 47);
            cboSeleccionar.Name = "cboSeleccionar";
            cboSeleccionar.Size = new Size(233, 23);
            cboSeleccionar.TabIndex = 0;
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.AutoSize = true;
            lblSeleccionar.Location = new Point(12, 29);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(141, 15);
            lblSeleccionar.TabIndex = 1;
            lblSeleccionar.Text = "Seleccionar una consulta:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(625, 215);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(102, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 99);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "ENUNCIADO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(715, 175);
            dataGridView1.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(324, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnConsultar);
            Controls.Add(lblSeleccionar);
            Controls.Add(cboSeleccionar);
            Name = "Consultas";
            Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSeleccionar;
        private Label lblSeleccionar;
        private Button btnConsultar;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSalir;
    }
}