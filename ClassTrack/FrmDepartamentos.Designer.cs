namespace ClassTrack
{
    partial class FrmDepartamentos
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            dgvDepartamentos = new DataGridView();
            lblTitulo = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 76);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(152, 15);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "Nombre del Departamento:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(44, 100);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 29;
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamentos.Location = new Point(246, 35);
            dgvDepartamentos.Margin = new Padding(2);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.RowHeadersWidth = 62;
            dgvDepartamentos.Size = new Size(255, 166);
            dgvDepartamentos.TabIndex = 28;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 23);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(128, 21);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "Departamentos";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(59, 222);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(396, 222);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(dgvDepartamentos);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FrmDepartamentos";
            Text = "FrmDepartamentos";
            Load += FrmDepartamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private DataGridView dgvDepartamentos;
        private Label lblTitulo;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}